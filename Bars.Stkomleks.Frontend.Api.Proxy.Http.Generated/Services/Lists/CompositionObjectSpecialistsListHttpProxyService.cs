   
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
    /// Сервис для представления 'Специалисты.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Специалисты.Объект")]
	    public class CompositionObjectSpecialistsListHttpProxyService : ListViewServiceHttpProxy<Bars.Stkomleks.CompositionObjectSpecialists, Bars.Stkomleks.CompositionObjectSpecialistsListModel>, ICompositionObjectSpecialistsListService
    {                                  
        public CompositionObjectSpecialistsListHttpProxyService(IWindsorContainer container) 
            : base(container, container.Resolve<FrontendHttpProxyConfig>()) { }

		protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.CompositionObjectSpecialistsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2":
            itm._EditorName = "CompositionObjectSpecialistsEditor";
            break;
    }
}

            await Task.CompletedTask;
        }

        protected override string ControllerName => "CompositionObjectSpecialistsList";
    }
}