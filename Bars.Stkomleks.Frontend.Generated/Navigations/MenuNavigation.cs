namespace Bars.Stkomleks
{
using Bars.Stkomleks.Core.Generated;
using Bars.Stkomleks.Frontend.Abstractions.Generated;
    using System;
    using BarsUp;
    using BarsUp.DataAccess;
    using System.Collections.Generic;
    
    
    using System.Linq;
    
    using BarsUp.Utils;
    using BarsUp.Windsor;
    using BarsUp.IoC;
    using BarsUp.UI.ExtJs.Compatibility4;

    using Castle.Windsor;
    using Castle.MicroKernel.Registration;

    public class MenuNavigation : INavigationProvider
    {
        public IWindsorContainer Container { get; set; }

        #region Implementation of INavigationProvider

        /// <summary>
        /// Ключ меню
        /// </summary>
        public string Key => BarsUp.Navigation.BaseMainMenuProvider.MenuKey;

        /// <summary>
        /// Описание меню
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Метод инифиализации
        /// </summary>
        public void Init(MenuItem root)
        {
			MenuItem @ref0 = null;
			MenuItem @ref1 = null;
			@ref0 = root.Add("Карта", "Map").WithRoute(new ExtJsControllerClientRoute("Map/", "B4.controller.Map"));
			@ref0.Icon="fad fa-map-marked-alt";			@ref0.AddOption("rmsUid", "526e730d-3717-40f2-bb30-6bdf3f9a5cb6");			root.ReOrder(@ref0.Caption);
			@ref0 = root.Add("Заказы", "OrdersList").WithRoute(new ExtJsControllerClientRoute("OrdersList/", "B4.controller.OrdersList"));
			@ref0.Icon="fad fa-clipboard-list-check";			@ref0.AddOption("rmsUid", "0ffb998f-e47b-4cf8-a13b-61733ccc958e");			root.ReOrder(@ref0.Caption);
			@ref0 = root.Add("Объекты", "OrdersObjectsList2").WithRoute(new ExtJsControllerClientRoute("OrdersObjectsList2/", "B4.controller.OrdersObjectsList2"));
			@ref0.Icon="fad fa-map-marker-alt";			@ref0.AddOption("rmsUid", "88c56884-76dd-4092-8a34-8408737a4cbb");			root.ReOrder(@ref0.Caption);
			@ref0 = root.Add("Продукция", "ProductsList").WithRoute(new ExtJsControllerClientRoute("ProductsList/", "B4.controller.ProductsList"));
			@ref0.Icon="fad fa-store-alt";			@ref0.AddOption("rmsUid", "0c8a2ede-fdc4-48b0-94b0-02a196718a59");			root.ReOrder(@ref0.Caption);
			@ref0 = root.Add("Программы финансирования", "FundingProgramsList").WithRoute(new ExtJsControllerClientRoute("FundingProgramsList/", "B4.controller.FundingProgramsList"));
			@ref0.Icon="fad fa-ruble-sign";			@ref0.AddOption("rmsUid", "115411bb-1c28-4ca6-adbe-15015e86e3f5");			root.ReOrder(@ref0.Caption);
			@ref0 = root.Add("Организации", "OrganizationList").WithRoute(new ExtJsControllerClientRoute("OrganizationList/", "B4.controller.OrganizationList"));
			@ref0.Icon="fad fa-building";			@ref0.AddOption("rmsUid", "ba8bc22a-ba14-4ee9-83f2-b356bfe02a77");			root.ReOrder(@ref0.Caption);
			@ref0 = root.Add("Физические лица", "IndividualsList").WithRoute(new ExtJsControllerClientRoute("IndividualsList/", "B4.controller.IndividualsList"));
			@ref0.Icon="fad fa-users";			@ref0.AddOption("rmsUid", "ce899deb-c07e-4725-8a74-ce47b09b6a25");			root.ReOrder(@ref0.Caption);
			@ref0 = root.Add("Справочники");
			@ref0.Icon="fad fa-book";			@ref0.AddOption("rmsUid", "e70cd970-a36f-4cd5-91e5-813a860b5d49");			@ref1 = @ref0.Add("Виды должностей", "PositionsTypesList").WithRoute(new ExtJsControllerClientRoute("PositionsTypesList/", "B4.controller.PositionsTypesList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "0ef9382d-f799-440a-bf99-796e24e3b3e3");			@ref1 = @ref0.Add("Типы контактов", "ContactsTypeList").WithRoute(new ExtJsControllerClientRoute("ContactsTypeList/", "B4.controller.ContactsTypeList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "5d09e527-6a87-4556-814a-55d20e27cafd");			@ref1 = @ref0.Add("Виды подразделений", "DepartmentsTypeList").WithRoute(new ExtJsControllerClientRoute("DepartmentsTypeList/", "B4.controller.DepartmentsTypeList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "e0fe86cf-aa31-48dc-9767-cc57f278c336");			@ref1 = @ref0.Add("Профили организаций", "ProfilesOrganizationsList").WithRoute(new ExtJsControllerClientRoute("ProfilesOrganizationsList/", "B4.controller.ProfilesOrganizationsList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "1a6c81d1-9c0a-4b76-8d7b-3f8deff886ad");			@ref1 = @ref0.Add("Типы объектов", "ObjectsTypesList").WithRoute(new ExtJsControllerClientRoute("ObjectsTypesList/", "B4.controller.ObjectsTypesList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "6834221d-2681-40e3-a7b7-85716e0b231f");			@ref1 = @ref0.Add("Роли в бригаде", "WorksRolesList").WithRoute(new ExtJsControllerClientRoute("WorksRolesList/", "B4.controller.WorksRolesList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "fc99f0d7-520d-4253-add1-2355a9223422");			@ref1 = @ref0.Add("Виды работ", "WorksTypesList").WithRoute(new ExtJsControllerClientRoute("WorksTypesList/", "B4.controller.WorksTypesList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "633601aa-0a5a-4d8f-8aeb-25fcde6dcd62");			@ref1 = @ref0.Add("Единицы измерения", "UnitMeasureList").WithRoute(new ExtJsControllerClientRoute("UnitMeasureList/", "B4.controller.UnitMeasureList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "f1cd0eec-24cd-4949-b5ed-d7dcb19643e2");			@ref1 = @ref0.Add("Типы продуктов", "ProductsTypesList").WithRoute(new ExtJsControllerClientRoute("ProductsTypesList/", "B4.controller.ProductsTypesList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "071407f6-2680-45ab-af1b-9ab1e5ab9606");			@ref1 = @ref0.Add("Типы документов", "DocumentsTypeList").WithRoute(new ExtJsControllerClientRoute("DocumentsTypeList/", "B4.controller.DocumentsTypeList"));
			@ref1.Icon="fad fa-book";			@ref1.AddOption("rmsUid", "c6151645-41e5-4246-bd62-de5cebea8b52");			@ref1 = @ref0.Add("Работы.Объект", "CompositionWorksObjectsList").WithRoute(new ExtJsControllerClientRoute("CompositionWorksObjectsList/", "B4.controller.CompositionWorksObjectsList"));
			@ref1.AddOption("rmsUid", "6865b87c-85eb-4144-81fa-5b086b3351b3");			@ref1 = @ref0.Add("Организации по профилю.Выбор", "OrganizationProfilesList2").WithRoute(new ExtJsControllerClientRoute("OrganizationProfilesList2/", "B4.controller.OrganizationProfilesList2"));
			@ref1.AddOption("rmsUid", "bb783c2f-3233-4891-bd96-dcda52b76a58");			root.ReOrder(@ref0.Caption);

        }

        #endregion
    }
}