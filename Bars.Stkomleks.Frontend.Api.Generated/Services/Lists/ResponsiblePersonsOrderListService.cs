   
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
    /// Сервис для представления 'Ответственные лица. Организация заказа'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Ответственные лица. Организация заказа")]
	    public class ResponsiblePersonsOrderListService : ListViewService<Bars.Stkomleks.ResponsiblePersonsOrder, Bars.Stkomleks.ResponsiblePersonsOrderListModel>, IResponsiblePersonsOrderListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public ResponsiblePersonsOrderListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.ResponsiblePersonsOrder> Filter(IQueryable<Bars.Stkomleks.ResponsiblePersonsOrder> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.ResponsiblePersonsOrderListModel> Map(IQueryable<Bars.Stkomleks.ResponsiblePersonsOrder> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.ResponsiblePersonsOrderListModel {
                 Id = x?.Id,
                    _TypeUid = "ad3b2737-f4d5-4495-b388-44a6dfd03bd9",
                    Staff_Individual_FIO = ((System.String)(x?.Staff?.Individual?.FIO)),
                    Appointment = ((System.String)(x?.Appointment)),
                    OrderOrganization_Id = ((System.Int64?)(x?.OrderOrganization?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.ResponsiblePersonsOrderListModel {
                Id = x.Id,
                    _TypeUid = "ad3b2737-f4d5-4495-b388-44a6dfd03bd9",
                    Staff_Individual_FIO = ((System.String)(x.Staff.Individual.FIO)),
                    Appointment = ((System.String)(x.Appointment)),
                    OrderOrganization_Id = ((System.Int64?)(x.OrderOrganization.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.ResponsiblePersonsOrderListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "ad3b2737-f4d5-4495-b388-44a6dfd03bd9":
            itm._EditorName = "ResponsiblePersonsOrderEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}