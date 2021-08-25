





   
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
    /// »нтерфейс запроса данных дл¤ представлени¤ 'Объекты'
    /// </summary>
	public interface IOrdersObjectsList2Service : IListViewService<Bars.Stkomleks.OrdersObjects, Bars.Stkomleks.OrdersObjectsList2Model, BaseParams>
	{
        
	}

	/// <summary>
    /// »нтерфейс фильтра дл¤ сервиса представлени¤ 'Объекты'
    /// </summary>
	public interface IOrdersObjectsList2ServiceFilter : IListViewServiceFilter<Bars.Stkomleks.OrdersObjects, Bars.Stkomleks.OrdersObjectsList2Model, BaseParams>
	{		
	}

    /// <summary>
    /// »нтерфейс обработчика дл¤ сервиса представлени¤ 'Объекты'
    /// </summary>
    public interface IOrdersObjectsList2ServiceHandler : IListViewServiceHandler<Bars.Stkomleks.OrdersObjects, Bars.Stkomleks.OrdersObjectsList2Model, BaseParams>
    {

    }

    /// <summary>
    /// Ѕазовый класс обработчика списка 'Объекты'
    /// </summary>
    public abstract class AbstractOrdersObjectsList2ServiceHandler : ListViewServiceHandler<Bars.Stkomleks.OrdersObjects, Bars.Stkomleks.OrdersObjectsList2Model>, IOrdersObjectsList2ServiceHandler
    {        
    }
}