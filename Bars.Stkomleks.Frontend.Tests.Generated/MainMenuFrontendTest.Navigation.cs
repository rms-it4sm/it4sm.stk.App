// ReSharper disable InconsistentNaming
// ReSharper disable ClassNeverInstantiated.Global
namespace Bars.Stkomleks.Frontend.Tests
{
using Bars.Stkomleks.Frontend;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Castle.Windsor;    

    using BarsUp.DataAccess;    
    using BarsUp.Utils;    
    using BarsUp.QualityAssurance.Web;
    using BarsUp.QualityAssurance.Web.ExtJs;        
    using BarsUp.QualityAssurance.Web.PageObjects;        

    using Bars.Stkomleks.Frontend;
    using Bars.Stkomleks.Frontend.Tests;    
    using Bars.Stkomleks.Frontend.Tests.PageObjects;
    using Bars.Stkomleks.Frontend.Tests.Clickers;

    using Xunit;
    using Xunit.Abstractions;
    using OpenQA.Selenium;

    /// <summary>    
    /// Статический класс, содержащий методы расширения для удобного перехода по элементам главного меню
    /// </summary>       
    public static class MainMenuFrontendTestNavigationExtensions        
    {          
        
/// <summary>
/// Перейти по адресу #OrdersList (пункт меню /Заказы) и вернуть объект для управления реестром [Заказы].
/// </summary>
public static OrdersListPageObject NavigateToHash_OrdersList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("OrdersList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<OrdersListPageObject>("rms-orderslist");
}

/// <summary>
/// Перейти по адресу #OrdersObjectsList2 (пункт меню /Объекты) и вернуть объект для управления реестром [Объекты].
/// </summary>
public static OrdersObjectsList2PageObject NavigateToHash_OrdersObjectsList2(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("OrdersObjectsList2");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<OrdersObjectsList2PageObject>("rms-ordersobjectslist2");
}

/// <summary>
/// Перейти по адресу #OrganizationList (пункт меню /Организации) и вернуть объект для управления реестром [Организации].
/// </summary>
public static OrganizationListPageObject NavigateToHash_OrganizationList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("OrganizationList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<OrganizationListPageObject>("rms-organizationlist");
}

/// <summary>
/// Перейти по адресу #FundingProgramsList (пункт меню /Программы финансирования) и вернуть объект для управления реестром [Программы финансирования].
/// </summary>
public static FundingProgramsListPageObject NavigateToHash_FundingProgramsList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("FundingProgramsList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<FundingProgramsListPageObject>("rms-fundingprogramslist");
}

/// <summary>
/// Перейти по адресу #ProductsList (пункт меню /Продукция) и вернуть объект для управления реестром [Комплектация.Элемент спецификации].
/// </summary>
public static ProductsListPageObject NavigateToHash_ProductsList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("ProductsList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<ProductsListPageObject>("rms-productslist");
}

/// <summary>
/// Перейти по адресу #PositionsTypesList (пункт меню Справочники/Виды должностей) и вернуть объект для управления реестром [Виды должностей].
/// </summary>
public static PositionsTypesListPageObject NavigateToHash_PositionsTypesList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("PositionsTypesList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<PositionsTypesListPageObject>("rms-positionstypeslist");
}

/// <summary>
/// Перейти по адресу #ContactsTypeList (пункт меню Справочники/Типы контактов) и вернуть объект для управления реестром [Типы контактов].
/// </summary>
public static ContactsTypeListPageObject NavigateToHash_ContactsTypeList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("ContactsTypeList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<ContactsTypeListPageObject>("rms-contactstypelist");
}

/// <summary>
/// Перейти по адресу #DepartmentsTypeList (пункт меню Справочники/Виды подразделений) и вернуть объект для управления реестром [Виды подразделений].
/// </summary>
public static DepartmentsTypeListPageObject NavigateToHash_DepartmentsTypeList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("DepartmentsTypeList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<DepartmentsTypeListPageObject>("rms-departmentstypelist");
}

/// <summary>
/// Перейти по адресу #ProfilesOrganizationsList (пункт меню Справочники/Профили организаций) и вернуть объект для управления реестром [Профили организаций].
/// </summary>
public static ProfilesOrganizationsListPageObject NavigateToHash_ProfilesOrganizationsList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("ProfilesOrganizationsList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<ProfilesOrganizationsListPageObject>("rms-profilesorganizationslist");
}

/// <summary>
/// Перейти по адресу #ObjectsTypesList (пункт меню Справочники/Типы объектов) и вернуть объект для управления реестром [Типы объектов].
/// </summary>
public static ObjectsTypesListPageObject NavigateToHash_ObjectsTypesList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("ObjectsTypesList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<ObjectsTypesListPageObject>("rms-objectstypeslist");
}

/// <summary>
/// Перейти по адресу #WorksRolesList (пункт меню Справочники/Роли в бригаде) и вернуть объект для управления реестром [Роли в бригаде].
/// </summary>
public static WorksRolesListPageObject NavigateToHash_WorksRolesList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("WorksRolesList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<WorksRolesListPageObject>("rms-worksroleslist");
}

/// <summary>
/// Перейти по адресу #WorksTypesList (пункт меню Справочники/Виды работ) и вернуть объект для управления реестром [Виды работ].
/// </summary>
public static WorksTypesListPageObject NavigateToHash_WorksTypesList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("WorksTypesList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<WorksTypesListPageObject>("rms-workstypeslist");
}

/// <summary>
/// Перейти по адресу #UnitMeasureList (пункт меню Справочники/Единицы измерения) и вернуть объект для управления реестром [Единицы измерения].
/// </summary>
public static UnitMeasureListPageObject NavigateToHash_UnitMeasureList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("UnitMeasureList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<UnitMeasureListPageObject>("rms-unitmeasurelist");
}

/// <summary>
/// Перейти по адресу #ProductsTypesList (пункт меню Справочники/Типы продуктов) и вернуть объект для управления реестром [Типы продуктов].
/// </summary>
public static ProductsTypesListPageObject NavigateToHash_ProductsTypesList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("ProductsTypesList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<ProductsTypesListPageObject>("rms-productstypeslist");
}

/// <summary>
/// Перейти по адресу #DocumentsTypeList (пункт меню Справочники/Типы документов) и вернуть объект для управления реестром [Типы документов].
/// </summary>
public static DocumentsTypeListPageObject NavigateToHash_DocumentsTypeList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("DocumentsTypeList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<DocumentsTypeListPageObject>("rms-documentstypelist");
}

/// <summary>
/// Перейти по адресу #CompositionWorksObjectsList (пункт меню Справочники/Работы.Объект) и вернуть объект для управления реестром [Работы.Объект].
/// </summary>
public static CompositionWorksObjectsListPageObject NavigateToHash_CompositionWorksObjectsList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("CompositionWorksObjectsList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<CompositionWorksObjectsListPageObject>("rms-compositionworksobjectslist");
}

/// <summary>
/// Перейти по адресу #OrganizationProfilesList2 (пункт меню Справочники/Организации по профилю.Выбор) и вернуть объект для управления реестром [Организации по профилю.Выбор].
/// </summary>
public static OrganizationProfilesList2PageObject NavigateToHash_OrganizationProfilesList2(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("OrganizationProfilesList2");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<OrganizationProfilesList2PageObject>("rms-organizationprofileslist2");
}

/// <summary>
/// Перейти по адресу #IndividualsList (пункт меню /Физические лица) и вернуть объект для управления реестром [Физические лица].
/// </summary>
public static IndividualsListPageObject NavigateToHash_IndividualsList(this WebDriverAbstractFixture fixture) {
    fixture.NavigateToHash("IndividualsList");
    fixture.WaitUntilExtIsReady();
    return fixture.FindExtJsComponent<IndividualsListPageObject>("rms-individualslist");
}
    }
}