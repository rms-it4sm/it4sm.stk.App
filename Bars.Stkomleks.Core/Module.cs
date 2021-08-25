namespace Bars.Stkomleks.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Castle.Windsor;
    using Castle.MicroKernel.Registration;
    using Microsoft.Extensions.DependencyInjection;
    using BarsUp.DataAccess;
	using BarsUp.Extensions.Configuration;
	using BarsUp.Extensions.Reflection;
    using BarsUp.Core.Application;
    
    using Bars.Stkomleks;
    using BarsUp.Application;
    using BarsUp.Windsor;
    using BarsUp;
    using BarsUp.Events;
    using BarsUp.IoC;
    using BarsUp.Registrar;
    
    using Bars.Stkomleks.Core.Generated;
    using BarsUp.Utils;

    /// <summary>
    /// Класс подключения модуля
    /// </summary>
    [BarsUp.Utils.Display("Стройкомлекс [Core]")]    
    [BarsUp.Utils.Attributes.Uid("85092341-9295-88d6-9783-ada93eea408c")]
    public class Module : AssemblyDefinedModule, IAspNetCoreServiceConfigurator
    {        
        /// <summary>
        /// Загрузка модуля
        /// </summary>
        public override void Install()
        {
            AssemblyReplacedTypeResolver.AddAssemblyReplace("Bars.Stkomleks", GetType().Assembly.GetName().Name);
            
        }        
        
        protected override void SetDependencies()
        {
            base.SetDependencies();
            DependsOn<Bars.Stkomleks.Core.Generated.Module>();
DependsOn<BarsUp.Designer.GeneratedApp.Module>();
            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
            
        }

            }
}
