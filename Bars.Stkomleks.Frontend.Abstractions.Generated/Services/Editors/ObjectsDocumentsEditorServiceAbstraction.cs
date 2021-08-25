



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
	/// Контракт сервиса редактора 'Документ объекта'
	/// </summary>
	public interface IObjectsDocumentsEditorService : IEditorViewService<Bars.Stkomleks.ObjectsDocuments,ObjectsDocumentsEditorModel>
	{
	
	}
    
    /// <summary>
	/// Интерфейс обработчика редактора 'Документ объекта'
	/// </summary>
    public interface IObjectsDocumentsEditorServiceHandler : IEditorViewServiceHandler<Bars.Stkomleks.ObjectsDocuments,ObjectsDocumentsEditorModel>
    {
    }

    /// <summary>
	/// Базовый класс обработчика редактора 'Документ объекта'
	/// </summary>
    public abstract class AbstractObjectsDocumentsEditorServiceHandler : EditorViewServiceHandler<Bars.Stkomleks.ObjectsDocuments,ObjectsDocumentsEditorModel>, IObjectsDocumentsEditorServiceHandler
    {        
    }
    
    /// <summary>
	/// Базовый класс обработчика редактора 'Документ объекта', который может сравнивать состояния моделей
	/// </summary>
    public abstract class AbstractObjectsDocumentsEditorServiceModelComparerHandler : EditorViewServiceModelComparerHandler<Bars.Stkomleks.ObjectsDocuments,ObjectsDocumentsEditorModel>, IObjectsDocumentsEditorServiceHandler
    {        
    }
}
