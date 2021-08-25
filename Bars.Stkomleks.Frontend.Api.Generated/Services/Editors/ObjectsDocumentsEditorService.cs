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
    /// Реализация модели представления 'Документ объекта'
    /// </summary>
    public class ObjectsDocumentsEditorService : EditorViewService<Bars.Stkomleks.ObjectsDocuments, ObjectsDocumentsEditorModel>,  IObjectsDocumentsEditorService
    {                

        public ObjectsDocumentsEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<ObjectsDocumentsEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new ObjectsDocumentsEditorModel();			
var varObjectWorkId = @params.JsonData.GetAs<long?>("ObjectWork_Id");
            if (varObjectWorkId != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.ObjectWork = await serviceOrdersObjectsList.GetByIdAsync(varObjectWorkId.Value);
            }
            // получение параметров файла из свойства Файл
            model.File = await TryGetEntityByIdAsync<BarsUp.Modules.FileStorage.FileInfo>(@params.JsonData.GetAs<long?>("File_Id"), cancellationToken);

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Документы объекта' в модель представления
        /// </summary>
        protected override async Task<ObjectsDocumentsEditorModel> MapEntityInternalAsync(Bars.Stkomleks.ObjectsDocuments entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new ObjectsDocumentsEditorModel();
model.Id = entity.Id;
            var varObjectWorkId1 = entity.GetObjectWorkId();
            if (varObjectWorkId1 != null)
            {
                var serviceOrdersObjectsList = Container.Resolve<Bars.Stkomleks.IOrdersObjectsListService>();
                model.ObjectWork = await serviceOrdersObjectsList.GetByIdAsync(varObjectWorkId1.Value);
                Container.Release(serviceOrdersObjectsList);
                serviceOrdersObjectsList = null;
            }
            model.File = entity.File;
            model.Comment = ((System.String)(entity.Comment));
            model.File_Name = entity.File?.Name;
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Документы объекта' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.ObjectsDocuments entity, ObjectsDocumentsEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
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
            entity.Comment = model.Comment;
            // считываем файл Файл
            entity.File = await RestoreFileAsync(model.File, entity.File, requestFiles.Get("File"), filesToDelete, cancellationToken);
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.ObjectsDocuments entity, ObjectsDocumentsEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}