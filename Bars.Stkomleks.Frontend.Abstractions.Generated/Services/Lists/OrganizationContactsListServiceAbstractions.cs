





   
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
    /// »нтерфейс запроса данных дл¤ представлени¤ 'Контакты.Организация'
    /// </summary>
	public interface IOrganizationContactsListService : IListViewService<Bars.Stkomleks.OrganizationContacts, Bars.Stkomleks.OrganizationContactsListModel, BaseParams>
	{
        
	}

	/// <summary>
    /// »нтерфейс фильтра дл¤ сервиса представлени¤ 'Контакты.Организация'
    /// </summary>
	public interface IOrganizationContactsListServiceFilter : IListViewServiceFilter<Bars.Stkomleks.OrganizationContacts, Bars.Stkomleks.OrganizationContactsListModel, BaseParams>
	{		
	}

    /// <summary>
    /// »нтерфейс обработчика дл¤ сервиса представлени¤ 'Контакты.Организация'
    /// </summary>
    public interface IOrganizationContactsListServiceHandler : IListViewServiceHandler<Bars.Stkomleks.OrganizationContacts, Bars.Stkomleks.OrganizationContactsListModel, BaseParams>
    {

    }

    /// <summary>
    /// Ѕазовый класс обработчика списка 'Контакты.Организация'
    /// </summary>
    public abstract class AbstractOrganizationContactsListServiceHandler : ListViewServiceHandler<Bars.Stkomleks.OrganizationContacts, Bars.Stkomleks.OrganizationContactsListModel>, IOrganizationContactsListServiceHandler
    {        
    }
}