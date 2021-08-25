





   
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
    /// »нтерфейс запроса данных дл¤ представлени¤ 'Виды подразделений'
    /// </summary>
	public interface IDepartmentsTypeListService : IListViewService<Bars.Stkomleks.DepartmentsType, Bars.Stkomleks.DepartmentsTypeListModel, BaseParams>
	{
        
	}

	/// <summary>
    /// »нтерфейс фильтра дл¤ сервиса представлени¤ 'Виды подразделений'
    /// </summary>
	public interface IDepartmentsTypeListServiceFilter : IListViewServiceFilter<Bars.Stkomleks.DepartmentsType, Bars.Stkomleks.DepartmentsTypeListModel, BaseParams>
	{		
	}

    /// <summary>
    /// »нтерфейс обработчика дл¤ сервиса представлени¤ 'Виды подразделений'
    /// </summary>
    public interface IDepartmentsTypeListServiceHandler : IListViewServiceHandler<Bars.Stkomleks.DepartmentsType, Bars.Stkomleks.DepartmentsTypeListModel, BaseParams>
    {

    }

    /// <summary>
    /// Ѕазовый класс обработчика списка 'Виды подразделений'
    /// </summary>
    public abstract class AbstractDepartmentsTypeListServiceHandler : ListViewServiceHandler<Bars.Stkomleks.DepartmentsType, Bars.Stkomleks.DepartmentsTypeListModel>, IDepartmentsTypeListServiceHandler
    {        
    }
}