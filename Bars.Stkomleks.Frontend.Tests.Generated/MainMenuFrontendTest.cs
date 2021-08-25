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
/// Абстрактный класс, содержащий факты для проверки элементов, открываемых из главного меню.
/// открытие элементов происходит переходом на хэш, а не кликом на реальный элемент меню.
/// В кастомной части проекта необходимо отнаследоваться от данного класса и установить параметры
/// входа в систему и тип тестирования (локальный или удаленный)
/// </summary>
public abstract class AbstractMainMenuFrontendTest<TFixture> : AbstractWebDriverTest<TFixture> where TFixture : WebDriverAbstractFixture
{
    protected AbstractMainMenuFrontendTest(TFixture fixture, ITestOutputHelper log) : base(fixture, log)
    {
    }

    /// <summary>
    /// Переход на хэш /Заказы и прокликивание представления [Заказы]
    /// </summary>
    [Trait("Category", "Группа меню: ")]
    [SkippableFact(DisplayName = "Пункт меню: /Заказы")]
    public void Navigate_To_OrdersList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Заказы]", 
            () => {
                Log.WriteLine("Переходим на адрес #OrdersList");
                var registry = Fixture.NavigateToHash_OrdersList();
                RunClicker<OrdersListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш /Объекты и прокликивание представления [Объекты]
    /// </summary>
    [Trait("Category", "Группа меню: ")]
    [SkippableFact(DisplayName = "Пункт меню: /Объекты")]
    public void Navigate_To_OrdersObjectsList2_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Объекты]", 
            () => {
                Log.WriteLine("Переходим на адрес #OrdersObjectsList2");
                var registry = Fixture.NavigateToHash_OrdersObjectsList2();
                RunClicker<OrdersObjectsList2Clicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш /Организации и прокликивание представления [Организации]
    /// </summary>
    [Trait("Category", "Группа меню: ")]
    [SkippableFact(DisplayName = "Пункт меню: /Организации")]
    public void Navigate_To_OrganizationList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Организации]", 
            () => {
                Log.WriteLine("Переходим на адрес #OrganizationList");
                var registry = Fixture.NavigateToHash_OrganizationList();
                RunClicker<OrganizationListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш /Программы финансирования и прокликивание представления [Программы финансирования]
    /// </summary>
    [Trait("Category", "Группа меню: ")]
    [SkippableFact(DisplayName = "Пункт меню: /Программы финансирования")]
    public void Navigate_To_FundingProgramsList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Программы финансирования]", 
            () => {
                Log.WriteLine("Переходим на адрес #FundingProgramsList");
                var registry = Fixture.NavigateToHash_FundingProgramsList();
                RunClicker<FundingProgramsListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш /Продукция и прокликивание представления [Комплектация.Элемент спецификации]
    /// </summary>
    [Trait("Category", "Группа меню: ")]
    [SkippableFact(DisplayName = "Пункт меню: /Продукция")]
    public void Navigate_To_ProductsList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Комплектация.Элемент спецификации]", 
            () => {
                Log.WriteLine("Переходим на адрес #ProductsList");
                var registry = Fixture.NavigateToHash_ProductsList();
                RunClicker<ProductsListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Виды должностей и прокликивание представления [Виды должностей]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Виды должностей")]
    public void Navigate_To_PositionsTypesList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Виды должностей]", 
            () => {
                Log.WriteLine("Переходим на адрес #PositionsTypesList");
                var registry = Fixture.NavigateToHash_PositionsTypesList();
                RunClicker<PositionsTypesListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Типы контактов и прокликивание представления [Типы контактов]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Типы контактов")]
    public void Navigate_To_ContactsTypeList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Типы контактов]", 
            () => {
                Log.WriteLine("Переходим на адрес #ContactsTypeList");
                var registry = Fixture.NavigateToHash_ContactsTypeList();
                RunClicker<ContactsTypeListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Виды подразделений и прокликивание представления [Виды подразделений]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Виды подразделений")]
    public void Navigate_To_DepartmentsTypeList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Виды подразделений]", 
            () => {
                Log.WriteLine("Переходим на адрес #DepartmentsTypeList");
                var registry = Fixture.NavigateToHash_DepartmentsTypeList();
                RunClicker<DepartmentsTypeListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Профили организаций и прокликивание представления [Профили организаций]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Профили организаций")]
    public void Navigate_To_ProfilesOrganizationsList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Профили организаций]", 
            () => {
                Log.WriteLine("Переходим на адрес #ProfilesOrganizationsList");
                var registry = Fixture.NavigateToHash_ProfilesOrganizationsList();
                RunClicker<ProfilesOrganizationsListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Типы объектов и прокликивание представления [Типы объектов]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Типы объектов")]
    public void Navigate_To_ObjectsTypesList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Типы объектов]", 
            () => {
                Log.WriteLine("Переходим на адрес #ObjectsTypesList");
                var registry = Fixture.NavigateToHash_ObjectsTypesList();
                RunClicker<ObjectsTypesListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Роли в бригаде и прокликивание представления [Роли в бригаде]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Роли в бригаде")]
    public void Navigate_To_WorksRolesList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Роли в бригаде]", 
            () => {
                Log.WriteLine("Переходим на адрес #WorksRolesList");
                var registry = Fixture.NavigateToHash_WorksRolesList();
                RunClicker<WorksRolesListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Виды работ и прокликивание представления [Виды работ]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Виды работ")]
    public void Navigate_To_WorksTypesList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Виды работ]", 
            () => {
                Log.WriteLine("Переходим на адрес #WorksTypesList");
                var registry = Fixture.NavigateToHash_WorksTypesList();
                RunClicker<WorksTypesListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Единицы измерения и прокликивание представления [Единицы измерения]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Единицы измерения")]
    public void Navigate_To_UnitMeasureList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Единицы измерения]", 
            () => {
                Log.WriteLine("Переходим на адрес #UnitMeasureList");
                var registry = Fixture.NavigateToHash_UnitMeasureList();
                RunClicker<UnitMeasureListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Типы продуктов и прокликивание представления [Типы продуктов]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Типы продуктов")]
    public void Navigate_To_ProductsTypesList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Типы продуктов]", 
            () => {
                Log.WriteLine("Переходим на адрес #ProductsTypesList");
                var registry = Fixture.NavigateToHash_ProductsTypesList();
                RunClicker<ProductsTypesListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Типы документов и прокликивание представления [Типы документов]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Типы документов")]
    public void Navigate_To_DocumentsTypeList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Типы документов]", 
            () => {
                Log.WriteLine("Переходим на адрес #DocumentsTypeList");
                var registry = Fixture.NavigateToHash_DocumentsTypeList();
                RunClicker<DocumentsTypeListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Работы.Объект и прокликивание представления [Работы.Объект]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Работы.Объект")]
    public void Navigate_To_CompositionWorksObjectsList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Работы.Объект]", 
            () => {
                Log.WriteLine("Переходим на адрес #CompositionWorksObjectsList");
                var registry = Fixture.NavigateToHash_CompositionWorksObjectsList();
                RunClicker<CompositionWorksObjectsListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш Справочники/Организации по профилю.Выбор и прокликивание представления [Организации по профилю.Выбор]
    /// </summary>
    [Trait("Category", "Группа меню: Справочники")]
    [SkippableFact(DisplayName = "Пункт меню: Справочники/Организации по профилю.Выбор")]
    public void Navigate_To_OrganizationProfilesList2_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Организации по профилю.Выбор]", 
            () => {
                Log.WriteLine("Переходим на адрес #OrganizationProfilesList2");
                var registry = Fixture.NavigateToHash_OrganizationProfilesList2();
                RunClicker<OrganizationProfilesList2Clicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }

    /// <summary>
    /// Переход на хэш /Физические лица и прокликивание представления [Физические лица]
    /// </summary>
    [Trait("Category", "Группа меню: ")]
    [SkippableFact(DisplayName = "Пункт меню: /Физические лица")]
    public void Navigate_To_IndividualsList_And_Ensure_View_Is_Working() {
        EnsureAuthenticatedStep();
        Step("Обход элемента [Физические лица]", 
            () => {
                Log.WriteLine("Переходим на адрес #IndividualsList");
                var registry = Fixture.NavigateToHash_IndividualsList();
                RunClicker<IndividualsListClicker>(registry);
                Log.WriteLine("Закрываем вкладку рабочего стола");
                Fixture.CloseFlexDeskTab(registry);
            }
        );
    }
}
}