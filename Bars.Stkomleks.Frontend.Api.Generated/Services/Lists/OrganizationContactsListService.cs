   
namespace Bars.Stkomleks
{
using Bars.Stkomleks.Frontend.Abstractions.Generated;
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
    /// Сервис для представления 'Контакты.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Контакты.Организация")]
	    public class OrganizationContactsListService : ListViewService<Bars.Stkomleks.OrganizationContacts, Bars.Stkomleks.OrganizationContactsListModel>, IOrganizationContactsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public OrganizationContactsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.OrganizationContacts> Filter(IQueryable<Bars.Stkomleks.OrganizationContacts> entityQuery, BaseParams @params)
		{
            var query = base.Filter(entityQuery, @params);
            
            if (@params.IsNotNull())
            {                
				
                
                            }
            
            return query;
		}
  
        
        /// <summary>
        /// Формирование запроса на получение моделей
        /// </summary>
        public override IQueryable<Bars.Stkomleks.OrganizationContactsListModel> Map(IQueryable<Bars.Stkomleks.OrganizationContacts> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.OrganizationContactsListModel {
                 Id = x?.Id,
                    _TypeUid = "2ab43a3b-81eb-4f93-8d61-eb1304c71200",
                    Type_Name = ((System.String)(x?.Type?.Name)),
                    Contact = ((System.String)(x?.Contact)),
                    Comment = ((System.String)(x?.Comment)),
                    Organization_Id = ((System.Int64?)(x?.Organization?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.OrganizationContactsListModel {
                Id = x.Id,
                    _TypeUid = "2ab43a3b-81eb-4f93-8d61-eb1304c71200",
                    Type_Name = ((System.String)(x.Type.Name)),
                    Contact = ((System.String)(x.Contact)),
                    Comment = ((System.String)(x.Comment)),
                    Organization_Id = ((System.Int64?)(x.Organization.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrganizationContactsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "2ab43a3b-81eb-4f93-8d61-eb1304c71200":
            itm._EditorName = "OrganizationContactsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}