





   
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
    /// »нтерфейс запроса данных дл¤ представлени¤ 'Роли в бригаде'
    /// </summary>
	public interface IWorksRolesListService : IListViewService<Bars.Stkomleks.WorksRoles, Bars.Stkomleks.WorksRolesListModel, BaseParams>
	{
        
	}

	/// <summary>
    /// »нтерфейс фильтра дл¤ сервиса представлени¤ 'Роли в бригаде'
    /// </summary>
	public interface IWorksRolesListServiceFilter : IListViewServiceFilter<Bars.Stkomleks.WorksRoles, Bars.Stkomleks.WorksRolesListModel, BaseParams>
	{		
	}

    /// <summary>
    /// »нтерфейс обработчика дл¤ сервиса представлени¤ 'Роли в бригаде'
    /// </summary>
    public interface IWorksRolesListServiceHandler : IListViewServiceHandler<Bars.Stkomleks.WorksRoles, Bars.Stkomleks.WorksRolesListModel, BaseParams>
    {

    }

    /// <summary>
    /// Ѕазовый класс обработчика списка 'Роли в бригаде'
    /// </summary>
    public abstract class AbstractWorksRolesListServiceHandler : ListViewServiceHandler<Bars.Stkomleks.WorksRoles, Bars.Stkomleks.WorksRolesListModel>, IWorksRolesListServiceHandler
    {        
    }
}