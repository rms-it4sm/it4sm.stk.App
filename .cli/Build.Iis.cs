using BarsUp.Build;
using BarsUp.Build.Deploy.Tasks;
using BarsUp.Build.Tasks;
using BarsUp.Utils;
using Nuke.Common;
using static BarsUp.Build.Deploy.Tasks.DeployToIisTask;

partial class Build
{
    [StringParameter("Iis - Целевой сервер")]
    protected string IisServer = "";

    [Parameter("Iis - Порт WebDeploy")]
    protected int? IisPort = 8172;

    [StringParameter("Iis - Наименование сайта")]
    protected string IisWebSite = "Default Web Site";

    [StringParameter("Iis - Наименование приложения")]
    protected string IisAppName = "app_it4sm.stk";

    [StringParameter("Iis - Имя пользователя")]
    protected string IisUser = "WebDeploy";

    [PasswordParameter("Iis - Пароль")]
    protected string IisPassword;

    [Group("Публикация")]
    protected virtual Target Iis => _ => _
        .Description("Публикация на сервер Iis")
        .Requires(() => IisServer, () => IisUser, () => IisPassword, () => IisWebSite, () => IisAppName)
        .Executes(async () => await DeployToIis(s => s
            .SetBarsUpDefaults()
            .SetNoRestore(true)
            .SetProfile("Default")
            .SetSite(IisWebSite)
            .SetHost(IisServer)
            .SetPort(IisPort)
            .SetUserName(IisUser)
            .SetPassword(IisPassword)
            .SetAppName(IisAppName)));
}