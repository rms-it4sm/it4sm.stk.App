





   
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
    /// »нтерфейс запроса данных дл¤ представлени¤ 'Программы финансирования'
    /// </summary>
	public interface IFundingProgramsListService : IListViewService<Bars.Stkomleks.FundingPrograms, Bars.Stkomleks.FundingProgramsListModel, BaseParams>
	{
        
	}

	/// <summary>
    /// »нтерфейс фильтра дл¤ сервиса представлени¤ 'Программы финансирования'
    /// </summary>
	public interface IFundingProgramsListServiceFilter : IListViewServiceFilter<Bars.Stkomleks.FundingPrograms, Bars.Stkomleks.FundingProgramsListModel, BaseParams>
	{		
	}

    /// <summary>
    /// »нтерфейс обработчика дл¤ сервиса представлени¤ 'Программы финансирования'
    /// </summary>
    public interface IFundingProgramsListServiceHandler : IListViewServiceHandler<Bars.Stkomleks.FundingPrograms, Bars.Stkomleks.FundingProgramsListModel, BaseParams>
    {

    }

    /// <summary>
    /// Ѕазовый класс обработчика списка 'Программы финансирования'
    /// </summary>
    public abstract class AbstractFundingProgramsListServiceHandler : ListViewServiceHandler<Bars.Stkomleks.FundingPrograms, Bars.Stkomleks.FundingProgramsListModel>, IFundingProgramsListServiceHandler
    {        
    }
}