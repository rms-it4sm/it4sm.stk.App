namespace Bars.Stkomleks
{
using Bars.Stkomleks.Frontend.Abstractions.Generated;
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
    using BarsUp.DataAccess.Extentions;
    
    /// <summary>
    /// Реализация модели представления 'Объект.Изменение'
    /// </summary>
    public class OrdersObjectsEditor_Copy_0Service : EditorViewService<Bars.Stkomleks.OrdersObjects, OrdersObjectsEditor_Copy_0Model>,  IOrdersObjectsEditor_Copy_0Service
    {                

        public OrdersObjectsEditor_Copy_0Service(IWindsorContainer container)
            :base(container)
        {
        }

        /// <summary>
/// Модель редактора 'Объект.Создание' (OrdersObjectsEditor) 
/// </summary>
public virtual Bars.Stkomleks.IOrdersObjectsEditorService OrdersObjectsEditorService { get; set; }


        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<OrdersObjectsEditor_Copy_0Model> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new OrdersObjectsEditor_Copy_0Model();			
model.OrdersObjectsEditor = await OrdersObjectsEditorService.CreateModelAsync(@params);

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Объекты' в модель представления
        /// </summary>
        protected override async Task<OrdersObjectsEditor_Copy_0Model> MapEntityInternalAsync(Bars.Stkomleks.OrdersObjects entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new OrdersObjectsEditor_Copy_0Model();
model.Id = entity.Id;
            model.OrdersObjectsEditor = entity == null ? await OrdersObjectsEditorService.CreateModelAsync(new BaseParams()) : await OrdersObjectsEditorService.MapEntityAsync(entity, baseParams, cancellationToken);
            model._State = entity.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = entity.State.Id, Name = entity.State.Name, TypeId = entity.State.TypeId };
            model.Name = entity.Name;
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Объекты' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.OrdersObjects entity, OrdersObjectsEditor_Copy_0Model model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.OrdersObjectsEditor != null)
            {
                await OrdersObjectsEditorService.UnmapEntityAsync(entity, model.OrdersObjectsEditor, requestFiles, filesToDelete, baseParams, true);
            }
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.OrdersObjects entity, OrdersObjectsEditor_Copy_0Model model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}