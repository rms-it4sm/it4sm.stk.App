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
    public class OrganizationFundingProgramsListMultiAddByOrganizationEditorService : MultiEditorViewService<Bars.Stkomleks.OrganizationFundingPrograms, OrganizationFundingProgramsListMultiAddByOrganizationEditorModel>,  IOrganizationFundingProgramsListMultiAddByOrganizationEditorService
    {                

        public OrganizationFundingProgramsListMultiAddByOrganizationEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<OrganizationFundingProgramsListMultiAddByOrganizationEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new OrganizationFundingProgramsListMultiAddByOrganizationEditorModel();			
var varOrganizationId = @params.JsonData.GetAs<long?>("Organization_Id");
            if (varOrganizationId != null)
            {
                var serviceOrganizationList = Container.Resolve<Bars.Stkomleks.IOrganizationListService>();
                model.Organization = await serviceOrganizationList.GetByIdAsync(varOrganizationId.Value);
            }
            var varFundingProgramsId = @params.JsonData.GetAs<long?>("FundingPrograms_Id");
            if (varFundingProgramsId != null)
            {
                var serviceFundingProgramsList = Container.Resolve<Bars.Stkomleks.IFundingProgramsListService>();
                model.FundingPrograms = await serviceFundingProgramsList.GetByIdAsync(varFundingProgramsId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Программы финансирования организации' в модель представления
        /// </summary>
        protected override async Task<OrganizationFundingProgramsListMultiAddByOrganizationEditorModel> MapEntityInternalAsync(Bars.Stkomleks.OrganizationFundingPrograms entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new OrganizationFundingProgramsListMultiAddByOrganizationEditorModel();
model.Id = entity.Id;
            var varOrganizationId1 = entity.GetOrganizationId();
            if (varOrganizationId1 != null)
            {
                var serviceOrganizationList = Container.Resolve<Bars.Stkomleks.IOrganizationListService>();
                model.Organization = await serviceOrganizationList.GetByIdAsync(varOrganizationId1.Value);
                Container.Release(serviceOrganizationList);
                serviceOrganizationList = null;
            }
            var varFundingProgramsId1 = entity.GetFundingProgramsId();
            if (varFundingProgramsId1 != null)
            {
                var serviceFundingProgramsList = Container.Resolve<Bars.Stkomleks.IFundingProgramsListService>();
                model.FundingPrograms = await serviceFundingProgramsList.GetByIdAsync(varFundingProgramsId1.Value);
                Container.Release(serviceFundingProgramsList);
                serviceFundingProgramsList = null;
            }
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Программы финансирования организации' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.OrganizationFundingPrograms entity, OrganizationFundingProgramsListMultiAddByOrganizationEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
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
            if (model.FundingPrograms?.Id == null)
            {
                entity.FundingPrograms = null;
            }
            else if (entity.GetFundingProgramsId() != model.FundingPrograms?.Id)
            {
                entity.FundingPrograms = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.FundingPrograms>(model.FundingPrograms?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.FundingPrograms>(model.FundingPrograms?.Id, cancellationToken);
            }
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.OrganizationFundingPrograms entity, OrganizationFundingProgramsListMultiAddByOrganizationEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}