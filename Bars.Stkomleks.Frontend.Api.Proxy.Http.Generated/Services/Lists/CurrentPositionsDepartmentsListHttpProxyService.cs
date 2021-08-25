   
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
    /// Сервис для представления 'Занимаемые должности.Подразделение'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Занимаемые должности.Подразделение")]
	    public class CurrentPositionsDepartmentsListHttpProxyService : ListViewServiceHttpProxy<Bars.Stkomleks.CurrentPositionsDepartments, Bars.Stkomleks.CurrentPositionsDepartmentsListModel>, ICurrentPositionsDepartmentsListService
    {                                  
        public CurrentPositionsDepartmentsListHttpProxyService(IWindsorContainer container) 
            : base(container, container.Resolve<FrontendHttpProxyConfig>()) { }

		protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.CurrentPositionsDepartmentsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "788a15f1-40ba-4144-b7a9-45ce08fb1ffc":
            itm._EditorName = "CurrentPositionsDepartmentsEditor";
            break;
    }
}

            await Task.CompletedTask;
        }

        protected override string ControllerName => "CurrentPositionsDepartmentsList";
    }
}