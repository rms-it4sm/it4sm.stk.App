using System;
using System.Linq;
using BarsUp.Utils;
using NuGet.Packaging.Signing;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.IO;
using Nuke.Common.Tools.DotNet;

partial class Build
{
    private Nuke.Common.IO.AbsolutePath _testReportsDirectory;
    private Nuke.Common.IO.AbsolutePath TestReportsDirectory => _testReportsDirectory ??= (OutputDirectory / ".test-reports" / $"{StartedAt:yyyyMMdd.HHmmss.ffff}");
    
    [Group("Тестирование")]
    private Target RunFrontendTests => _ => _
        .Description("Запуск тестов [Frontend.Tests]")
        .DependsOn(Build)
        .Produces(TestReportsDirectory / "*.*")
        .Executes(() =>
        {
            var testProjects = Solution.Projects
                .Where(x => x.Name.EndsWith("Frontend.Tests"))
                .ToArray();

            FileSystemTasks.EnsureCleanDirectory(TestReportsDirectory);
            
            foreach (var project in testProjects)
            {
                using (Logger.Block($"Запуск тестов {project.Name}"))
                {
                    Environment.SetEnvironmentVariable("BARSUP_TEST_REPORT_DIR", TestReportsDirectory, EnvironmentVariableTarget.Process);
                    try
                    {
                        DotNetTasks.DotNetTest(s => s
                            .SetProjectFile(project.AbsolutePath)
                            .SetConfiguration(Configuration.Value.ToString())
                            .SetNoBuild(true)
                            .SetNoRestore(true)
                            .SetResultsDirectory(TestReportsDirectory));
                    }
                    finally
                    {
                        Environment.SetEnvironmentVariable("BARSUP_TEST_REPORT_DIR", null, EnvironmentVariableTarget.Process);
                    }
                }
            }
        });
}