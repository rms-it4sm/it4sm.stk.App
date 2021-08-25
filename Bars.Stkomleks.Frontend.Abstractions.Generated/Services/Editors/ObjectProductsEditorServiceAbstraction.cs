



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
	/// Контракт сервиса редактора 'Элемент объекта'
	/// </summary>
	public interface IObjectProductsEditorService : IEditorViewService<Bars.Stkomleks.ObjectProducts,ObjectProductsEditorModel>
	{
	
	}
    
    /// <summary>
	/// Интерфейс обработчика редактора 'Элемент объекта'
	/// </summary>
    public interface IObjectProductsEditorServiceHandler : IEditorViewServiceHandler<Bars.Stkomleks.ObjectProducts,ObjectProductsEditorModel>
    {
    }

    /// <summary>
	/// Базовый класс обработчика редактора 'Элемент объекта'
	/// </summary>
    public abstract class AbstractObjectProductsEditorServiceHandler : EditorViewServiceHandler<Bars.Stkomleks.ObjectProducts,ObjectProductsEditorModel>, IObjectProductsEditorServiceHandler
    {        
    }
    
    /// <summary>
	/// Базовый класс обработчика редактора 'Элемент объекта', который может сравнивать состояния моделей
	/// </summary>
    public abstract class AbstractObjectProductsEditorServiceModelComparerHandler : EditorViewServiceModelComparerHandler<Bars.Stkomleks.ObjectProducts,ObjectProductsEditorModel>, IObjectProductsEditorServiceHandler
    {        
    }
}
