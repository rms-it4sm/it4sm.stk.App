   
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
    /// Сервис для представления 'Организации.Заказ'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Организации.Заказ")]
	    public class OrderOrganizationListService : ListViewService<Bars.Stkomleks.OrderOrganization, Bars.Stkomleks.OrderOrganizationListModel>, IOrderOrganizationListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public OrderOrganizationListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.OrderOrganization> Filter(IQueryable<Bars.Stkomleks.OrderOrganization> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.OrderOrganizationListModel> Map(IQueryable<Bars.Stkomleks.OrderOrganization> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.OrderOrganizationListModel {
                 Id = x?.Id,
                    _TypeUid = "e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e",
                    Organization_Organization_Name = ((System.String)(x?.Organization?.Organization?.Name)),
                    Profile_Name = ((System.String)(x?.Profile?.Name)),
                    Comment = ((System.String)(x?.Comment)),
                    Zakaz_Id = ((System.Int64?)(x?.Zakaz?.Id)),
                    Organization_Id = ((System.Int64?)(x?.Organization?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.OrderOrganizationListModel {
                Id = x.Id,
                    _TypeUid = "e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e",
                    Organization_Organization_Name = ((System.String)(x.Organization.Organization.Name)),
                    Profile_Name = ((System.String)(x.Profile.Name)),
                    Comment = ((System.String)(x.Comment)),
                    Zakaz_Id = ((System.Int64?)(x.Zakaz.Id)),
                    Organization_Id = ((System.Int64?)(x.Organization.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrderOrganizationListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e":
            itm._EditorName = "OrderOrganizationEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}