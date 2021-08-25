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
    /// Реализация модели представления 'Работа объекта'
    /// </summary>
    public class CompositionWorksObjectsEditorService : EditorViewService<Bars.Stkomleks.CompositionWorksObjects, CompositionWorksObjectsEditorModel>,  ICompositionWorksObjectsEditorService
    {                

        public CompositionWorksObjectsEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<CompositionWorksObjectsEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new CompositionWorksObjectsEditorModel();			
var varObjectWorkId = @params.JsonData.GetAs<long?>("ObjectWork_Id");
            if (varObjectWorkId != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.ObjectWork = await serviceOrdersObjectsList.GetByIdAsync(varObjectWorkId.Value);
            }
            var varWorkTypeId = @params.JsonData.GetAs<long?>("WorkType_Id");
            if (varWorkTypeId != null)
            {
                var serviceTypesWorkTypesObjectsList = Container.Resolve<Bars.Stkomleks.ITypesWorkTypesObjectsListService>();
                model.WorkType = await serviceTypesWorkTypesObjectsList.GetByIdAsync(varWorkTypeId.Value);
            }
            var varObjectElementId = @params.JsonData.GetAs<long?>("ObjectElement_Id");
            if (varObjectElementId != null)
            {
                var serviceObjectProductsList = Container.Resolve<Bars.Stkomleks.IObjectProductsListService>();
                model.ObjectElement = await serviceObjectProductsList.GetByIdAsync(varObjectElementId.Value);
            }
            model.MethodWork = (Bars.Stkomleks.TypesWorkPerformers)1;
            var varContractorWorkId = @params.JsonData.GetAs<long?>("ContractorWork_Id");
            if (varContractorWorkId != null)
            {
                var serviceOrganizationProfilesList2 = Container.Resolve<Bars.Stkomleks.IOrganizationProfilesList2Service>();
                model.ContractorWork = await serviceOrganizationProfilesList2.GetByIdAsync(varContractorWorkId.Value);
            }
            var varBrigadeId = @params.JsonData.GetAs<long?>("Brigade_Id");
            if (varBrigadeId != null)
            {
                var serviceDepartmentsList = Container.Resolve<Bars.Stkomleks.IDepartmentsListService>();
                model.Brigade = await serviceDepartmentsList.GetByIdAsync(varBrigadeId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Работы объектов' в модель представления
        /// </summary>
        protected override async Task<CompositionWorksObjectsEditorModel> MapEntityInternalAsync(Bars.Stkomleks.CompositionWorksObjects entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new CompositionWorksObjectsEditorModel();
model.Id = entity.Id;
            var varObjectWorkId1 = entity.GetObjectWorkId();
            if (varObjectWorkId1 != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.ObjectWork = await serviceOrdersObjectsList.GetByIdAsync(varObjectWorkId1.Value);
                Container.Release(serviceOrdersObjectsList);
                serviceOrdersObjectsList = null;
            }
            var varWorkTypeId1 = entity.GetWorkTypeId();
            if (varWorkTypeId1 != null)
            {
                var serviceTypesWorkTypesObjectsList = Container.Resolve<Bars.Stkomleks.ITypesWorkTypesObjectsListService>();
                model.WorkType = await serviceTypesWorkTypesObjectsList.GetByIdAsync(varWorkTypeId1.Value);
                Container.Release(serviceTypesWorkTypesObjectsList);
                serviceTypesWorkTypesObjectsList = null;
            }
            var varObjectElementId1 = entity.GetObjectElementId();
            if (varObjectElementId1 != null)
            {
                var serviceObjectProductsList = Container.Resolve<Bars.Stkomleks.IObjectProductsListService>();
                model.ObjectElement = await serviceObjectProductsList.GetByIdAsync(varObjectElementId1.Value);
                Container.Release(serviceObjectProductsList);
                serviceObjectProductsList = null;
            }
            model.PlanStart = ((System.DateTime?)(entity.PlanStart));
            model.PlanFinish = ((System.DateTime?)(entity.PlanFinish));
            model.MethodWork = ((Bars.Stkomleks.TypesWorkPerformers?)(entity.MethodWork));
            var varContractorWorkId1 = entity.GetContractorWorkId();
            if (varContractorWorkId1 != null)
            {
                var serviceOrganizationProfilesList2 = Container.Resolve<Bars.Stkomleks.IOrganizationProfilesList2Service>();
                model.ContractorWork = await serviceOrganizationProfilesList2.GetByIdAsync(varContractorWorkId1.Value);
                Container.Release(serviceOrganizationProfilesList2);
                serviceOrganizationProfilesList2 = null;
            }
            var varBrigadeId1 = entity.GetBrigadeId();
            if (varBrigadeId1 != null)
            {
                var serviceDepartmentsList = Container.Resolve<Bars.Stkomleks.IDepartmentsListService>();
                model.Brigade = await serviceDepartmentsList.GetByIdAsync(varBrigadeId1.Value);
                Container.Release(serviceDepartmentsList);
                serviceDepartmentsList = null;
            }
            model.Comment = ((System.String)(entity.Comment));
            model.Executor = ((System.String)(entity.Executor));
            model._State = entity.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = entity.State.Id, Name = entity.State.Name, TypeId = entity.State.TypeId };
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Работы объектов' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.CompositionWorksObjects entity, CompositionWorksObjectsEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.ObjectWork?.Id == null)
            {
                entity.ObjectWork = null;
            }
            else if (entity.GetObjectWorkId() != model.ObjectWork?.Id)
            {
                entity.ObjectWork = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.OrdersObjects>(model.ObjectWork?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.OrdersObjects>(model.ObjectWork?.Id, cancellationToken);
            }
            if (model.WorkType?.Id == null)
            {
                entity.WorkType = null;
            }
            else if (entity.GetWorkTypeId() != model.WorkType?.Id)
            {
                entity.WorkType = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.TypesWorkTypesObjects>(model.WorkType?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.TypesWorkTypesObjects>(model.WorkType?.Id, cancellationToken);
            }
            if (model.ObjectElement?.Id == null)
            {
                entity.ObjectElement = null;
            }
            else if (entity.GetObjectElementId() != model.ObjectElement?.Id)
            {
                entity.ObjectElement = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.ObjectProducts>(model.ObjectElement?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.ObjectProducts>(model.ObjectElement?.Id, cancellationToken);
            }
            entity.PlanStart = model.PlanStart;
            entity.PlanFinish = model.PlanFinish;
            if (model.MethodWork.HasValue)
            {
                entity.MethodWork = model.MethodWork.Value;
            }
            else
            {
                entity.MethodWork = null;
            }
            if (model.ContractorWork?.Id == null)
            {
                entity.ContractorWork = null;
            }
            else if (entity.GetContractorWorkId() != model.ContractorWork?.Id)
            {
                entity.ContractorWork = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.OrganizationProfiles>(model.ContractorWork?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.OrganizationProfiles>(model.ContractorWork?.Id, cancellationToken);
            }
            if (model.Brigade?.Id == null)
            {
                entity.Brigade = null;
            }
            else if (entity.GetBrigadeId() != model.Brigade?.Id)
            {
                entity.Brigade = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.Departments>(model.Brigade?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.Departments>(model.Brigade?.Id, cancellationToken);
            }
            entity.Comment = model.Comment;
            entity.Executor = model.Executor;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.CompositionWorksObjects entity, CompositionWorksObjectsEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}