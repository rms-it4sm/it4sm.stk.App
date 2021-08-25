   
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
    /// Сервис для представления 'Спецификация.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Спецификация.Объект")]
	    public class ObjectProductsListService : ListViewService<Bars.Stkomleks.ObjectProducts, Bars.Stkomleks.ObjectProductsListModel>, IObjectProductsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public ObjectProductsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.ObjectProducts> Filter(IQueryable<Bars.Stkomleks.ObjectProducts> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.ObjectProductsListModel> Map(IQueryable<Bars.Stkomleks.ObjectProducts> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.ObjectProductsListModel {
                 Id = x?.Id,
                    _TypeUid = "c4895819-2171-42e1-bde2-d4fa83104bbd",
                    Code = ((System.String)(x?.Code)),
                    TypeElement_Name = ((System.String)(x?.TypeElement?.Name)),
                    Quantity = ((System.Double?)(x?.Quantity)),
                    UnitMeasure_CutName = ((System.String)(x?.UnitMeasure?.CutName)),
                    Comment = ((System.String)(x?.Comment)),
                    ObjectOrder_Id = ((System.Int64?)(x?.ObjectOrder?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.ObjectProductsListModel {
                Id = x.Id,
                    _TypeUid = "c4895819-2171-42e1-bde2-d4fa83104bbd",
                    Code = ((System.String)(x.Code)),
                    TypeElement_Name = ((System.String)(x.TypeElement.Name)),
                    Quantity = ((System.Double?)(x.Quantity)),
                    UnitMeasure_CutName = ((System.String)(x.UnitMeasure.CutName)),
                    Comment = ((System.String)(x.Comment)),
                    ObjectOrder_Id = ((System.Int64?)(x.ObjectOrder.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.ObjectProductsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "c4895819-2171-42e1-bde2-d4fa83104bbd":
            itm._EditorName = "ObjectProductsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}