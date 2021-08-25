





   
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
    /// »нтерфейс запроса данных дл¤ представлени¤ 'Спецификация.Объект'
    /// </summary>
	public interface IObjectProductsListService : IListViewService<Bars.Stkomleks.ObjectProducts, Bars.Stkomleks.ObjectProductsListModel, BaseParams>
	{
        
	}

	/// <summary>
    /// »нтерфейс фильтра дл¤ сервиса представлени¤ 'Спецификация.Объект'
    /// </summary>
	public interface IObjectProductsListServiceFilter : IListViewServiceFilter<Bars.Stkomleks.ObjectProducts, Bars.Stkomleks.ObjectProductsListModel, BaseParams>
	{		
	}

    /// <summary>
    /// »нтерфейс обработчика дл¤ сервиса представлени¤ 'Спецификация.Объект'
    /// </summary>
    public interface IObjectProductsListServiceHandler : IListViewServiceHandler<Bars.Stkomleks.ObjectProducts, Bars.Stkomleks.ObjectProductsListModel, BaseParams>
    {

    }

    /// <summary>
    /// Ѕазовый класс обработчика списка 'Спецификация.Объект'
    /// </summary>
    public abstract class AbstractObjectProductsListServiceHandler : ListViewServiceHandler<Bars.Stkomleks.ObjectProducts, Bars.Stkomleks.ObjectProductsListModel>, IObjectProductsListServiceHandler
    {        
    }
}