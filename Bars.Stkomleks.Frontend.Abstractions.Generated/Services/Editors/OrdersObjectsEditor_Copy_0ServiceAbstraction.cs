



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
	/// Контракт сервиса редактора 'Объект.Изменение'
	/// </summary>
	public interface IOrdersObjectsEditor_Copy_0Service : IEditorViewService<Bars.Stkomleks.OrdersObjects,OrdersObjectsEditor_Copy_0Model>
	{
	
	}
    
    /// <summary>
	/// Интерфейс обработчика редактора 'Объект.Изменение'
	/// </summary>
    public interface IOrdersObjectsEditor_Copy_0ServiceHandler : IEditorViewServiceHandler<Bars.Stkomleks.OrdersObjects,OrdersObjectsEditor_Copy_0Model>
    {
    }

    /// <summary>
	/// Базовый класс обработчика редактора 'Объект.Изменение'
	/// </summary>
    public abstract class AbstractOrdersObjectsEditor_Copy_0ServiceHandler : EditorViewServiceHandler<Bars.Stkomleks.OrdersObjects,OrdersObjectsEditor_Copy_0Model>, IOrdersObjectsEditor_Copy_0ServiceHandler
    {        
    }
    
    /// <summary>
	/// Базовый класс обработчика редактора 'Объект.Изменение', который может сравнивать состояния моделей
	/// </summary>
    public abstract class AbstractOrdersObjectsEditor_Copy_0ServiceModelComparerHandler : EditorViewServiceModelComparerHandler<Bars.Stkomleks.OrdersObjects,OrdersObjectsEditor_Copy_0Model>, IOrdersObjectsEditor_Copy_0ServiceHandler
    {        
    }
}
