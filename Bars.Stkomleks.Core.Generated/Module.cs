namespace Bars.Stkomleks.Core.Generated
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
    
    using BarsUp.Modules.States.Interceptors;

    using BarsUp.Designer.Core;

    using JetBrains.Annotations;

    using BarsUp.Core;

    using BarsUp.Modules.Security;

    using BarsUp.DataAccess;

    using BarsUp.Modules.Mapping.NHibernate;

    using BarsUp.Modules.PostgreSql;

    using BarsUp.Modules.ChangeRequest;

    using BarsUp.Modules.Versioning;

    using BarsUp.Modules.Workflow.Generated;

    using BarsUp.Modules.EntityVersioning;

    using BarsUp.Modules.Fias;

    using BarsUp.Modules.RuntimeFilters;

    using BarsUp.Designer.GeneratedApp;

    using BarsUp.Modules.DataView;

    using BarsUp.Modules.Leaflet;

    using BarsUp.Modules.FileSystemStorage;

    using BarsUp.Modules.FTPStorage;
    using BarsUp.Utils;

    /// <summary>
    /// Класс подключения модуля
    /// </summary>
    [BarsUp.Utils.Display("Стройкомлекс [Core] (Генерируемый проект)")]    
    [BarsUp.Utils.Attributes.Uid("9bc53c36-6a42-9118-911a-7b58501925b8")]
    public class Module : AssemblyDefinedModule, IAspNetCoreServiceConfigurator
    {        
        /// <summary>
        /// Загрузка модуля
        /// </summary>
        public override void Install()
        {
            RegisterDataComponents();
RegisterInterceptors();
RegisterStateServices();
AssemblyReplacedTypeResolver.AddAssemblyReplace("Bars.Stkomleks", GetType().Assembly.GetName().Name);
            
        }        
        
        protected override void SetDependencies()
        {
            base.SetDependencies();
            DependsOn<BarsUp.Core.Module>();
DependsOn<BarsUp.Designer.GeneratedApp.Module>();
DependsOn<BarsUp.Modules.ChangeRequest.Module>();
DependsOn<BarsUp.Modules.DataView.Module>();
DependsOn<BarsUp.Modules.EntityVersioning.Module>();
DependsOn<BarsUp.Modules.FileSystemStorage.Module>();
DependsOn<BarsUp.Modules.FTPStorage.Module>();
DependsOn<BarsUp.Modules.Leaflet.Module>();
DependsOn<BarsUp.Modules.RuntimeFilters.Module>();
DependsOn<BarsUp.Modules.Workflow.Generated.Module>();
            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
            
        }

        private void RegisterDataComponents(){
    Container.RegisterSingleton<BarsUp.IModuleDependencies, Bars.Stkomleks.ModuleDependencies>();
    Container.RegisterTransient<BarsUp.DataAccess.INhibernateConfigModifier, Bars.Stkomleks.NHibernateConfigurator>();
    NHibernateConfigurator.RegisterAll();

}
private void RegisterInterceptors(){
    Container.RegisterDomainInterceptor<Bars.Stkomleks.CompositionObjectSpecialists, CompositionObjectSpecialistsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.CompositionWorksObjects, CompositionWorksObjectsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ContactsIndiv, ContactsIndivDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ContactsType, ContactsTypeDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ContractDocuments, ContractDocumentsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.CurrentPositionsDepartments, CurrentPositionsDepartmentsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Departments, DepartmentsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.DepartmentsPositions, DepartmentsPositionsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.DepartmentsType, DepartmentsTypeDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Documents, DocumentsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.DocumentsType, DocumentsTypeDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.FundingPrograms, FundingProgramsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Individuals, IndividualsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ObjectProducts, ObjectProductsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ObjectsDocuments, ObjectsDocumentsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ObjectsOrders, ObjectsOrdersDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ObjectsStages, ObjectsStagesDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ObjectsTypes, ObjectsTypesDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.OrderOrganization, OrderOrganizationDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.OrdersObjects, OrdersObjectsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.OrganizationContacts, OrganizationContactsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.OrganizationFundingPrograms, OrganizationFundingProgramsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Organization, OrganizationDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.OrganizationProfiles, OrganizationProfilesDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.PositionsTypes, PositionsTypesDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Products, ProductsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ProductsTypes, ProductsTypesDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ProfilesOrganizations, ProfilesOrganizationsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.RelatedOrganizations, RelatedOrganizationsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.ResponsiblePersonsOrder, ResponsiblePersonsOrderDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Staff, StaffDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.TypesWorkTypesObjects, TypesWorkTypesObjectsDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.UnitMeasure, UnitMeasureDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.WorksRoles, WorksRolesDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.WorksTypes, WorksTypesDomainServiceInterceptor>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Zakaz, ZakazDomainServiceInterceptor>();

}
private void RegisterStateServices(){
    Container.RegisterTransient<BarsUp.Modules.States.IStatefulEntitiesManifest, Bars.Stkomleks.States.StatesManifest>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Zakaz, GenericStatefulEntityInterceptor<Bars.Stkomleks.Zakaz>>();
    Container.RegisterDataStoreInterceptor<StatefulEntityDataStoreInterceptor<Bars.Stkomleks.Zakaz>>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.OrdersObjects, GenericStatefulEntityInterceptor<Bars.Stkomleks.OrdersObjects>>();
    Container.RegisterDataStoreInterceptor<StatefulEntityDataStoreInterceptor<Bars.Stkomleks.OrdersObjects>>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.CompositionWorksObjects, GenericStatefulEntityInterceptor<Bars.Stkomleks.CompositionWorksObjects>>();
    Container.RegisterDataStoreInterceptor<StatefulEntityDataStoreInterceptor<Bars.Stkomleks.CompositionWorksObjects>>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Organization, GenericStatefulEntityInterceptor<Bars.Stkomleks.Organization>>();
    Container.RegisterDataStoreInterceptor<StatefulEntityDataStoreInterceptor<Bars.Stkomleks.Organization>>();
    Container.RegisterDomainInterceptor<Bars.Stkomleks.Staff, GenericStatefulEntityInterceptor<Bars.Stkomleks.Staff>>();
    Container.RegisterDataStoreInterceptor<StatefulEntityDataStoreInterceptor<Bars.Stkomleks.Staff>>();

}
    }
}
