using BarsUp.Build;
using BarsUp.Build.Deploy.Tasks;
using BarsUp.Utils;
using Nuke.Common;
using static BarsUp.Build.Deploy.Tasks.DeployToNginxTasks;

partial class Build
{    
    [StringParameter("Nginx - Целевой сервер")] protected string NginxServer = "";    
    [StringParameter("Nginx - Наименование приложения")] protected string NginxAppName = "";    
    [StringParameter("Nginx - Имя пользователя")] protected string NginxUser = "";
    [PasswordParameter("Nginx - Пароль")] protected string NginxPassword;
    
    [Group("Публикация")]
    protected virtual Target Nginx => _ => _
        .Description("Публикация на сервер Nginx")
        .DependsOn(Restore)
        .Requires(() => NginxServer, () => NginxUser, () => NginxPassword, () => NginxAppName)
        .Executes(() => DeployToNginx(s => s
                                             .SetBarsUpDefaults()
                                             .SetHost(NginxServer)
                                             .SetAppName(NginxAppName)
                                             .SetUserName(NginxUser)
                                             .SetPassword(NginxPassword)));    
}