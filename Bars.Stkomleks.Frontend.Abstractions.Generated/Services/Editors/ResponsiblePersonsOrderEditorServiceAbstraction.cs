



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
	/// Контракт сервиса редактора 'Ответственное лицо заказа'
	/// </summary>
	public interface IResponsiblePersonsOrderEditorService : IEditorViewService<Bars.Stkomleks.ResponsiblePersonsOrder,ResponsiblePersonsOrderEditorModel>
	{
	
	}
    
    /// <summary>
	/// Интерфейс обработчика редактора 'Ответственное лицо заказа'
	/// </summary>
    public interface IResponsiblePersonsOrderEditorServiceHandler : IEditorViewServiceHandler<Bars.Stkomleks.ResponsiblePersonsOrder,ResponsiblePersonsOrderEditorModel>
    {
    }

    /// <summary>
	/// Базовый класс обработчика редактора 'Ответственное лицо заказа'
	/// </summary>
    public abstract class AbstractResponsiblePersonsOrderEditorServiceHandler : EditorViewServiceHandler<Bars.Stkomleks.ResponsiblePersonsOrder,ResponsiblePersonsOrderEditorModel>, IResponsiblePersonsOrderEditorServiceHandler
    {        
    }
    
    /// <summary>
	/// Базовый класс обработчика редактора 'Ответственное лицо заказа', который может сравнивать состояния моделей
	/// </summary>
    public abstract class AbstractResponsiblePersonsOrderEditorServiceModelComparerHandler : EditorViewServiceModelComparerHandler<Bars.Stkomleks.ResponsiblePersonsOrder,ResponsiblePersonsOrderEditorModel>, IResponsiblePersonsOrderEditorServiceHandler
    {        
    }
}
