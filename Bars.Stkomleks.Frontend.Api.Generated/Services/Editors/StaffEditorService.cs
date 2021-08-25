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
    /// Реализация модели представления 'Сотрудник'
    /// </summary>
    public class StaffEditorService : EditorViewService<Bars.Stkomleks.Staff, StaffEditorModel>,  IStaffEditorService
    {                

        public StaffEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<StaffEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new StaffEditorModel();			
var varOrganizationId = @params.JsonData.GetAs<long?>("Organization_Id");
            if (varOrganizationId != null)
            {
                var serviceOrganizationList = Container.Resolve<Bars.Stkomleks.IOrganizationListService>();
                model.Organization = await serviceOrganizationList.GetByIdAsync(varOrganizationId.Value);
            }
            var varIndividualId = @params.JsonData.GetAs<long?>("Individual_Id");
            if (varIndividualId != null)
            {
                var serviceIndividualsList = Container.Resolve<Bars.Stkomleks.IIndividualsListService>();
                model.Individual = await serviceIndividualsList.GetByIdAsync(varIndividualId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Сотрудники' в модель представления
        /// </summary>
        protected override async Task<StaffEditorModel> MapEntityInternalAsync(Bars.Stkomleks.Staff entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new StaffEditorModel();
model.Id = entity.Id;
            var varOrganizationId1 = entity.GetOrganizationId();
            if (varOrganizationId1 != null)
            {
                var serviceOrganizationList = Container.Resolve<Bars.Stkomleks.IOrganizationListService>();
                model.Organization = await serviceOrganizationList.GetByIdAsync(varOrganizationId1.Value);
                Container.Release(serviceOrganizationList);
                serviceOrganizationList = null;
            }
            var varIndividualId1 = entity.GetIndividualId();
            if (varIndividualId1 != null)
            {
                var serviceIndividualsList = Container.Resolve<Bars.Stkomleks.IIndividualsListService>();
                model.Individual = await serviceIndividualsList.GetByIdAsync(varIndividualId1.Value);
                Container.Release(serviceIndividualsList);
                serviceIndividualsList = null;
            }
            model.Comment = ((System.String)(entity.Comment));
            model._State = entity.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = entity.State.Id, Name = entity.State.Name, TypeId = entity.State.TypeId };
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Сотрудники' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.Staff entity, StaffEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
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
            if (model.Individual?.Id == null)
            {
                entity.Individual = null;
            }
            else if (entity.GetIndividualId() != model.Individual?.Id)
            {
                entity.Individual = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.Individuals>(model.Individual?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.Individuals>(model.Individual?.Id, cancellationToken);
            }
            entity.Comment = model.Comment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.Staff entity, StaffEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}