   
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
    /// Сервис для представления 'Заказы'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Заказы")]
	    public class OrdersListService : ListViewService<Bars.Stkomleks.Zakaz, Bars.Stkomleks.OrdersListModel>, IOrdersListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public OrdersListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.Zakaz> Filter(IQueryable<Bars.Stkomleks.Zakaz> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.OrdersListModel> Map(IQueryable<Bars.Stkomleks.Zakaz> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.OrdersListModel {
                 Id = x?.Id,
                    _TypeUid = "cac4cb82-577f-4682-bbd7-bf7d70fbfee1",
                    Number = ((System.String)(x?.Number)),
                    Date = ((System.DateTime?)(x?.Date)),
                    Client_Organization_Name = ((System.String)(x?.Client?.Organization?.Name)),
                    Manager_Individual_FIO = ((System.String)(x?.Manager?.Individual?.FIO)),
                    Comment = ((System.String)(x?.Comment)),
                    _State = x?.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = x.State.Id, Name = x.State.Name, TypeId = x.State.TypeId },
                    _StateName = x?.State?.Name,
                    _StateId = x?.State?.Id,
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.OrdersListModel {
                Id = x.Id,
                    _TypeUid = "cac4cb82-577f-4682-bbd7-bf7d70fbfee1",
                    Number = ((System.String)(x.Number)),
                    Date = ((System.DateTime?)(x.Date)),
                    Client_Organization_Name = ((System.String)(x.Client.Organization.Name)),
                    Manager_Individual_FIO = ((System.String)(x.Manager.Individual.FIO)),
                    Comment = ((System.String)(x.Comment)),
                    _State = x.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = x.State.Id, Name = x.State.Name, TypeId = x.State.TypeId },
                    _StateName = x.State.Name,
                    _StateId = x.State.Id,
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrdersListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "cac4cb82-577f-4682-bbd7-bf7d70fbfee1":
            itm._EditorName = "OrdersEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}