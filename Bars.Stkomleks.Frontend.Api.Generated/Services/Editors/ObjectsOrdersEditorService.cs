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
    /// Реализация модели представления 'Объект заказа'
    /// </summary>
    public class ObjectsOrdersEditorService : EditorViewService<Bars.Stkomleks.ObjectsOrders, ObjectsOrdersEditorModel>,  IObjectsOrdersEditorService
    {                

        public ObjectsOrdersEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        /// <summary>
/// Модель редактора 'Объект.Создание' 
/// </summary>
public virtual Bars.Stkomleks.IOrdersObjectsEditorService OrdersObjectsEditorService { get; set; }


        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<ObjectsOrdersEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new ObjectsOrdersEditorModel();			
var varZakazId = @params.JsonData.GetAs<long?>("Zakaz_Id");
            if (varZakazId != null)
            {
                var serviceOrdersList = Container.Resolve<Bars.Stkomleks.IOrdersListService>();
                model.Zakaz = await serviceOrdersList.GetByIdAsync(varZakazId.Value);
            }
            model.Object = await OrdersObjectsEditorService.GetModelAsync((long?)null, cancellationToken);

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Заказы Объекты' в модель представления
        /// </summary>
        protected override async Task<ObjectsOrdersEditorModel> MapEntityInternalAsync(Bars.Stkomleks.ObjectsOrders entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new ObjectsOrdersEditorModel();
model.Id = entity.Id;
            var varZakazId1 = entity.GetZakazId();
            if (varZakazId1 != null)
            {
                var serviceOrdersList = Container.Resolve<Bars.Stkomleks.IOrdersListService>();
                model.Zakaz = await serviceOrdersList.GetByIdAsync(varZakazId1.Value);
                Container.Release(serviceOrdersList);
                serviceOrdersList = null;
            }
            model.Object_Id = entity.Object?.Id;
            model.Object = await OrdersObjectsEditorService.GetModelAsync(model.Object_Id, cancellationToken);
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Заказы Объекты' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.ObjectsOrders entity, ObjectsOrdersEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.Zakaz?.Id == null)
            {
                entity.Zakaz = null;
            }
            else if (entity.GetZakazId() != model.Zakaz?.Id)
            {
                entity.Zakaz = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.Zakaz>(model.Zakaz?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.Zakaz>(model.Zakaz?.Id, cancellationToken);
            }
            var mObject = model.Object;
            entity.Object = await OrdersObjectsEditorService.UnmapEntityAsync(mObject, requestFiles, filesToDelete, baseParams, true, cancellationToken);
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.ObjectsOrders entity, ObjectsOrdersEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}