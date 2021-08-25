namespace BarsUp.WebHost
{
    using BarsUp;
    using BarsUp.IoC;

    [BarsUp.Utils.Display("WebHost")]
    public partial class Module : AssemblyDefinedModule
    {
        /// <summary>
        /// Загрузка модуля
        /// </summary>
        public override void Install()
        {
            Container.RegisterResourceManifest<BarsUp.WebHost.ResourceManifest>();

            InstallPartial();
        }

        protected override void SetDependencies()
        {
            base.SetDependencies();
            DependsOn<Bars.Stkomleks.Core.Module>();
DependsOn<Bars.Stkomleks.Frontend.Api.Module>();
DependsOn<Bars.Stkomleks.Frontend.Api.Proxy.Http.Generated.Module>();
DependsOn<Bars.Stkomleks.Frontend.Module>();

            
            SetDependenciesPartial();
        }

        partial void InstallPartial();
        partial void SetDependenciesPartial();
    }
}