namespace BarsUp.WebHost
{
    using BarsUp;
    using BarsUp.Utils;

	/// <summary>
    /// Манифест ресурсов модуля
    /// </summary>
    public class ResourceManifest : ResourceManifestBase
    {
        protected override void BaseInit(IResourceManifestContainer container)
        {
            RegisterResource(container, "libs/B4/autostart/WebHost.js");
            RegisterResource(container, "content/favicon.ico");
            RegisterResource(container, "content/login/css/main-custom.css");
            
        }
    }
}
