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
    /// Реализация модели представления 'Должность подразделения'
    /// </summary>
    public class DepartmentsPositionsEditorService : EditorViewService<Bars.Stkomleks.DepartmentsPositions, DepartmentsPositionsEditorModel>,  IDepartmentsPositionsEditorService
    {                

        public DepartmentsPositionsEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<DepartmentsPositionsEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new DepartmentsPositionsEditorModel();			
var varDepartmentId = @params.JsonData.GetAs<long?>("Department_Id");
            if (varDepartmentId != null)
            {
                var serviceDepartmentsList = Container.Resolve<Bars.Stkomleks.IDepartmentsListService>();
                model.Department = await serviceDepartmentsList.GetByIdAsync(varDepartmentId.Value);
            }
            var varTypeId = @params.JsonData.GetAs<long?>("Type_Id");
            if (varTypeId != null)
            {
                var servicePositionsTypesList = Container.Resolve<Bars.Stkomleks.IPositionsTypesListService>();
                model.Type = await servicePositionsTypesList.GetByIdAsync(varTypeId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Должности подразделения' в модель представления
        /// </summary>
        protected override async Task<DepartmentsPositionsEditorModel> MapEntityInternalAsync(Bars.Stkomleks.DepartmentsPositions entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new DepartmentsPositionsEditorModel();
model.Id = entity.Id;
            var varDepartmentId1 = entity.GetDepartmentId();
            if (varDepartmentId1 != null)
            {
                var serviceDepartmentsList = Container.Resolve<Bars.Stkomleks.IDepartmentsListService>();
                model.Department = await serviceDepartmentsList.GetByIdAsync(varDepartmentId1.Value);
                Container.Release(serviceDepartmentsList);
                serviceDepartmentsList = null;
            }
            var varTypeId1 = entity.GetTypeId();
            if (varTypeId1 != null)
            {
                var servicePositionsTypesList = Container.Resolve<Bars.Stkomleks.IPositionsTypesListService>();
                model.Type = await servicePositionsTypesList.GetByIdAsync(varTypeId1.Value);
                Container.Release(servicePositionsTypesList);
                servicePositionsTypesList = null;
            }
            model.Position = ((System.String)(entity.Position));
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Должности подразделения' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.DepartmentsPositions entity, DepartmentsPositionsEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.Department?.Id == null)
            {
                entity.Department = null;
            }
            else if (entity.GetDepartmentId() != model.Department?.Id)
            {
                entity.Department = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.Departments>(model.Department?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.Departments>(model.Department?.Id, cancellationToken);
            }
            if (model.Type?.Id == null)
            {
                entity.Type = null;
            }
            else if (entity.GetTypeId() != model.Type?.Id)
            {
                entity.Type = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.PositionsTypes>(model.Type?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.PositionsTypes>(model.Type?.Id, cancellationToken);
            }
            entity.Position = model.Position;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.DepartmentsPositions entity, DepartmentsPositionsEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}