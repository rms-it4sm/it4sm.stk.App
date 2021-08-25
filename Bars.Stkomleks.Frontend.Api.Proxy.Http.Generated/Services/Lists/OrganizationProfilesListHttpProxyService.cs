   
namespace Bars.Stkomleks
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using BarsUp;
    using BarsUp.DataAccess; 
    using System.Collections.Generic;
    
    using System.Diagnostics;
    using BarsUp.Windsor;
    using BarsUp.IoC;
    using BarsUp.Utils;
    
    using Castle.Windsor;
	using NHibernate.Linq;

    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Designer.GeneratedApp.Attributes;
    using BarsUp.Designer.GeneratedApp.Queries;
    using BarsUp.Designer.Core;
    using BarsUp.Designer.Core.TypeSystem;
    using BarsUp.Modules.PostgreSql.DataAccess;
    using BarsUp.Extensions.Json;
    using BarsUp.Designer.GeneratedApp.Commons;
    using BarsUp.Designer.GeneratedApp.Lists;
	using BarsUp.DataAccess.Extentions;    
    
    using System.Threading;
    using System.Threading.Tasks;

    using BarsUp.DataAccess.HqlGenerators;

    /// <summary>
    /// Сервис для представления 'Профили.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Профили.Организация")]
	    public class OrganizationProfilesListHttpProxyService : ListViewServiceHttpProxy<Bars.Stkomleks.OrganizationProfiles, Bars.Stkomleks.OrganizationProfilesListModel>, IOrganizationProfilesListService
    {                                  
        public OrganizationProfilesListHttpProxyService(IWindsorContainer container) 
            : base(container, container.Resolve<FrontendHttpProxyConfig>()) { }

		protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrganizationProfilesListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "2f3cc7da-d8a3-4c53-b83f-ec26f028202e":
            itm._EditorName = "OrganizationProfilesListMultiAddByOrganizationEditor";
            break;
    }
}

            await Task.CompletedTask;
        }

        protected override string ControllerName => "OrganizationProfilesList";
    }
}