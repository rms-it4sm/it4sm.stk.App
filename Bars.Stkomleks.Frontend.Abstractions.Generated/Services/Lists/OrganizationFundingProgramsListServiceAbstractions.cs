





   
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
    /// »нтерфейс запроса данных дл¤ представлени¤ 'Программы.Организация'
    /// </summary>
	public interface IOrganizationFundingProgramsListService : IListViewService<Bars.Stkomleks.OrganizationFundingPrograms, Bars.Stkomleks.OrganizationFundingProgramsListModel, BaseParams>
	{
        
	}

	/// <summary>
    /// »нтерфейс фильтра дл¤ сервиса представлени¤ 'Программы.Организация'
    /// </summary>
	public interface IOrganizationFundingProgramsListServiceFilter : IListViewServiceFilter<Bars.Stkomleks.OrganizationFundingPrograms, Bars.Stkomleks.OrganizationFundingProgramsListModel, BaseParams>
	{		
	}

    /// <summary>
    /// »нтерфейс обработчика дл¤ сервиса представлени¤ 'Программы.Организация'
    /// </summary>
    public interface IOrganizationFundingProgramsListServiceHandler : IListViewServiceHandler<Bars.Stkomleks.OrganizationFundingPrograms, Bars.Stkomleks.OrganizationFundingProgramsListModel, BaseParams>
    {

    }

    /// <summary>
    /// Ѕазовый класс обработчика списка 'Программы.Организация'
    /// </summary>
    public abstract class AbstractOrganizationFundingProgramsListServiceHandler : ListViewServiceHandler<Bars.Stkomleks.OrganizationFundingPrograms, Bars.Stkomleks.OrganizationFundingProgramsListModel>, IOrganizationFundingProgramsListServiceHandler
    {        
    }
}