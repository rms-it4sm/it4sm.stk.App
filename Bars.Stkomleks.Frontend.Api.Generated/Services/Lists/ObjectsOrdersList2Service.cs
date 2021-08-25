   
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
    /// Сервис для представления 'Заказы.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Заказы.Объект")]
	    public class ObjectsOrdersList2Service : ListViewService<Bars.Stkomleks.ObjectsOrders, Bars.Stkomleks.ObjectsOrdersList2Model>, IObjectsOrdersList2Service 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public ObjectsOrdersList2Service(IWindsorContainer container) 
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
        public override IQueryable<Bars.Stkomleks.ObjectsOrdersList2Model> Map(IQueryable<Bars.Stkomleks.ObjectsOrders> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.ObjectsOrdersList2Model {
                 Id = x?.Id,
                    _TypeUid = "33d98787-d41a-4282-8f79-3b4f1046a7a1",
                    Zakaz_Client_Organization_Name = ((System.String)(x?.Zakaz?.Client?.Organization?.Name)),
                    Zakaz_Number = ((System.String)(x?.Zakaz?.Number)),
                    Zakaz_Date = ((System.DateTime?)(x?.Zakaz?.Date)),
                    Object_Id = ((System.Int64?)(x?.Object?.Id)),
                    Zakaz_Id = ((System.Int64?)(x?.Zakaz?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.ObjectsOrdersList2Model {
                Id = x.Id,
                    _TypeUid = "33d98787-d41a-4282-8f79-3b4f1046a7a1",
                    Zakaz_Client_Organization_Name = ((System.String)(x.Zakaz.Client.Organization.Name)),
                    Zakaz_Number = ((System.String)(x.Zakaz.Number)),
                    Zakaz_Date = ((System.DateTime?)(x.Zakaz.Date)),
                    Object_Id = ((System.Int64?)(x.Object.Id)),
                    Zakaz_Id = ((System.Int64?)(x.Zakaz.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.ObjectsOrdersList2Model> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

                        
            await Task.CompletedTask;
        }

            }
}