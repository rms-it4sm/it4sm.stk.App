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
    /// Реализация модели представления 'Объект.Создание'
    /// </summary>
    public class OrdersObjectsEditorService : EditorViewService<Bars.Stkomleks.OrdersObjects, OrdersObjectsEditorModel>,  IOrdersObjectsEditorService
    {                

        public OrdersObjectsEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<OrdersObjectsEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new OrdersObjectsEditorModel();			
var varZakazId = @params.JsonData.GetAs<long?>("Zakaz_Id");
            if (varZakazId != null)
            {
                var serviceOrdersList = Container.Resolve<Bars.Stkomleks.IOrdersListService>();
                model.Zakaz = await serviceOrdersList.GetByIdAsync(varZakazId.Value);
            }
            var varTypeId = @params.JsonData.GetAs<long?>("Type_Id");
            if (varTypeId != null)
            {
                var serviceObjectsTypesList = Container.Resolve<Bars.Stkomleks.IObjectsTypesListService>();
                model.Type = await serviceObjectsTypesList.GetByIdAsync(varTypeId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Объекты' в модель представления
        /// </summary>
        protected override async Task<OrdersObjectsEditorModel> MapEntityInternalAsync(Bars.Stkomleks.OrdersObjects entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new OrdersObjectsEditorModel();
model.Id = entity.Id;
            var varZakazId1 = entity.GetZakazId();
            if (varZakazId1 != null)
            {
                var serviceOrdersList = Container.Resolve<Bars.Stkomleks.IOrdersListService>();
                model.Zakaz = await serviceOrdersList.GetByIdAsync(varZakazId1.Value);
                Container.Release(serviceOrdersList);
                serviceOrdersList = null;
            }
            var varTypeId1 = entity.GetTypeId();
            if (varTypeId1 != null)
            {
                var serviceObjectsTypesList = Container.Resolve<Bars.Stkomleks.IObjectsTypesListService>();
                model.Type = await serviceObjectsTypesList.GetByIdAsync(varTypeId1.Value);
                Container.Release(serviceObjectsTypesList);
                serviceObjectsTypesList = null;
            }
            model.Name = ((System.String)(entity.Name));
            model.Comment = ((System.String)(entity.Comment));
            model.Lon = ((System.String)(entity.Lon));
            model.Lat = ((System.String)(entity.Lat));
            model._State = entity.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = entity.State.Id, Name = entity.State.Name, TypeId = entity.State.TypeId };
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Объекты' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.OrdersObjects entity, OrdersObjectsEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
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
            if (model.Type?.Id == null)
            {
                entity.Type = null;
            }
            else if (entity.GetTypeId() != model.Type?.Id)
            {
                entity.Type = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.ObjectsTypes>(model.Type?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.ObjectsTypes>(model.Type?.Id, cancellationToken);
            }
            entity.Name = model.Name;
            entity.Comment = model.Comment;
            entity.Lon = model.Lon;
            entity.Lat = model.Lat;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.OrdersObjects entity, OrdersObjectsEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}