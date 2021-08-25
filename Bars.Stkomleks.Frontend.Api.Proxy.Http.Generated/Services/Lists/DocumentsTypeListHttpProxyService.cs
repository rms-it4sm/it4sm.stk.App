   
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
    /// Сервис для представления 'Типы документов'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Типы документов")]
	    public class DocumentsTypeListHttpProxyService : ListViewServiceHttpProxy<Bars.Stkomleks.DocumentsType, Bars.Stkomleks.DocumentsTypeListModel>, IDocumentsTypeListService
    {                                  
        public DocumentsTypeListHttpProxyService(IWindsorContainer container) 
            : base(container, container.Resolve<FrontendHttpProxyConfig>()) { }

		protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.DocumentsTypeListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            
            await Task.CompletedTask;
        }

        protected override string ControllerName => "DocumentsTypeList";
    }
}