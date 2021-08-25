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
            
            
            SetDependenciesPartial();
        }

        partial void InstallPartial();
        partial void SetDependenciesPartial();
    }
}