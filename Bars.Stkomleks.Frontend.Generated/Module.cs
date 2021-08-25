namespace Bars.Stkomleks.Frontend.Generated
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
    
    using Bars.Stkomleks.Core.Generated;

    using Bars.Stkomleks.Frontend.Abstractions.Generated;

    using BarsUp.Designer.Core;

    using JetBrains.Annotations;

    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Utils;

    /// <summary>
    /// Класс подключения модуля
    /// </summary>
    [BarsUp.Utils.Display("Стройкомлекс [Frontend] (Генерируемый проект)")]    
    [BarsUp.Utils.Attributes.Uid("6c2c2619-e141-b277-2c87-6a2487fb86d1")]
    public class Module : AssemblyDefinedModule, IAspNetCoreServiceConfigurator
    {        
        /// <summary>
        /// Загрузка модуля
        /// </summary>
        public override void Install()
        {
            RegisterControllers();
RegisterFrontendServices();
RegisterNavigationComponents();
RegisterServices();
AssemblyReplacedTypeResolver.AddAssemblyReplace("Bars.Stkomleks", GetType().Assembly.GetName().Name);
            
        }        
        
        protected override void SetDependencies()
        {
            base.SetDependencies();
            DependsOn<Bars.Stkomleks.Core.Generated.Module>();
DependsOn<Bars.Stkomleks.Frontend.Abstractions.Generated.Module>();
DependsOn<BarsUp.Designer.GeneratedApp.Module>();
            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
            
        }

        private void RegisterControllers(){
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.FundingPrograms, Bars.Stkomleks.FundingProgramsEditorModel>("FundingProgramsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.FundingPrograms, Bars.Stkomleks.FundingProgramsListModel>("FundingProgramsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.Individuals, Bars.Stkomleks.IndividualsEditorModel>("IndividualsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.Individuals, Bars.Stkomleks.IndividualsListModel>("IndividualsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.OrderOrganization, Bars.Stkomleks.OrderOrganizationEditorModel>("OrderOrganizationEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.OrderOrganization, Bars.Stkomleks.OrderOrganizationListModel>("OrderOrganizationList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.ResponsiblePersonsOrder, Bars.Stkomleks.ResponsiblePersonsOrderEditorModel>("ResponsiblePersonsOrderEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.ResponsiblePersonsOrder, Bars.Stkomleks.ResponsiblePersonsOrderListModel>("ResponsiblePersonsOrderList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.Zakaz, Bars.Stkomleks.OrdersEditorModel>("OrdersEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.Zakaz, Bars.Stkomleks.OrdersListModel>("OrdersList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.CompositionObjectSpecialists, Bars.Stkomleks.CompositionObjectSpecialistsEditorModel>("CompositionObjectSpecialistsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.CompositionObjectSpecialists, Bars.Stkomleks.CompositionObjectSpecialistsListModel>("CompositionObjectSpecialistsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.CompositionWorksObjects, Bars.Stkomleks.CompositionWorksObjectsEditorModel>("CompositionWorksObjectsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.CompositionWorksObjects, Bars.Stkomleks.CompositionWorksObjectsListModel>("CompositionWorksObjectsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.Products, Bars.Stkomleks.ProductsEditorModel>("ProductsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.Products, Bars.Stkomleks.ProductsListModel>("ProductsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.ObjectProducts, Bars.Stkomleks.ObjectProductsEditorModel>("ObjectProductsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.ObjectProducts, Bars.Stkomleks.ObjectProductsListModel>("ObjectProductsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.ObjectsDocuments, Bars.Stkomleks.ObjectsDocumentsEditorModel>("ObjectsDocumentsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.ObjectsDocuments, Bars.Stkomleks.ObjectsDocumentsListModel>("ObjectsDocumentsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.ObjectsOrders, Bars.Stkomleks.ObjectsOrdersEditorModel>("ObjectsOrdersEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.ObjectsOrders, Bars.Stkomleks.ObjectsOrdersList2Model>("ObjectsOrdersList2");
    Container.RegisterListViewServiceController<Bars.Stkomleks.ObjectsOrders, Bars.Stkomleks.ObjectsOrdersListModel>("ObjectsOrdersList");
    Container.RegisterMultiEditorViewServiceController<Bars.Stkomleks.ObjectsOrders, Bars.Stkomleks.ObjectsOrdersListMultiAddByZakazEditorModel>("ObjectsOrdersListMultiAddByZakazEditor");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.OrdersObjects, Bars.Stkomleks.OrdersObjectsEditor_Copy_0Model>("OrdersObjectsEditor_Copy_0");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.OrdersObjects, Bars.Stkomleks.OrdersObjectsEditorModel>("OrdersObjectsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.OrdersObjects, Bars.Stkomleks.OrdersObjectsList2Model>("OrdersObjectsList2");
    Container.RegisterListViewServiceController<Bars.Stkomleks.OrdersObjects, Bars.Stkomleks.OrdersObjectsListModel>("OrdersObjectsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.CurrentPositionsDepartments, Bars.Stkomleks.CurrentPositionsDepartmentsEditorModel>("CurrentPositionsDepartmentsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.CurrentPositionsDepartments, Bars.Stkomleks.CurrentPositionsDepartmentsListModel>("CurrentPositionsDepartmentsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.Departments, Bars.Stkomleks.DepartmentsEditorModel>("DepartmentsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.Departments, Bars.Stkomleks.DepartmentsListModel>("DepartmentsList");
    Container.RegisterListViewServiceController<Bars.Stkomleks.DepartmentsType, Bars.Stkomleks.DepartmentsTypeListModel>("DepartmentsTypeList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.DepartmentsPositions, Bars.Stkomleks.DepartmentsPositionsEditorModel>("DepartmentsPositionsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.DepartmentsPositions, Bars.Stkomleks.DepartmentsPositionsListModel>("DepartmentsPositionsList");
    Container.RegisterListViewServiceController<Bars.Stkomleks.PositionsTypes, Bars.Stkomleks.PositionsTypesListModel>("PositionsTypesList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.OrganizationContacts, Bars.Stkomleks.OrganizationContactsEditorModel>("OrganizationContactsEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.OrganizationContacts, Bars.Stkomleks.OrganizationContactsListModel>("OrganizationContactsList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.Organization, Bars.Stkomleks.OrganizationEditorModel>("OrganizationEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.OrganizationFundingPrograms, Bars.Stkomleks.OrganizationFundingProgramsList2Model>("OrganizationFundingProgramsList2");
    Container.RegisterListViewServiceController<Bars.Stkomleks.OrganizationFundingPrograms, Bars.Stkomleks.OrganizationFundingProgramsListModel>("OrganizationFundingProgramsList");
    Container.RegisterMultiEditorViewServiceController<Bars.Stkomleks.OrganizationFundingPrograms, Bars.Stkomleks.OrganizationFundingProgramsListMultiAddByOrganizationEditorModel>("OrganizationFundingProgramsListMultiAddByOrganizationEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.Organization, Bars.Stkomleks.OrganizationListModel>("OrganizationList");
    Container.RegisterListViewServiceController<Bars.Stkomleks.OrganizationProfiles, Bars.Stkomleks.OrganizationProfilesList2Model>("OrganizationProfilesList2");
    Container.RegisterListViewServiceController<Bars.Stkomleks.OrganizationProfiles, Bars.Stkomleks.OrganizationProfilesListModel>("OrganizationProfilesList");
    Container.RegisterMultiEditorViewServiceController<Bars.Stkomleks.OrganizationProfiles, Bars.Stkomleks.OrganizationProfilesListMultiAddByOrganizationEditorModel>("OrganizationProfilesListMultiAddByOrganizationEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.RelatedOrganizations, Bars.Stkomleks.RelatedOrganizationsListModel>("RelatedOrganizationsList");
    Container.RegisterMultiEditorViewServiceController<Bars.Stkomleks.RelatedOrganizations, Bars.Stkomleks.RelatedOrganizationsListMultiAddByOrganizationEditorModel>("RelatedOrganizationsListMultiAddByOrganizationEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.ContactsType, Bars.Stkomleks.ContactsTypeListModel>("ContactsTypeList");
    Container.RegisterListViewServiceController<Bars.Stkomleks.DocumentsType, Bars.Stkomleks.DocumentsTypeListModel>("DocumentsTypeList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.ObjectsTypes, Bars.Stkomleks.ObjectsTypesEditorModel>("ObjectsTypesEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.ObjectsTypes, Bars.Stkomleks.ObjectsTypesListModel>("ObjectsTypesList");
    Container.RegisterListViewServiceController<Bars.Stkomleks.ProductsTypes, Bars.Stkomleks.ProductsTypesListModel>("ProductsTypesList");
    Container.RegisterListViewServiceController<Bars.Stkomleks.ProfilesOrganizations, Bars.Stkomleks.ProfilesOrganizationsListModel>("ProfilesOrganizationsList");
    Container.RegisterListViewServiceController<Bars.Stkomleks.WorksRoles, Bars.Stkomleks.WorksRolesListModel>("WorksRolesList");
    Container.RegisterListViewServiceController<Bars.Stkomleks.TypesWorkTypesObjects, Bars.Stkomleks.TypesWorkTypesObjectsListModel>("TypesWorkTypesObjectsList");
    Container.RegisterMultiEditorViewServiceController<Bars.Stkomleks.TypesWorkTypesObjects, Bars.Stkomleks.TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel>("TypesWorkTypesObjectsListMultiAddByObjectTypeEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.UnitMeasure, Bars.Stkomleks.UnitMeasureListModel>("UnitMeasureList");
    Container.RegisterListViewServiceController<Bars.Stkomleks.WorksTypes, Bars.Stkomleks.WorksTypesListModel>("WorksTypesList");
    Container.RegisterEditorViewServiceController<Bars.Stkomleks.Staff, Bars.Stkomleks.StaffEditorModel>("StaffEditor");
    Container.RegisterListViewServiceController<Bars.Stkomleks.Staff, Bars.Stkomleks.StaffListModel>("StaffList");

}
private void RegisterFrontendServices(){
    Container.RegisterExtJsControllerClientRouteMapRegistrar<Bars.Stkomleks.ActionClientRoute>();

}
private void RegisterNavigationComponents(){
    Container.RegisterNavigationProvider<Bars.Stkomleks.MenuNavigation>();

}
private void RegisterServices(){
    Container.RegisterResourceManifest<Bars.Stkomleks.Frontend.Generated.ResourceManifest>();

}
    }
}
