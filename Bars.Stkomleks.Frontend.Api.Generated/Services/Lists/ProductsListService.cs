   
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
    /// Сервис для представления 'Комплектация.Элемент спецификации'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Комплектация.Элемент спецификации")]
	    public class ProductsListService : ListViewService<Bars.Stkomleks.Products, Bars.Stkomleks.ProductsListModel>, IProductsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public ProductsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.Products> Filter(IQueryable<Bars.Stkomleks.Products> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.ProductsListModel> Map(IQueryable<Bars.Stkomleks.Products> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.ProductsListModel {
                 Id = x?.Id,
                    _TypeUid = "59c0f660-c442-4e9a-8772-a97243000d48",
                    Code = ((System.String)(x?.Code)),
                    Product = ((System.String)(x?.Product)),
                    Quantity = ((System.Double?)(x?.Quantity)),
                    Supplier_Organization_Name = ((System.String)(x?.Supplier?.Organization?.Name)),
                    ObjectSpecification_Id = ((System.Int64?)(x?.ObjectSpecification?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.ProductsListModel {
                Id = x.Id,
                    _TypeUid = "59c0f660-c442-4e9a-8772-a97243000d48",
                    Code = ((System.String)(x.Code)),
                    Product = ((System.String)(x.Product)),
                    Quantity = ((System.Double?)(x.Quantity)),
                    Supplier_Organization_Name = ((System.String)(x.Supplier.Organization.Name)),
                    ObjectSpecification_Id = ((System.Int64?)(x.ObjectSpecification.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.ProductsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "59c0f660-c442-4e9a-8772-a97243000d48":
            itm._EditorName = "ProductsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}