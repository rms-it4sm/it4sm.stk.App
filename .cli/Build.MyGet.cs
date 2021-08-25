using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BarsUp.Build;
using BarsUp.Build.MyGet.Tasks;
using BarsUp.Extensions.NuGet;
using BarsUp.Extensions.NuGet.SemanticVersion;
using BarsUp.Utils;
using NuGet.Configuration;
using NuGet.Protocol.Core.Types;
using Nuke.Common;
using static BarsUp.Build.MyGet.MyGetTasks;

partial class Build
{
    [PasswordParameter("Ключ для доступа к API MyGet", Name = "MyGetKey")]
    protected string MyGetKey = "fd1cc3f6-578c-4a8d-8d64-9888db08a8da";

    [StringParameter("Галерея для публикации (MyGet Feed)")]
    protected string MyGetFeed = "rms-projects";

    [Group("Публикация")]
    protected virtual Target Pack => _ => _
        .Description("Сборка пакетов по всем проектам решения и публикация в корпоративную галерею MyGet")
        .DependsOn(Build)
        .Requires(() => MyGetKey, () => MyGetFeed)
        .Executes(() =>
        {
            PublishToMyGet(s => s.SetBarsUpDefaults()
                .SetFeeds(MyGetFeed)
                .SetApiKey(MyGetKey)
                .SetVersion(SolutionVersion)
                .AddProjects("!!*.demo.*")
                .AddProjects("!!*.*test*.*")
                .AddProjects("!!Build")
                .AddPaths("!!*\\demo\\*"));
        });

    [Group("Сервисы")]
    protected Target UpdatePackages => _ => _
        .Description("Актуализация ссылок на пакеты BarsUp")
        .Executes(async () =>
        {
            var nugetFile = RootDirectory / ".nuget" / "NuGet.config";
            if (!File.Exists(nugetFile))
            {
                throw new FileNotFoundException("Конфиг Nuget не найден", nugetFile);
            }

            var feedUrl = NuGet.Configuration.Settings
                .LoadSettingsGivenConfigPaths(new List<string> {nugetFile})
                .GetSection("packageSources")
                ?.Items.OfType<SourceItem>()
                .Where(x => x.Key.EqualsIgnoreCase("BarsUp") || x.Key.StartsWith("BarsUp", StringComparison.OrdinalIgnoreCase))
                .Select(x => x.Value)
                .FirstOrDefault();

            if (feedUrl.IsEmpty())
            {
                throw new NuGetConfigurationException("Конфиг Nuget не содержит источника пакетов BarsUp");
            }

            var repository = new AggregateRepository(new[] {feedUrl});
            Logger.Info("Получение списка пакетов...");
            var meta = await repository.SearchMetaAsync("BarsUp", SearchFilterType.IsLatestVersion, false);
            var map = meta.Select(x => x.Identity)
                .ToDictionary(x => x.Id, x => SemVer.Parse(x.Version.OriginalVersion));

            foreach (var project in Solution.Projects)
            {
                Logger.Info($"Обработка проекта {project.Name}");

                var packageReferences = project.GetPackageReferences();
                var hasChanges = false;
                foreach (var @ref in packageReferences)
                {
                    if (!map.TryGetValue(@ref.PackageId, out var version))
                    {
                        continue;
                    }

                    var refVersion = SemVer.Parse(@ref.Version);
                    if (version != refVersion)
                    {
                        Logger.Info($"Изменение версии пакета {@ref.PackageId} {@ref.Version} --> {version}");
                        @ref.Element.SetAttributeValue("Version", version.ToNormalizedString());
                        hasChanges = true;
                    }
                }

                if (hasChanges)
                {
                    await project.SaveAsync();
                }
            }
        });
}