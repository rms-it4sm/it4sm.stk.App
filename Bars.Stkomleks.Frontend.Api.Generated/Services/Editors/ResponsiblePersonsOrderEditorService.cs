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
    /// Реализация модели представления 'Ответственное лицо заказа'
    /// </summary>
    public class ResponsiblePersonsOrderEditorService : EditorViewService<Bars.Stkomleks.ResponsiblePersonsOrder, ResponsiblePersonsOrderEditorModel>,  IResponsiblePersonsOrderEditorService
    {                

        public ResponsiblePersonsOrderEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<ResponsiblePersonsOrderEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new ResponsiblePersonsOrderEditorModel();			
var varOrderOrganizationId = @params.JsonData.GetAs<long?>("OrderOrganization_Id");
            if (varOrderOrganizationId != null)
            {
                var serviceOrderOrganizationList = Container.Resolve<Bars.Stkomleks.IOrderOrganizationListService>();
                model.OrderOrganization = await serviceOrderOrganizationList.GetByIdAsync(varOrderOrganizationId.Value);
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
        /// Преобразование сущности 'Ответственные лица заказа' в модель представления
        /// </summary>
        protected override async Task<ResponsiblePersonsOrderEditorModel> MapEntityInternalAsync(Bars.Stkomleks.ResponsiblePersonsOrder entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new ResponsiblePersonsOrderEditorModel();
model.Id = entity.Id;
            var varOrderOrganizationId1 = entity.GetOrderOrganizationId();
            if (varOrderOrganizationId1 != null)
            {
                var serviceOrderOrganizationList = Container.Resolve<Bars.Stkomleks.IOrderOrganizationListService>();
                model.OrderOrganization = await serviceOrderOrganizationList.GetByIdAsync(varOrderOrganizationId1.Value);
                Container.Release(serviceOrderOrganizationList);
                serviceOrderOrganizationList = null;
            }
            var varStaffId1 = entity.GetStaffId();
            if (varStaffId1 != null)
            {
                var serviceStaffList = Container.Resolve<Bars.Stkomleks.IStaffListService>();
                model.Staff = await serviceStaffList.GetByIdAsync(varStaffId1.Value);
                Container.Release(serviceStaffList);
                serviceStaffList = null;
            }
            model.Appointment = ((System.String)(entity.Appointment));
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Ответственные лица заказа' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.ResponsiblePersonsOrder entity, ResponsiblePersonsOrderEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.OrderOrganization?.Id == null)
            {
                entity.OrderOrganization = null;
            }
            else if (entity.GetOrderOrganizationId() != model.OrderOrganization?.Id)
            {
                entity.OrderOrganization = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.OrderOrganization>(model.OrderOrganization?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.OrderOrganization>(model.OrderOrganization?.Id, cancellationToken);
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
            entity.Appointment = model.Appointment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.ResponsiblePersonsOrder entity, ResponsiblePersonsOrderEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}