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
    public class TypesWorkTypesObjectsListMultiAddByObjectTypeEditorService : MultiEditorViewService<Bars.Stkomleks.TypesWorkTypesObjects, TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel>,  ITypesWorkTypesObjectsListMultiAddByObjectTypeEditorService
    {                

        public TypesWorkTypesObjectsListMultiAddByObjectTypeEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel();			
var varObjectTypeId = @params.JsonData.GetAs<long?>("ObjectType_Id");
            if (varObjectTypeId != null)
            {
                var serviceObjectsTypesList = Container.Resolve<Bars.Stkomleks.IObjectsTypesListService>();
                model.ObjectType = await serviceObjectsTypesList.GetByIdAsync(varObjectTypeId.Value);
            }
            var varWorkTypeId = @params.JsonData.GetAs<long?>("WorkType_Id");
            if (varWorkTypeId != null)
            {
                var serviceWorksTypesList = Container.Resolve<Bars.Stkomleks.IWorksTypesListService>();
                model.WorkType = await serviceWorksTypesList.GetByIdAsync(varWorkTypeId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Виды работ.Типы объектов' в модель представления
        /// </summary>
        protected override async Task<TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel> MapEntityInternalAsync(Bars.Stkomleks.TypesWorkTypesObjects entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel();
model.Id = entity.Id;
            var varObjectTypeId1 = entity.GetObjectTypeId();
            if (varObjectTypeId1 != null)
            {
                var serviceObjectsTypesList = Container.Resolve<Bars.Stkomleks.IObjectsTypesListService>();
                model.ObjectType = await serviceObjectsTypesList.GetByIdAsync(varObjectTypeId1.Value);
                Container.Release(serviceObjectsTypesList);
                serviceObjectsTypesList = null;
            }
            var varWorkTypeId1 = entity.GetWorkTypeId();
            if (varWorkTypeId1 != null)
            {
                var serviceWorksTypesList = Container.Resolve<Bars.Stkomleks.IWorksTypesListService>();
                model.WorkType = await serviceWorksTypesList.GetByIdAsync(varWorkTypeId1.Value);
                Container.Release(serviceWorksTypesList);
                serviceWorksTypesList = null;
            }
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Виды работ.Типы объектов' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.TypesWorkTypesObjects entity, TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.ObjectType?.Id == null)
            {
                entity.ObjectType = null;
            }
            else if (entity.GetObjectTypeId() != model.ObjectType?.Id)
            {
                entity.ObjectType = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.ObjectsTypes>(model.ObjectType?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.ObjectsTypes>(model.ObjectType?.Id, cancellationToken);
            }
            if (model.WorkType?.Id == null)
            {
                entity.WorkType = null;
            }
            else if (entity.GetWorkTypeId() != model.WorkType?.Id)
            {
                entity.WorkType = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.WorksTypes>(model.WorkType?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.WorksTypes>(model.WorkType?.Id, cancellationToken);
            }
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.TypesWorkTypesObjects entity, TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}