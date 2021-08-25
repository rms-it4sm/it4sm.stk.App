





   
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
    /// »нтерфейс запроса данных дл¤ представлени¤ 'Комплектация.Элемент спецификации'
    /// </summary>
	public interface IProductsListService : IListViewService<Bars.Stkomleks.Products, Bars.Stkomleks.ProductsListModel, BaseParams>
	{
        
	}

	/// <summary>
    /// »нтерфейс фильтра дл¤ сервиса представлени¤ 'Комплектация.Элемент спецификации'
    /// </summary>
	public interface IProductsListServiceFilter : IListViewServiceFilter<Bars.Stkomleks.Products, Bars.Stkomleks.ProductsListModel, BaseParams>
	{		
	}

    /// <summary>
    /// »нтерфейс обработчика дл¤ сервиса представлени¤ 'Комплектация.Элемент спецификации'
    /// </summary>
    public interface IProductsListServiceHandler : IListViewServiceHandler<Bars.Stkomleks.Products, Bars.Stkomleks.ProductsListModel, BaseParams>
    {

    }

    /// <summary>
    /// Ѕазовый класс обработчика списка 'Комплектация.Элемент спецификации'
    /// </summary>
    public abstract class AbstractProductsListServiceHandler : ListViewServiceHandler<Bars.Stkomleks.Products, Bars.Stkomleks.ProductsListModel>, IProductsListServiceHandler
    {        
    }
}