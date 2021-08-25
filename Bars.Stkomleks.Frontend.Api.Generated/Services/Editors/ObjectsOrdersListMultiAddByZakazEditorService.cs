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
    /// Реализация модели представления ''
    /// </summary>
    public class ObjectsOrdersListMultiAddByZakazEditorService : MultiEditorViewService<Bars.Stkomleks.ObjectsOrders, ObjectsOrdersListMultiAddByZakazEditorModel>,  IObjectsOrdersListMultiAddByZakazEditorService
    {                

        public ObjectsOrdersListMultiAddByZakazEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<ObjectsOrdersListMultiAddByZakazEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new ObjectsOrdersListMultiAddByZakazEditorModel();			
var varZakazId = @params.JsonData.GetAs<long?>("Zakaz_Id");
            if (varZakazId != null)
            {
                var serviceOrdersList = Container.Resolve<Bars.Stkomleks.IOrdersListService>();
                model.Zakaz = await serviceOrdersList.GetByIdAsync(varZakazId.Value);
            }
            var varObjectId = @params.JsonData.GetAs<long?>("Object_Id");
            if (varObjectId != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.Object = await serviceOrdersObjectsList.GetByIdAsync(varObjectId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Заказы Объекты' в модель представления
        /// </summary>
        protected override async Task<ObjectsOrdersListMultiAddByZakazEditorModel> MapEntityInternalAsync(Bars.Stkomleks.ObjectsOrders entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new ObjectsOrdersListMultiAddByZakazEditorModel();
model.Id = entity.Id;
            var varZakazId1 = entity.GetZakazId();
            if (varZakazId1 != null)
            {
                var serviceOrdersList = Container.Resolve<Bars.Stkomleks.IOrdersListService>();
                model.Zakaz = await serviceOrdersList.GetByIdAsync(varZakazId1.Value);
                Container.Release(serviceOrdersList);
                serviceOrdersList = null;
            }
            var varObjectId1 = entity.GetObjectId();
            if (varObjectId1 != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.Object = await serviceOrdersObjectsList.GetByIdAsync(varObjectId1.Value);
                Container.Release(serviceOrdersObjectsList);
                serviceOrdersObjectsList = null;
            }
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Заказы Объекты' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.ObjectsOrders entity, ObjectsOrdersListMultiAddByZakazEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
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
            if (model.Object?.Id == null)
            {
                entity.Object = null;
            }
            else if (entity.GetObjectId() != model.Object?.Id)
            {
                entity.Object = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.OrdersObjects>(model.Object?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.OrdersObjects>(model.Object?.Id, cancellationToken);
            }
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.ObjectsOrders entity, ObjectsOrdersListMultiAddByZakazEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}