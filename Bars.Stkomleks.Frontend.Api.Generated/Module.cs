namespace Bars.Stkomleks.Frontend.Api.Generated
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Castle.Windsor;
    using Castle.MicroKernel.Registration;
    using Microsoft.Extensions.DependencyInjection;
    using BarsUp.DataAccess;
	using BarsUp.Extensions.Configuration;
	using BarsUp.Extensions.Reflection;
    using BarsUp.Core.Application;
    
    using Bars.Stkomleks;
    using BarsUp.Application;
    using BarsUp.Windsor;
    using BarsUp;
    using BarsUp.Events;
    using BarsUp.IoC;
    using BarsUp.Registrar;
    
    using Bars.Stkomleks.Frontend.Abstractions.Generated;

    using BarsUp.Designer.Core;

    using JetBrains.Annotations;

    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Utils;

    /// <summary>
    /// Класс подключения модуля
    /// </summary>
    [BarsUp.Utils.Display("Стройкомлекс [Frontend.Api] (Генерируемый проект)")]    
    [BarsUp.Utils.Attributes.Uid("df46f4a7-98b0-df64-ee0e-81f895ac55ef")]
    public class Module : AssemblyDefinedModule, IAspNetCoreServiceConfigurator
    {        
        /// <summary>
        /// Загрузка модуля
        /// </summary>
        public override void Install()
        {
            RegisterListViewFilters();
RegisterViewServices();
AssemblyReplacedTypeResolver.AddAssemblyReplace("Bars.Stkomleks", GetType().Assembly.GetName().Name);
            
        }        
        
        protected override void SetDependencies()
        {
            base.SetDependencies();
            DependsOn<Bars.Stkomleks.Frontend.Abstractions.Generated.Module>();
DependsOn<BarsUp.Designer.GeneratedApp.Module>();
            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
            
        }

        private void RegisterListViewFilters(){
    Container.RegisterListViewServiceFilter<ObjectsOrdersListMultiAddByZakazFilter>();
    Container.RegisterListViewServiceFilter<OrganizationFundingProgramsListMultiAddByOrganizationFilter>();
    Container.RegisterListViewServiceFilter<OrganizationProfilesListMultiAddByOrganizationFilter>();
    Container.RegisterListViewServiceFilter<RelatedOrganizationsListMultiAddByOrganizationFilter>();
    Container.RegisterListViewServiceFilter<TypesWorkTypesObjectsListMultiAddByObjectTypeFilter>();

}
private void RegisterViewServices(){
    Container.RegisterEditorViewService<CompositionObjectSpecialistsEditorService>();
    Container.RegisterEditorViewService<CompositionWorksObjectsEditorService>();
    Container.RegisterEditorViewService<CurrentPositionsDepartmentsEditorService>();
    Container.RegisterEditorViewService<DepartmentsEditorService>();
    Container.RegisterEditorViewService<DepartmentsPositionsEditorService>();
    Container.RegisterEditorViewService<FundingProgramsEditorService>();
    Container.RegisterEditorViewService<IndividualsEditorService>();
    Container.RegisterEditorViewService<ObjectProductsEditorService>();
    Container.RegisterEditorViewService<ObjectsDocumentsEditorService>();
    Container.RegisterEditorViewService<ObjectsOrdersEditorService>();
    Container.RegisterEditorViewService<ObjectsOrdersListMultiAddByZakazEditorService>();
    Container.RegisterEditorViewService<ObjectsTypesEditorService>();
    Container.RegisterEditorViewService<OrderOrganizationEditorService>();
    Container.RegisterEditorViewService<OrdersEditorService>();
    Container.RegisterEditorViewService<OrdersObjectsEditor_Copy_0Service>();
    Container.RegisterEditorViewService<OrdersObjectsEditorService>();
    Container.RegisterEditorViewService<OrganizationContactsEditorService>();
    Container.RegisterEditorViewService<OrganizationEditorService>();
    Container.RegisterEditorViewService<OrganizationFundingProgramsListMultiAddByOrganizationEditorService>();
    Container.RegisterEditorViewService<OrganizationProfilesListMultiAddByOrganizationEditorService>();
    Container.RegisterEditorViewService<ProductsEditorService>();
    Container.RegisterEditorViewService<RelatedOrganizationsListMultiAddByOrganizationEditorService>();
    Container.RegisterEditorViewService<ResponsiblePersonsOrderEditorService>();
    Container.RegisterEditorViewService<StaffEditorService>();
    Container.RegisterEditorViewService<TypesWorkTypesObjectsListMultiAddByObjectTypeEditorService>();
    Container.RegisterListViewService<CompositionObjectSpecialistsListService>();
    Container.RegisterListViewService<CompositionWorksObjectsListService>();
    Container.RegisterListViewService<ContactsTypeListService>();
    Container.RegisterListViewService<CurrentPositionsDepartmentsListService>();
    Container.RegisterListViewService<DepartmentsListService>();
    Container.RegisterListViewService<DepartmentsPositionsListService>();
    Container.RegisterListViewService<DepartmentsTypeListService>();
    Container.RegisterListViewService<DocumentsTypeListService>();
    Container.RegisterListViewService<FundingProgramsListService>();
    Container.RegisterListViewService<IndividualsListService>();
    Container.RegisterListViewService<ObjectProductsListService>();
    Container.RegisterListViewService<ObjectsDocumentsListService>();
    Container.RegisterListViewService<ObjectsOrdersList2Service>();
    Container.RegisterListViewService<ObjectsOrdersListService>();
    Container.RegisterListViewService<ObjectsTypesListService>();
    Container.RegisterListViewService<OrderOrganizationListService>();
    Container.RegisterListViewService<OrdersListService>();
    Container.RegisterListViewService<OrdersObjectsList2Service>();
    Container.RegisterListViewService<OrdersObjectsListService>();
    Container.RegisterListViewService<OrganizationContactsListService>();
    Container.RegisterListViewService<OrganizationFundingProgramsList2Service>();
    Container.RegisterListViewService<OrganizationFundingProgramsListService>();
    Container.RegisterListViewService<OrganizationListService>();
    Container.RegisterListViewService<OrganizationProfilesList2Service>();
    Container.RegisterListViewService<OrganizationProfilesListService>();
    Container.RegisterListViewService<PositionsTypesListService>();
    Container.RegisterListViewService<ProductsListService>();
    Container.RegisterListViewService<ProductsTypesListService>();
    Container.RegisterListViewService<ProfilesOrganizationsListService>();
    Container.RegisterListViewService<RelatedOrganizationsListService>();
    Container.RegisterListViewService<ResponsiblePersonsOrderListService>();
    Container.RegisterListViewService<StaffListService>();
    Container.RegisterListViewService<TypesWorkTypesObjectsListService>();
    Container.RegisterListViewService<UnitMeasureListService>();
    Container.RegisterListViewService<WorksRolesListService>();
    Container.RegisterListViewService<WorksTypesListService>();

}
    }
}
