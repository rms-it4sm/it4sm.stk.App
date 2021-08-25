namespace Bars.Stkomleks.Frontend
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
    
    using Bars.Stkomleks.Frontend.Generated;

    using JetBrains.Annotations;
    using BarsUp.Utils;

    /// <summary>
    /// Класс подключения модуля
    /// </summary>
    [BarsUp.Utils.Display("Стройкомлекс [Frontend]")]    
    [BarsUp.Utils.Attributes.Uid("4efaae9e-8069-dded-e3f5-7f302d11cf88")]
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
            DependsOn<Bars.Stkomleks.Frontend.Generated.Module>();
DependsOn<BarsUp.Designer.GeneratedApp.Module>();
            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
            
        }

            }
}
