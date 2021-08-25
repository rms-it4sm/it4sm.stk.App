   
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
    /// Сервис для представления 'Объекты.Заказ'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Объекты.Заказ")]
	    public class OrdersObjectsListService : ListViewService<Bars.Stkomleks.OrdersObjects, Bars.Stkomleks.OrdersObjectsListModel>, IOrdersObjectsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public OrdersObjectsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.OrdersObjects> Filter(IQueryable<Bars.Stkomleks.OrdersObjects> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.OrdersObjectsListModel> Map(IQueryable<Bars.Stkomleks.OrdersObjects> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.OrdersObjectsListModel {
                 Id = x?.Id,
                    _TypeUid = "aa6ab35e-8dca-491d-8261-0bf3c834ab3b",
                    Type_Name = ((System.String)(x?.Type?.Name)),
                    Name = ((System.String)(x?.Name)),
                    Comment = ((System.String)(x?.Comment)),
                    Type_Id = ((System.Int64?)(x?.Type?.Id)),
                    _State = x?.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = x.State.Id, Name = x.State.Name, TypeId = x.State.TypeId },
                    _StateName = x?.State?.Name,
                    _StateId = x?.State?.Id,
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.OrdersObjectsListModel {
                Id = x.Id,
                    _TypeUid = "aa6ab35e-8dca-491d-8261-0bf3c834ab3b",
                    Type_Name = ((System.String)(x.Type.Name)),
                    Name = ((System.String)(x.Name)),
                    Comment = ((System.String)(x.Comment)),
                    Type_Id = ((System.Int64?)(x.Type.Id)),
                    _State = x.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = x.State.Id, Name = x.State.Name, TypeId = x.State.TypeId },
                    _StateName = x.State.Name,
                    _StateId = x.State.Id,
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrdersObjectsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "aa6ab35e-8dca-491d-8261-0bf3c834ab3b":
            itm._EditorName = "OrdersObjectsEditor_Copy_0";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}