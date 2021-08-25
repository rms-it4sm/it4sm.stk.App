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
    /// Реализация модели представления 'Занимаемая должность подразделения'
    /// </summary>
    public class CurrentPositionsDepartmentsEditorService : EditorViewService<Bars.Stkomleks.CurrentPositionsDepartments, CurrentPositionsDepartmentsEditorModel>,  ICurrentPositionsDepartmentsEditorService
    {                

        public CurrentPositionsDepartmentsEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<CurrentPositionsDepartmentsEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new CurrentPositionsDepartmentsEditorModel();			
var varDepartmentPositionId = @params.JsonData.GetAs<long?>("DepartmentPosition_Id");
            if (varDepartmentPositionId != null)
            {
                var serviceDepartmentsPositionsList = Container.Resolve<Bars.Stkomleks.IDepartmentsPositionsListService>();
                model.DepartmentPosition = await serviceDepartmentsPositionsList.GetByIdAsync(varDepartmentPositionId.Value);
            }
            var varStaffId = @params.JsonData.GetAs<long?>("Staff_Id");
            if (varStaffId != null)
            {
                var serviceStaffList = Container.Resolve<Bars.Stkomleks.IStaffListService>();
                model.Staff = await serviceStaffList.GetByIdAsync(varStaffId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Занимаемые должности подразделений' в модель представления
        /// </summary>
        protected override async Task<CurrentPositionsDepartmentsEditorModel> MapEntityInternalAsync(Bars.Stkomleks.CurrentPositionsDepartments entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new CurrentPositionsDepartmentsEditorModel();
model.Id = entity.Id;
            var varDepartmentPositionId1 = entity.GetDepartmentPositionId();
            if (varDepartmentPositionId1 != null)
            {
                var serviceDepartmentsPositionsList = Container.Resolve<Bars.Stkomleks.IDepartmentsPositionsListService>();
                model.DepartmentPosition = await serviceDepartmentsPositionsList.GetByIdAsync(varDepartmentPositionId1.Value);
                Container.Release(serviceDepartmentsPositionsList);
                serviceDepartmentsPositionsList = null;
            }
            var varStaffId1 = entity.GetStaffId();
            if (varStaffId1 != null)
            {
                var serviceStaffList = Container.Resolve<Bars.Stkomleks.IStaffListService>();
                model.Staff = await serviceStaffList.GetByIdAsync(varStaffId1.Value);
                Container.Release(serviceStaffList);
                serviceStaffList = null;
            }
            model.Start = ((System.DateTime?)(entity.Start));
            model.Finish = ((System.DateTime?)(entity.Finish));
            model.Comment = ((System.String)(entity.Comment));
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Занимаемые должности подразделений' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.CurrentPositionsDepartments entity, CurrentPositionsDepartmentsEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.DepartmentPosition?.Id == null)
            {
                entity.DepartmentPosition = null;
            }
            else if (entity.GetDepartmentPositionId() != model.DepartmentPosition?.Id)
            {
                entity.DepartmentPosition = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.DepartmentsPositions>(model.DepartmentPosition?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.DepartmentsPositions>(model.DepartmentPosition?.Id, cancellationToken);
            }
            if (model.Staff?.Id == null)
            {
                entity.Staff = null;
            }
            else if (entity.GetStaffId() != model.Staff?.Id)
            {
                entity.Staff = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.Staff>(model.Staff?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.Staff>(model.Staff?.Id, cancellationToken);
            }
            entity.Start = model.Start;
            entity.Finish = model.Finish;
            entity.Comment = model.Comment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.CurrentPositionsDepartments entity, CurrentPositionsDepartmentsEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}