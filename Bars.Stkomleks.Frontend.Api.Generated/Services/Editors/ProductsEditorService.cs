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
    /// Реализация модели представления 'Комплектация'
    /// </summary>
    public class ProductsEditorService : EditorViewService<Bars.Stkomleks.Products, ProductsEditorModel>,  IProductsEditorService
    {                

        public ProductsEditorService(IWindsorContainer container)
            :base(container)
        {
        }

        

        /// <summary>
        /// Создание новой модели и её заполнение
        /// </summary>
        protected override async Task<ProductsEditorModel> CreateModelInternalAsync(BaseParams @params, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            var model = new ProductsEditorModel();			
var varObjectSpecificationId = @params.JsonData.GetAs<long?>("ObjectSpecification_Id");
            if (varObjectSpecificationId != null)
            {
                var serviceObjectProductsList = Container.Resolve<Bars.Stkomleks.IObjectProductsListService>();
                model.ObjectSpecification = await serviceObjectProductsList.GetByIdAsync(varObjectSpecificationId.Value);
            }
            var varSupplierId = @params.JsonData.GetAs<long?>("Supplier_Id");
            if (varSupplierId != null)
            {
                var serviceOrganizationProfilesList2 = Container.Resolve<Bars.Stkomleks.IOrganizationProfilesList2Service>();
                model.Supplier = await serviceOrganizationProfilesList2.GetByIdAsync(varSupplierId.Value);
            }

			            
            return model;
        }

        /// <summary>
        /// Преобразование сущности 'Комплектация элементов объектов' в модель представления
        /// </summary>
        protected override async Task<ProductsEditorModel> MapEntityInternalAsync(Bars.Stkomleks.Products entity, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            // создаем экзепляр модели
            var model = new ProductsEditorModel();
model.Id = entity.Id;
            var varObjectSpecificationId1 = entity.GetObjectSpecificationId();
            if (varObjectSpecificationId1 != null)
            {
                var serviceObjectProductsList = Container.Resolve<Bars.Stkomleks.IObjectProductsListService>();
                model.ObjectSpecification = await serviceObjectProductsList.GetByIdAsync(varObjectSpecificationId1.Value);
                Container.Release(serviceObjectProductsList);
                serviceObjectProductsList = null;
            }
            var varSupplierId1 = entity.GetSupplierId();
            if (varSupplierId1 != null)
            {
                var serviceOrganizationProfilesList2 = Container.Resolve<Bars.Stkomleks.IOrganizationProfilesList2Service>();
                model.Supplier = await serviceOrganizationProfilesList2.GetByIdAsync(varSupplierId1.Value);
                Container.Release(serviceOrganizationProfilesList2);
                serviceOrganizationProfilesList2 = null;
            }
            model.Product = ((System.String)(entity.Product));
            model.Code = ((System.String)(entity.Code));
            model.Quantity = ((System.Double?)(entity.Quantity));
            model.Comment = ((System.String)(entity.Comment));
            			
            
            return model;
        }

        /// <summary>
        /// Восстановление сущности 'Комплектация элементов объектов' из модели представления		
        /// </summary>
        protected override async Task UnmapEntityInternalAsync(Bars.Stkomleks.Products entity, ProductsEditorModel model, IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete, CancellationToken cancellationToken, BaseParams baseParams, bool isNested = false)
        {            
            await Task.CompletedTask;
            if (model.ObjectSpecification?.Id == null)
            {
                entity.ObjectSpecification = null;
            }
            else if (entity.GetObjectSpecificationId() != model.ObjectSpecification?.Id)
            {
                entity.ObjectSpecification = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.ObjectProducts>(model.ObjectSpecification?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.ObjectProducts>(model.ObjectSpecification?.Id, cancellationToken);
            }
            if (model.Supplier?.Id == null)
            {
                entity.Supplier = null;
            }
            else if (entity.GetSupplierId() != model.Supplier?.Id)
            {
                entity.Supplier = isNested 
                    ? await TryGetEntityByIdAsync<Bars.Stkomleks.OrganizationProfiles>(model.Supplier?.Id, cancellationToken)
                    : await TryReadEntityByIdAsync<Bars.Stkomleks.OrganizationProfiles>(model.Supplier?.Id, cancellationToken);
            }
            entity.Product = model.Product;
            entity.Code = model.Code;
            entity.Quantity = model.Quantity;
            entity.Comment = model.Comment;
           
        }
        
        protected override async Task SaveInnerEditorsInternalAsync(Bars.Stkomleks.Products entity, ProductsEditorModel model,
            IDictionary<string, FileData> requestFiles, IList<BarsUp.Modules.FileStorage.FileInfo> filesToDelete,
            bool isNested, BaseParams baseParams, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
        }


    }
}