



namespace Bars.Stkomleks
{
    using System;
    using System.Linq;
    using BarsUp;
    using BarsUp.DataAccess;
    using System.Collections.Generic;
    
    using System.Diagnostics;
    using BarsUp.Windsor;
    using BarsUp.IoC;
    using BarsUp.Utils;
    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Designer.GeneratedApp.Editors;
    using BarsUp.Designer.GeneratedApp.Commons;
    using BarsUp.Core.Exceptions;
    using BarsUp.Designer.Core;
    using BarsUp.Designer.Core.TypeSystem;
    using BarsUp.Modules.Filter;
    using BarsUp.Designer.Filter;
    using BarsUp.Extensions.Json;
    using BarsUp.Modules.Fias;
    using BarsUp.Modules.FileStorage;
    using BarsUp.Utils.Annotations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using Castle.Windsor;
    using Castle.MicroKernel.Registration;
    using BarsUp.Modules.PostgreSql.DataAccess;
            
    using System.Threading;
    using System.Threading.Tasks;
    using NHibernate;
    using NHibernate.Linq;
    using BarsUp.Modules.EntityAttributes.Extensions;

    /// <summary>
	/// Контракт сервиса редактора ''
	/// </summary>
	public interface IOrganizationProfilesListMultiAddByOrganizationEditorService : IEditorViewService<Bars.Stkomleks.OrganizationProfiles,OrganizationProfilesListMultiAddByOrganizationEditorModel>
	{
	
	}
    
    /// <summary>
	/// Интерфейс обработчика редактора ''
	/// </summary>
    public interface IOrganizationProfilesListMultiAddByOrganizationEditorServiceHandler : IEditorViewServiceHandler<Bars.Stkomleks.OrganizationProfiles,OrganizationProfilesListMultiAddByOrganizationEditorModel>
    {
    }

    /// <summary>
	/// Базовый класс обработчика редактора ''
	/// </summary>
    public abstract class AbstractOrganizationProfilesListMultiAddByOrganizationEditorServiceHandler : EditorViewServiceHandler<Bars.Stkomleks.OrganizationProfiles,OrganizationProfilesListMultiAddByOrganizationEditorModel>, IOrganizationProfilesListMultiAddByOrganizationEditorServiceHandler
    {        
    }
    
    /// <summary>
	/// Базовый класс обработчика редактора '', который может сравнивать состояния моделей
	/// </summary>
    public abstract class AbstractOrganizationProfilesListMultiAddByOrganizationEditorServiceModelComparerHandler : EditorViewServiceModelComparerHandler<Bars.Stkomleks.OrganizationProfiles,OrganizationProfilesListMultiAddByOrganizationEditorModel>, IOrganizationProfilesListMultiAddByOrganizationEditorServiceHandler
    {        
    }
}
