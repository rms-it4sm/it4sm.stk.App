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
    /// Реализация модели представления 'Заказ'
    /// </summary>
    public class OrdersEditorService : EditorViewService<Bars.Stkomleks.Zakaz, OrdersEditorModel>,  IOrdersEditorService
    {                

        public OrdersEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<OrdersEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new OrdersEditorModel();			
var varClientId = @params.JsonData.GetAs<long?>("Client_Id");
            if (varClientId != null)
            {
                var serviceOrganizationProfilesList = Container.Resolve<Bars.Stkomleks.IOrganizationProfilesListService>();
                model.Client = await serviceOrganizationProfilesList.GetByIdAsync(varClientId.Value);
            }
            var varManagerId = @params.JsonData.GetAs<long?>("Manager_Id");
            if (varManagerId != null)
            {
                var serviceStaffList = Container.Resolve<Bars.Stkomleks.IStaffListService>();
                model.Manager = await serviceStaffList.GetByIdAsync(varManagerId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Заказы' в модель представления
        /// </summary>
        protected override async Task<OrdersEditorModel> MapEntityInternalAsync(Bars.Stkomleks.Zakaz entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new OrdersEditorModel();
model.Id = entity.Id;
            model.Number = ((System.String)(entity.Number));
            model.Date = ((System.DateTime?)(entity.Date));
            var varClientId1 = entity.GetClientId();
            if (varClientId1 != null)
            {
                var serviceOrganizationProfilesList = Container.Resolve<Bars.Stkomleks.IOrganizationProfilesListService>();
                model.Client = await serviceOrganizationProfilesList.GetByIdAsync(varClientId1.Value);
                Container.Release(serviceOrganizationProfilesList);
                serviceOrganizationProfilesList = null;
            }
            var varManagerId1 = entity.GetManagerId();
            if (varManagerId1 != null)
            {
                var serviceStaffList = Container.Resolve<Bars.Stkomleks.IStaffListService>();
                model.Manager = await serviceStaffList.GetByIdAsync(varManagerId1.Value);
                Container.Release(serviceStaffList);
                serviceStaffList = null;
            }
            model.Comment = ((System.String)(entity.Comment));
            model._State = entity.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = entity.State.Id, Name = entity.State.Name, TypeId = entity.State.TypeId };
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Заказы' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.Zakaz entity, OrdersEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            entity.Number = model.Number;
            entity.Date = model.Date;
            if (model.Client?.Id == null)
            {
                entity.Client = null;
            }
            else if (entity.GetClientId() != model.Client?.Id)
            {
                entity.Client = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.OrganizationProfiles>(model.Client?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.OrganizationProfiles>(model.Client?.Id, cancellationToken);
            }
            if (model.Manager?.Id == null)
            {
                entity.Manager = null;
            }
            else if (entity.GetManagerId() != model.Manager?.Id)
            {
                entity.Manager = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.Staff>(model.Manager?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.Staff>(model.Manager?.Id, cancellationToken);
            }
            entity.Comment = model.Comment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.Zakaz entity, OrdersEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}