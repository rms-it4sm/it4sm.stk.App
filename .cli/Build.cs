using System;
using System.Diagnostics;
using BarsUp.Build;
using BarsUp.Build.Deploy.Tasks;
using BarsUp.Build.Electron;
using BarsUp.Build.Interactive;
using BarsUp.Utils;
using Nuke.Common;
using Nuke.Common.IO;

public partial class Build : BarsUpBuild
{    
    public Build()
    {
        TerminalHelper.InjectAndClearParameters(this);
    }

    public override int MajorVersion => 3;
    public override int MinorVersion => 0;
    
    public override string HostProjectName => "BarsUp.WebHost";
    
    protected Target Interactive => _ => _
        .Description("Интерактивная консоль сборщика")
        .Executes(TerminalHelper.RunTerminal);

    /// <summary>
    /// Сборка Electron-оболочки для хост-приложения на windows
    /// </summary>
    [Group("Публикация")]
    protected virtual Target Electronize => _ => _
        .Description("Сборка Electron-оболочки для хост-приложения")
        .Requires(() => Runtime)
        .Executes(async () => await ElectronizeTask.BuildElectronHostAppAsync(Runtime.Value));
    
    public static int Main()
    {
        var result = Execute<Build>(x => x.Interactive);
        if (Debugger.IsAttached)
        {
            Logger.Warn("Press Enter to proceed...");
            Console.ReadLine();
        }

        return result;
    }
}