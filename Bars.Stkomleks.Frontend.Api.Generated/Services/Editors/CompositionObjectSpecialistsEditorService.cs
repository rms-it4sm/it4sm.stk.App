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
    /// Реализация модели представления 'Специалист объекта'
    /// </summary>
    public class CompositionObjectSpecialistsEditorService : EditorViewService<Bars.Stkomleks.CompositionObjectSpecialists, CompositionObjectSpecialistsEditorModel>,  ICompositionObjectSpecialistsEditorService
    {                

        public CompositionObjectSpecialistsEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<CompositionObjectSpecialistsEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new CompositionObjectSpecialistsEditorModel();			
var varObjectId = @params.JsonData.GetAs<long?>("Object_Id");
            if (varObjectId != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.Object = await serviceOrdersObjectsList.GetByIdAsync(varObjectId.Value);
            }
            var varRoleId = @params.JsonData.GetAs<long?>("Role_Id");
            if (varRoleId != null)
            {
                var serviceWorksRolesList = Container.Resolve<Bars.Stkomleks.IWorksRolesListService>();
                model.Role = await serviceWorksRolesList.GetByIdAsync(varRoleId.Value);
            }
            var varStaffId = @params.JsonData.GetAs<long?>("Staff_Id");
            if (varStaffId != null)
            {
                var serviceCurrentPositionsDepartmentsList = Container.Resolve<Bars.Stkomleks.ICurrentPositionsDepartmentsListService>();
                model.Staff = await serviceCurrentPositionsDepartmentsList.GetByIdAsync(varStaffId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Специалисты объектов' в модель представления
        /// </summary>
        protected override async Task<CompositionObjectSpecialistsEditorModel> MapEntityInternalAsync(Bars.Stkomleks.CompositionObjectSpecialists entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new CompositionObjectSpecialistsEditorModel();
model.Id = entity.Id;
            var varObjectId1 = entity.GetObjectId();
            if (varObjectId1 != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.Object = await serviceOrdersObjectsList.GetByIdAsync(varObjectId1.Value);
                Container.Release(serviceOrdersObjectsList);
                serviceOrdersObjectsList = null;
            }
            var varRoleId1 = entity.GetRoleId();
            if (varRoleId1 != null)
            {
                var serviceWorksRolesList = Container.Resolve<Bars.Stkomleks.IWorksRolesListService>();
                model.Role = await serviceWorksRolesList.GetByIdAsync(varRoleId1.Value);
                Container.Release(serviceWorksRolesList);
                serviceWorksRolesList = null;
            }
            var varStaffId1 = entity.GetStaffId();
            if (varStaffId1 != null)
            {
                var serviceCurrentPositionsDepartmentsList = Container.Resolve<Bars.Stkomleks.ICurrentPositionsDepartmentsListService>();
                model.Staff = await serviceCurrentPositionsDepartmentsList.GetByIdAsync(varStaffId1.Value);
                Container.Release(serviceCurrentPositionsDepartmentsList);
                serviceCurrentPositionsDepartmentsList = null;
            }
            model.Comment = ((System.String)(entity.Comment));
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Специалисты объектов' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.CompositionObjectSpecialists entity, CompositionObjectSpecialistsEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
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
            if (model.Role?.Id == null)
            {
                entity.Role = null;
            }
            else if (entity.GetRoleId() != model.Role?.Id)
            {
                entity.Role = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.WorksRoles>(model.Role?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.WorksRoles>(model.Role?.Id, cancellationToken);
            }
            if (model.Staff?.Id == null)
            {
                entity.Staff = null;
            }
            else if (entity.GetStaffId() != model.Staff?.Id)
            {
                entity.Staff = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.CurrentPositionsDepartments>(model.Staff?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.CurrentPositionsDepartments>(model.Staff?.Id, cancellationToken);
            }
            entity.Comment = model.Comment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.CompositionObjectSpecialists entity, CompositionObjectSpecialistsEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}