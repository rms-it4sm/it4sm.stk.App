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
    /// Реализация модели представления 'Контакт организации'
    /// </summary>
    public class OrganizationContactsEditorService : EditorViewService<Bars.Stkomleks.OrganizationContacts, OrganizationContactsEditorModel>,  IOrganizationContactsEditorService
    {                

        public OrganizationContactsEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<OrganizationContactsEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new OrganizationContactsEditorModel();			
var varOrganizationId = @params.JsonData.GetAs<long?>("Organization_Id");
            if (varOrganizationId != null)
            {
                var serviceOrganizationList = Container.Resolve<Bars.Stkomleks.IOrganizationListService>();
                model.Organization = await serviceOrganizationList.GetByIdAsync(varOrganizationId.Value);
            }
            var varTypeId = @params.JsonData.GetAs<long?>("Type_Id");
            if (varTypeId != null)
            {
                var serviceContactsTypeList = Container.Resolve<Bars.Stkomleks.IContactsTypeListService>();
                model.Type = await serviceContactsTypeList.GetByIdAsync(varTypeId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Контакты организации' в модель представления
        /// </summary>
        protected override async Task<OrganizationContactsEditorModel> MapEntityInternalAsync(Bars.Stkomleks.OrganizationContacts entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new OrganizationContactsEditorModel();
model.Id = entity.Id;
            var varOrganizationId1 = entity.GetOrganizationId();
            if (varOrganizationId1 != null)
            {
                var serviceOrganizationList = Container.Resolve<Bars.Stkomleks.IOrganizationListService>();
                model.Organization = await serviceOrganizationList.GetByIdAsync(varOrganizationId1.Value);
                Container.Release(serviceOrganizationList);
                serviceOrganizationList = null;
            }
            var varTypeId1 = entity.GetTypeId();
            if (varTypeId1 != null)
            {
                var serviceContactsTypeList = Container.Resolve<Bars.Stkomleks.IContactsTypeListService>();
                model.Type = await serviceContactsTypeList.GetByIdAsync(varTypeId1.Value);
                Container.Release(serviceContactsTypeList);
                serviceContactsTypeList = null;
            }
            model.Contact = ((System.String)(entity.Contact));
            model.Comment = ((System.String)(entity.Comment));
            model.Type_Name = entity.Type?.Name;
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Контакты организации' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.OrganizationContacts entity, OrganizationContactsEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.Organization?.Id == null)
            {
                entity.Organization = null;
            }
            else if (entity.GetOrganizationId() != model.Organization?.Id)
            {
                entity.Organization = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.Organization>(model.Organization?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.Organization>(model.Organization?.Id, cancellationToken);
            }
            if (model.Type?.Id == null)
            {
                entity.Type = null;
            }
            else if (entity.GetTypeId() != model.Type?.Id)
            {
                entity.Type = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.ContactsType>(model.Type?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.ContactsType>(model.Type?.Id, cancellationToken);
            }
            entity.Contact = model.Contact;
            entity.Comment = model.Comment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.OrganizationContacts entity, OrganizationContactsEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}