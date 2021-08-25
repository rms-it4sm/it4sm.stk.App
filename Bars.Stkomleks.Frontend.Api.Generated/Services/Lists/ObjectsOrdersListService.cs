   
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
    /// Сервис для представления 'Объекты.Заказа'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Объекты.Заказа")]
	    public class ObjectsOrdersListService : ListViewService<Bars.Stkomleks.ObjectsOrders, Bars.Stkomleks.ObjectsOrdersListModel>, IObjectsOrdersListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public ObjectsOrdersListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.ObjectsOrders> Filter(IQueryable<Bars.Stkomleks.ObjectsOrders> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.ObjectsOrdersListModel> Map(IQueryable<Bars.Stkomleks.ObjectsOrders> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.ObjectsOrdersListModel {
                 Id = x?.Id,
                    _TypeUid = "33d98787-d41a-4282-8f79-3b4f1046a7a1",
                    Zakaz_Id = ((System.Int64?)(x?.Zakaz?.Id)),
                    Object_State_Name = ((System.String)(x?.Object?.State?.Name)),
                    Object_Type_Name = ((System.String)(x?.Object?.Type?.Name)),
                    Object_Name = ((System.String)(x?.Object?.Name)),
                    Object_Id = ((System.Int64?)(x?.Object?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.ObjectsOrdersListModel {
                Id = x.Id,
                    _TypeUid = "33d98787-d41a-4282-8f79-3b4f1046a7a1",
                    Zakaz_Id = ((System.Int64?)(x.Zakaz.Id)),
                    Object_State_Name = ((System.String)(x.Object.State.Name)),
                    Object_Type_Name = ((System.String)(x.Object.Type.Name)),
                    Object_Name = ((System.String)(x.Object.Name)),
                    Object_Id = ((System.Int64?)(x.Object.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.ObjectsOrdersListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "aa6ab35e-8dca-491d-8261-0bf3c834ab3b":
            itm._EditorName = "ObjectsOrdersEditor";
            break;
        case "33d98787-d41a-4282-8f79-3b4f1046a7a1":
            itm._EditorName = "ObjectsOrdersListMultiAddByZakazEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}