namespace Bars.Stkomleks.Frontend.Generated
{
    using BarsUp;
    using BarsUp.UI.ExtJs;
	using BarsUp.UI.ExtJs.Compatibility4;
	using System.Collections.Generic;
	using System.Linq;
	using BarsUp.Utils;
	using BarsUp.Modules.Security;

    internal partial class ResourceManifest : ResourceManifestBase
    {
        protected override void AdditionalInit(IResourceManifestContainer container)
        {
		#region Перечисления

				container
            .DefineExtJsEnum<Bars.Stkomleks.TypesWorkPerformers>()
            .AlterClassName("TypesWorkPerformers");            			
				

		#endregion

		#region Модели

		container.DefineExtJsModel<Bars.Stkomleks.CompositionObjectSpecialistsEditorModel>().ActionMethods(read: "POST").Controller("CompositionObjectSpecialistsEditor");
container.DefineExtJsModel<Bars.Stkomleks.CompositionWorksObjectsEditorModel>().ActionMethods(read: "POST").Controller("CompositionWorksObjectsEditor");
container.DefineExtJsModel<Bars.Stkomleks.CurrentPositionsDepartmentsEditorModel>().ActionMethods(read: "POST").Controller("CurrentPositionsDepartmentsEditor");
container.DefineExtJsModel<Bars.Stkomleks.DepartmentsEditorModel>().ActionMethods(read: "POST").Controller("DepartmentsEditor");
container.DefineExtJsModel<Bars.Stkomleks.DepartmentsPositionsEditorModel>().ActionMethods(read: "POST").Controller("DepartmentsPositionsEditor");
container.DefineExtJsModel<Bars.Stkomleks.FundingProgramsEditorModel>().ActionMethods(read: "POST").Controller("FundingProgramsEditor");
container.DefineExtJsModel<Bars.Stkomleks.IndividualsEditorModel>().ActionMethods(read: "POST").Controller("IndividualsEditor");
container.DefineExtJsModel<Bars.Stkomleks.ObjectProductsEditorModel>().ActionMethods(read: "POST").Controller("ObjectProductsEditor");
container.DefineExtJsModel<Bars.Stkomleks.ObjectsDocumentsEditorModel>().ActionMethods(read: "POST").Controller("ObjectsDocumentsEditor");
container.DefineExtJsModel<Bars.Stkomleks.ObjectsOrdersEditorModel>().ActionMethods(read: "POST").Controller("ObjectsOrdersEditor");
container.DefineExtJsModel<Bars.Stkomleks.ObjectsOrdersListMultiAddByZakazEditorModel>().ActionMethods(read: "POST").Controller("ObjectsOrdersListMultiAddByZakazEditor");
container.DefineExtJsModel<Bars.Stkomleks.ObjectsTypesEditorModel>().ActionMethods(read: "POST").Controller("ObjectsTypesEditor");
container.DefineExtJsModel<Bars.Stkomleks.OrderOrganizationEditorModel>().ActionMethods(read: "POST").Controller("OrderOrganizationEditor");
container.DefineExtJsModel<Bars.Stkomleks.OrdersEditorModel>().ActionMethods(read: "POST").Controller("OrdersEditor");
container.DefineExtJsModel<Bars.Stkomleks.OrdersObjectsEditor_Copy_0Model>().ActionMethods(read: "POST").Controller("OrdersObjectsEditor_Copy_0");
container.DefineExtJsModel<Bars.Stkomleks.OrdersObjectsEditorModel>().ActionMethods(read: "POST").Controller("OrdersObjectsEditor");
container.DefineExtJsModel<Bars.Stkomleks.OrganizationContactsEditorModel>().ActionMethods(read: "POST").Controller("OrganizationContactsEditor");
container.DefineExtJsModel<Bars.Stkomleks.OrganizationEditorModel>().ActionMethods(read: "POST").Controller("OrganizationEditor");
container.DefineExtJsModel<Bars.Stkomleks.OrganizationFundingProgramsListMultiAddByOrganizationEditorModel>().ActionMethods(read: "POST").Controller("OrganizationFundingProgramsListMultiAddByOrganizationEditor");
container.DefineExtJsModel<Bars.Stkomleks.OrganizationProfilesListMultiAddByOrganizationEditorModel>().ActionMethods(read: "POST").Controller("OrganizationProfilesListMultiAddByOrganizationEditor");
container.DefineExtJsModel<Bars.Stkomleks.ProductsEditorModel>().ActionMethods(read: "POST").Controller("ProductsEditor");
container.DefineExtJsModel<Bars.Stkomleks.RelatedOrganizationsListMultiAddByOrganizationEditorModel>().ActionMethods(read: "POST").Controller("RelatedOrganizationsListMultiAddByOrganizationEditor");
container.DefineExtJsModel<Bars.Stkomleks.ResponsiblePersonsOrderEditorModel>().ActionMethods(read: "POST").Controller("ResponsiblePersonsOrderEditor");
container.DefineExtJsModel<Bars.Stkomleks.StaffEditorModel>().ActionMethods(read: "POST").Controller("StaffEditor");
container.DefineExtJsModel<Bars.Stkomleks.TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel>().ActionMethods(read: "POST").Controller("TypesWorkTypesObjectsListMultiAddByObjectTypeEditor");
container.DefineExtJsModel<BarsUp.Modules.FileStorage.FileInfo>().ActionMethods(read: "POST").Controller("Empty");
container.DefineExtJsModel<CompositionObjectSpecialistsListModel>().ActionMethods(read: "POST").Controller("CompositionObjectSpecialistsList");
container.DefineExtJsModel<CompositionWorksObjectsListModel>().ActionMethods(read: "POST").Controller("CompositionWorksObjectsList");
container.DefineExtJsModel<ContactsTypeListModel>().ActionMethods(read: "POST").Controller("ContactsTypeList");
container.DefineExtJsModel<CurrentPositionsDepartmentsListModel>().ActionMethods(read: "POST").Controller("CurrentPositionsDepartmentsList");
container.DefineExtJsModel<DepartmentsListModel>().ActionMethods(read: "POST").Controller("DepartmentsList");
container.DefineExtJsModel<DepartmentsPositionsListModel>().ActionMethods(read: "POST").Controller("DepartmentsPositionsList");
container.DefineExtJsModel<DepartmentsTypeListModel>().ActionMethods(read: "POST").Controller("DepartmentsTypeList");
container.DefineExtJsModel<DocumentsTypeListModel>().ActionMethods(read: "POST").Controller("DocumentsTypeList");
container.DefineExtJsModel<FundingProgramsListModel>().ActionMethods(read: "POST").Controller("FundingProgramsList");
container.DefineExtJsModel<IndividualsListModel>().ActionMethods(read: "POST").Controller("IndividualsList");
container.DefineExtJsModel<ObjectProductsListModel>().ActionMethods(read: "POST").Controller("ObjectProductsList");
container.DefineExtJsModel<ObjectsDocumentsListModel>().ActionMethods(read: "POST").Controller("ObjectsDocumentsList");
container.DefineExtJsModel<ObjectsOrdersList2Model>().ActionMethods(read: "POST").Controller("ObjectsOrdersList2");
container.DefineExtJsModel<ObjectsOrdersListModel>().ActionMethods(read: "POST").Controller("ObjectsOrdersList");
container.DefineExtJsModel<ObjectsTypesListModel>().ActionMethods(read: "POST").Controller("ObjectsTypesList");
container.DefineExtJsModel<OrderOrganizationListModel>().ActionMethods(read: "POST").Controller("OrderOrganizationList");
container.DefineExtJsModel<OrdersListModel>().ActionMethods(read: "POST").Controller("OrdersList");
container.DefineExtJsModel<OrdersObjectsList2Model>().ActionMethods(read: "POST").Controller("OrdersObjectsList2");
container.DefineExtJsModel<OrdersObjectsListModel>().ActionMethods(read: "POST").Controller("OrdersObjectsList");
container.DefineExtJsModel<OrganizationContactsListModel>().ActionMethods(read: "POST").Controller("OrganizationContactsList");
container.DefineExtJsModel<OrganizationFundingProgramsList2Model>().ActionMethods(read: "POST").Controller("OrganizationFundingProgramsList2");
container.DefineExtJsModel<OrganizationFundingProgramsListModel>().ActionMethods(read: "POST").Controller("OrganizationFundingProgramsList");
container.DefineExtJsModel<OrganizationListModel>().ActionMethods(read: "POST").Controller("OrganizationList");
container.DefineExtJsModel<OrganizationProfilesList2Model>().ActionMethods(read: "POST").Controller("OrganizationProfilesList2");
container.DefineExtJsModel<OrganizationProfilesListModel>().ActionMethods(read: "POST").Controller("OrganizationProfilesList");
container.DefineExtJsModel<PositionsTypesListModel>().ActionMethods(read: "POST").Controller("PositionsTypesList");
container.DefineExtJsModel<ProductsListModel>().ActionMethods(read: "POST").Controller("ProductsList");
container.DefineExtJsModel<ProductsTypesListModel>().ActionMethods(read: "POST").Controller("ProductsTypesList");
container.DefineExtJsModel<ProfilesOrganizationsListModel>().ActionMethods(read: "POST").Controller("ProfilesOrganizationsList");
container.DefineExtJsModel<RelatedOrganizationsListModel>().ActionMethods(read: "POST").Controller("RelatedOrganizationsList");
container.DefineExtJsModel<ResponsiblePersonsOrderListModel>().ActionMethods(read: "POST").Controller("ResponsiblePersonsOrderList");
container.DefineExtJsModel<StaffListModel>().ActionMethods(read: "POST").Controller("StaffList");
container.DefineExtJsModel<TypesWorkTypesObjectsListModel>().ActionMethods(read: "POST").Controller("TypesWorkTypesObjectsList");
container.DefineExtJsModel<UnitMeasureListModel>().ActionMethods(read: "POST").Controller("UnitMeasureList");
container.DefineExtJsModel<WorksRolesListModel>().ActionMethods(read: "POST").Controller("WorksRolesList");
container.DefineExtJsModel<WorksTypesListModel>().ActionMethods(read: "POST").Controller("WorksTypesList");

			

		#endregion
        }                
    }
}
