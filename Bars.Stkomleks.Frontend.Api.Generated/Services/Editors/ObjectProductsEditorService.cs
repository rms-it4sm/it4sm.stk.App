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
    /// Реализация модели представления 'Элемент объекта'
    /// </summary>
    public class ObjectProductsEditorService : EditorViewService<Bars.Stkomleks.ObjectProducts, ObjectProductsEditorModel>,  IObjectProductsEditorService
    {                

        public ObjectProductsEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<ObjectProductsEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new ObjectProductsEditorModel();			
var varObjectOrderId = @params.JsonData.GetAs<long?>("ObjectOrder_Id");
            if (varObjectOrderId != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.ObjectOrder = await serviceOrdersObjectsList.GetByIdAsync(varObjectOrderId.Value);
            }
            var varTypeElementId = @params.JsonData.GetAs<long?>("TypeElement_Id");
            if (varTypeElementId != null)
            {
                var serviceProductsTypesList = Container.Resolve<Bars.Stkomleks.IProductsTypesListService>();
                model.TypeElement = await serviceProductsTypesList.GetByIdAsync(varTypeElementId.Value);
            }
            var varUnitMeasureId = @params.JsonData.GetAs<long?>("UnitMeasure_Id");
            if (varUnitMeasureId != null)
            {
                var serviceUnitMeasureList = Container.Resolve<Bars.Stkomleks.IUnitMeasureListService>();
                model.UnitMeasure = await serviceUnitMeasureList.GetByIdAsync(varUnitMeasureId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Спецификация объекта' в модель представления
        /// </summary>
        protected override async Task<ObjectProductsEditorModel> MapEntityInternalAsync(Bars.Stkomleks.ObjectProducts entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new ObjectProductsEditorModel();
model.Id = entity.Id;
            var varObjectOrderId1 = entity.GetObjectOrderId();
            if (varObjectOrderId1 != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.ObjectOrder = await serviceOrdersObjectsList.GetByIdAsync(varObjectOrderId1.Value);
                Container.Release(serviceOrdersObjectsList);
                serviceOrdersObjectsList = null;
            }
            model.Code = ((System.String)(entity.Code));
            var varTypeElementId1 = entity.GetTypeElementId();
            if (varTypeElementId1 != null)
            {
                var serviceProductsTypesList = Container.Resolve<Bars.Stkomleks.IProductsTypesListService>();
                model.TypeElement = await serviceProductsTypesList.GetByIdAsync(varTypeElementId1.Value);
                Container.Release(serviceProductsTypesList);
                serviceProductsTypesList = null;
            }
            model.Quantity = ((System.Double?)(entity.Quantity));
            var varUnitMeasureId1 = entity.GetUnitMeasureId();
            if (varUnitMeasureId1 != null)
            {
                var serviceUnitMeasureList = Container.Resolve<Bars.Stkomleks.IUnitMeasureListService>();
                model.UnitMeasure = await serviceUnitMeasureList.GetByIdAsync(varUnitMeasureId1.Value);
                Container.Release(serviceUnitMeasureList);
                serviceUnitMeasureList = null;
            }
            model.Comment = ((System.String)(entity.Comment));
            model.TypeElement_Name = entity.TypeElement?.Name;
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Спецификация объекта' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.ObjectProducts entity, ObjectProductsEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.ObjectOrder?.Id == null)
            {
                entity.ObjectOrder = null;
            }
            else if (entity.GetObjectOrderId() != model.ObjectOrder?.Id)
            {
                entity.ObjectOrder = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.OrdersObjects>(model.ObjectOrder?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.OrdersObjects>(model.ObjectOrder?.Id, cancellationToken);
            }
            entity.Code = model.Code;
            if (model.TypeElement?.Id == null)
            {
                entity.TypeElement = null;
            }
            else if (entity.GetTypeElementId() != model.TypeElement?.Id)
            {
                entity.TypeElement = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.ProductsTypes>(model.TypeElement?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.ProductsTypes>(model.TypeElement?.Id, cancellationToken);
            }
            entity.Quantity = model.Quantity;
            if (model.UnitMeasure?.Id == null)
            {
                entity.UnitMeasure = null;
            }
            else if (entity.GetUnitMeasureId() != model.UnitMeasure?.Id)
            {
                entity.UnitMeasure = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.UnitMeasure>(model.UnitMeasure?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.UnitMeasure>(model.UnitMeasure?.Id, cancellationToken);
            }
            entity.Comment = model.Comment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.ObjectProducts entity, ObjectProductsEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}