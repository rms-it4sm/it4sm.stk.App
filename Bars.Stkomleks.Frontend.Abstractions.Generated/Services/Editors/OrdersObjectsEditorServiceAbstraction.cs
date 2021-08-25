



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
	/// Контракт сервиса редактора 'Объект.Создание'
	/// </summary>
	public interface IOrdersObjectsEditorService : IEditorViewService<Bars.Stkomleks.OrdersObjects,OrdersObjectsEditorModel>
	{
	
	}
    
    /// <summary>
	/// Интерфейс обработчика редактора 'Объект.Создание'
	/// </summary>
    public interface IOrdersObjectsEditorServiceHandler : IEditorViewServiceHandler<Bars.Stkomleks.OrdersObjects,OrdersObjectsEditorModel>
    {
    }

    /// <summary>
	/// Базовый класс обработчика редактора 'Объект.Создание'
	/// </summary>
    public abstract class AbstractOrdersObjectsEditorServiceHandler : EditorViewServiceHandler<Bars.Stkomleks.OrdersObjects,OrdersObjectsEditorModel>, IOrdersObjectsEditorServiceHandler
    {        
    }
    
    /// <summary>
	/// Базовый класс обработчика редактора 'Объект.Создание', который может сравнивать состояния моделей
	/// </summary>
    public abstract class AbstractOrdersObjectsEditorServiceModelComparerHandler : EditorViewServiceModelComparerHandler<Bars.Stkomleks.OrdersObjects,OrdersObjectsEditorModel>, IOrdersObjectsEditorServiceHandler
    {        
    }
}
