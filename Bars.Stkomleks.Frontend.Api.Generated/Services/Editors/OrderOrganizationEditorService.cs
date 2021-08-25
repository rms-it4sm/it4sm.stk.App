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
    /// Реализация модели представления 'Организация заказа'
    /// </summary>
    public class OrderOrganizationEditorService : EditorViewService<Bars.Stkomleks.OrderOrganization, OrderOrganizationEditorModel>,  IOrderOrganizationEditorService
    {                

        public OrderOrganizationEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<OrderOrganizationEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new OrderOrganizationEditorModel();			
var varZakazId = @params.JsonData.GetAs<long?>("Zakaz_Id");
            if (varZakazId != null)
            {
                var serviceOrdersList = Container.Resolve<Bars.Stkomleks.IOrdersListService>();
                model.Zakaz = await serviceOrdersList.GetByIdAsync(varZakazId.Value);
            }
            var varProfileId = @params.JsonData.GetAs<long?>("Profile_Id");
            if (varProfileId != null)
            {
                var serviceProfilesOrganizationsList = Container.Resolve<Bars.Stkomleks.IProfilesOrganizationsListService>();
                model.Profile = await serviceProfilesOrganizationsList.GetByIdAsync(varProfileId.Value);
            }
            var varOrganizationId = @params.JsonData.GetAs<long?>("Organization_Id");
            if (varOrganizationId != null)
            {
                var serviceOrganizationProfilesList2 = Container.Resolve<Bars.Stkomleks.IOrganizationProfilesList2Service>();
                model.Organization = await serviceOrganizationProfilesList2.GetByIdAsync(varOrganizationId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Организации заказа' в модель представления
        /// </summary>
        protected override async Task<OrderOrganizationEditorModel> MapEntityInternalAsync(Bars.Stkomleks.OrderOrganization entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new OrderOrganizationEditorModel();
model.Id = entity.Id;
            var varZakazId1 = entity.GetZakazId();
            if (varZakazId1 != null)
            {
                var serviceOrdersList = Container.Resolve<Bars.Stkomleks.IOrdersListService>();
                model.Zakaz = await serviceOrdersList.GetByIdAsync(varZakazId1.Value);
                Container.Release(serviceOrdersList);
                serviceOrdersList = null;
            }
            var varProfileId1 = entity.GetProfileId();
            if (varProfileId1 != null)
            {
                var serviceProfilesOrganizationsList = Container.Resolve<Bars.Stkomleks.IProfilesOrganizationsListService>();
                model.Profile = await serviceProfilesOrganizationsList.GetByIdAsync(varProfileId1.Value);
                Container.Release(serviceProfilesOrganizationsList);
                serviceProfilesOrganizationsList = null;
            }
            var varOrganizationId1 = entity.GetOrganizationId();
            if (varOrganizationId1 != null)
            {
                var serviceOrganizationProfilesList2 = Container.Resolve<Bars.Stkomleks.IOrganizationProfilesList2Service>();
                model.Organization = await serviceOrganizationProfilesList2.GetByIdAsync(varOrganizationId1.Value);
                Container.Release(serviceOrganizationProfilesList2);
                serviceOrganizationProfilesList2 = null;
            }
            model.Comment = ((System.String)(entity.Comment));
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Организации заказа' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.OrderOrganization entity, OrderOrganizationEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
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
            if (model.Profile?.Id == null)
            {
                entity.Profile = null;
            }
            else if (entity.GetProfileId() != model.Profile?.Id)
            {
                entity.Profile = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.ProfilesOrganizations>(model.Profile?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.ProfilesOrganizations>(model.Profile?.Id, cancellationToken);
            }
            if (model.Organization?.Id == null)
            {
                entity.Organization = null;
            }
            else if (entity.GetOrganizationId() != model.Organization?.Id)
            {
                entity.Organization = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.OrganizationProfiles>(model.Organization?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.OrganizationProfiles>(model.Organization?.Id, cancellationToken);
            }
            entity.Comment = model.Comment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.OrderOrganization entity, OrderOrganizationEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}