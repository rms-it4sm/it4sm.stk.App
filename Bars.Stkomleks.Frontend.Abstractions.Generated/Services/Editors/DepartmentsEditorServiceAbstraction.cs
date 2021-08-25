



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
	/// Контракт сервиса редактора 'Подразделение'
	/// </summary>
	public interface IDepartmentsEditorService : IEditorViewService<Bars.Stkomleks.Departments,DepartmentsEditorModel>
	{
	
	}
    
    /// <summary>
	/// Интерфейс обработчика редактора 'Подразделение'
	/// </summary>
    public interface IDepartmentsEditorServiceHandler : IEditorViewServiceHandler<Bars.Stkomleks.Departments,DepartmentsEditorModel>
    {
    }

    /// <summary>
	/// Базовый класс обработчика редактора 'Подразделение'
	/// </summary>
    public abstract class AbstractDepartmentsEditorServiceHandler : EditorViewServiceHandler<Bars.Stkomleks.Departments,DepartmentsEditorModel>, IDepartmentsEditorServiceHandler
    {        
    }
    
    /// <summary>
	/// Базовый класс обработчика редактора 'Подразделение', который может сравнивать состояния моделей
	/// </summary>
    public abstract class AbstractDepartmentsEditorServiceModelComparerHandler : EditorViewServiceModelComparerHandler<Bars.Stkomleks.Departments,DepartmentsEditorModel>, IDepartmentsEditorServiceHandler
    {        
    }
}
