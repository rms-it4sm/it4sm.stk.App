using System.Collections.Generic;
using BarsUp.Build;
using BarsUp.Build.Docker;
using BarsUp.Build.Tasks;
using BarsUp.Build.Utils;
using BarsUp.Utils;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tools.DotNet;

partial class Build
{
    [StringParameter("Адрес хоста")]
    protected string DockerHost = "registry.bars.group";

    [StringParameter("Наименование проекта")]
    protected string DockerProject = "barsup.net";

    [StringParameter("Наименование образа")]
    protected string DockerImage;

    [StringParameter("Имя пользователя")]
    protected string DockerUsername = "robot$BarsUp.Net-Docker-Robotnic";

    [PasswordParameter("Токен авторизации")]
    protected string DockerToken =
        "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2MjU3ODI4OTQsImlhdCI6MTU5NDI0Njg5NCwiaXNzIjoiaGFyYm9yLXRva2VuLWlzc3VlciIsImlkIjoyMCwicGlkIjoxMSwiYWNjZXNzIjpbeyJSZXNvdXJjZSI6Ii9wcm9qZWN0LzExL3JlcG9zaXRvcnkiLCJBY3Rpb24iOiJwdXNoIiwiRWZmZWN0IjoiIn1dfQ.MAVD7DdVvjwHeEhl5zbfgRArX9-sBRMSH15IZBmUl1oofp0X5M3_xlruXpUKzZm2ZvyM2LF5ezvYq-XaAw1qmcrwhBA0VHYQhcNw_hDo8fnnLXFBr7T40LWroCEbOaQ7m8co-jnSaqYNh2H91tqoIQn63tTAPEHk51c7tzFDvQnGkgnB-aXfo4Fkw7pQiw9k8b_YyHgkqr_cMvcHX9H81AN2ulG2o-30_K8JoIf3hJphRoFkE2_0aWJ9J1-6h6mhkPQjUIFn1BYxxY64wB0k8NE4mDYXdZctY35_uihrAFPTkMjzmba-RZjTCTokw2j9HIb-57XQfv93y5SUfC5QNgPRrynmby1J2Iro16UEJj1fb-POhHrb8AYRI2opzd21QEfIoppP18v7Zbjp71E-95VtntoVhjQFszFbYnlc4MBHjzpX6KRbZn4J6Rqrx9EQkCJPkin6cT5ZLYFwH9M_VGNa5dauC5HkJXPXvCLHJeNos8_H1nlk7YdKet3SIqd0gPP6lkLxOExt82YreCg-8lswJguYeoW_0ynxM1ToPgAaTUDlgFNEmwnzm3dANJBOri5rvnQpqKSKsKfi-mCQ6MKvC9yQVfPForB-qXwZsPcFsBRcX-rpjV7seYQQPEom3IGb2SAaFpqHnFHNvOnN2vlzw-BznzjcLEpuZwdYDfY";

    [Group("Публикация")]
    protected virtual Target Docker => _ => _
        .Description("Публикация в репозиторий Docker")
        .Requires(() => DockerHost, () => DockerProject, () => DockerImage, () => DockerUsername, () => DockerToken)
        .Executes(() =>
        {
            var hostDataMap = new Dictionary<string, string> {{Instance.HostProjectPath, "monolith"}};

            foreach (var additionalHostName in new[] {"BackgroundWorkers", "Frontend"})
            {
                var hostProjectName = $"BarsUp.{additionalHostName}.Host";
                var hostProjectPath = RootDirectory / hostProjectName / (hostProjectName + ".csproj");
                hostDataMap.Add(hostProjectPath, additionalHostName.ToLower());
            }

            foreach (var (hostProjectPath, imagePostfix) in hostDataMap)
            {
                DotNetTasks.DotNetRestore(s => s
                    .SetConfigFile(RootDirectory / ".nuget" / "NuGet.config")
                    .SetProjectFile(hostProjectPath));

                BuildUtils.PublishHostProject(
                    TargetRuntime.Options.Linux,
                    OutputDirectory / TargetRuntime.Options.Linux.RuntimeName(),
                    (AbsolutePath)hostProjectPath,
                    BuildUtils.SkipImplicitOperationOnPublish.Restore,
                    PublishSingleFileOptions.Simple,
                    Configuration.Value);

                DeployToDockerTasks.PublishToDockerRegistry(s =>
                    s.SetBarsUpDefaults()
                        .SetHostProjectPath(hostProjectPath)
                        .SetRegistryHost(DockerHost)
                        .SetProject(DockerProject)
                        .SetImage($"{DockerImage}-{imagePostfix}")
                        .SetUsername(DockerUsername)
                        .SetToken(DockerToken));
            }
        });
}