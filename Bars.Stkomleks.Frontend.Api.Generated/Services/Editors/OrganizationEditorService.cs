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
    /// Реализация модели представления 'Организация'
    /// </summary>
    public class OrganizationEditorService : EditorViewService<Bars.Stkomleks.Organization, OrganizationEditorModel>,  IOrganizationEditorService
    {                

        public OrganizationEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<OrganizationEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new OrganizationEditorModel();			

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Организации' в модель представления
        /// </summary>
        protected override async Task<OrganizationEditorModel> MapEntityInternalAsync(Bars.Stkomleks.Organization entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new OrganizationEditorModel();
model.Id = entity.Id;
            model.Name = ((System.String)(entity.Name));
            model.FullName = ((System.String)(entity.FullName));
            model.Comment = ((System.String)(entity.Comment));
            model._State = entity.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = entity.State.Id, Name = entity.State.Name, TypeId = entity.State.TypeId };
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Организации' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.Organization entity, OrganizationEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            entity.Name = model.Name;
            entity.FullName = model.FullName;
            entity.Comment = model.Comment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.Organization entity, OrganizationEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}