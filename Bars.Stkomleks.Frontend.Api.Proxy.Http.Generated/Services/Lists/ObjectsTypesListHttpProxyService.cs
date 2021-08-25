   
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
    /// Сервис для представления 'Типы объектов'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Типы объектов")]
	    public class ObjectsTypesListHttpProxyService : ListViewServiceHttpProxy<Bars.Stkomleks.ObjectsTypes, Bars.Stkomleks.ObjectsTypesListModel>, IObjectsTypesListService
    {                                  
        public ObjectsTypesListHttpProxyService(IWindsorContainer container) 
            : base(container, container.Resolve<FrontendHttpProxyConfig>()) { }

		protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.ObjectsTypesListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "0140e24b-1df6-4672-8302-a2a0cada0e53":
            itm._EditorName = "ObjectsTypesEditor";
            break;
    }
}

            await Task.CompletedTask;
        }

        protected override string ControllerName => "ObjectsTypesList";
    }
}