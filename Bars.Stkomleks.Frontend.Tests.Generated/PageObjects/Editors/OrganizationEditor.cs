// ReSharper disable InconsistentNaming
// ReSharper disable ClassNeverInstantiated.Global
namespace Bars.Stkomleks.Frontend.Tests.PageObjects
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

    using Xunit;
    using Xunit.Abstractions;
    using OpenQA.Selenium;    

    /// <summary>    
    /// Описание формы 'Организация' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-organizationeditor")]
    [Display("Редактор [Организация]")]
    public class OrganizationEditorPageObject : BarsUpGeneratedEditorView<OrganizationEditorModel>
    {  
        public OrganizationEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrganizationEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Однострочный редактор текста [Наименование]
/// Идентификатор [8967b231-f09f-444d-8ebf-df640d6e5ea7]
/// Поле сущности: Организации.Наименование
/// </summary>
[Display("Наименование")]
public ExtJsFormField<System.String> Наименование { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Полное наименование]
/// Идентификатор [d9aaab32-d046-44a2-9640-5112287c8446]
/// Поле сущности: Организации.Полное наименование
/// </summary>
[Display("Полное наименование")]
public ExtJsFormField<System.String> Полное_наименование { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [5803587b-88bc-4dc9-9b20-69f8c6fbe17c]
/// Поле сущности: Организации.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }

/// <summary>
/// Панель закладок [Панель закладок]
/// Идентификатор [de543d87-4d96-41a1-9b65-55b7f356e7ee]
/// </summary>
[Display("Панель закладок")]
public BarsUpPageCmp_TabPanel_Панель_закладок Панель_закладок { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Наименование = Down<ExtJsFormField<System.String>>("[rmsUid=8967b231-f09f-444d-8ebf-df640d6e5ea7]");
Полное_наименование = Down<ExtJsFormField<System.String>>("[rmsUid=d9aaab32-d046-44a2-9640-5112287c8446]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=5803587b-88bc-4dc9-9b20-69f8c6fbe17c]");
Панель_закладок = Down<BarsUpPageCmp_TabPanel_Панель_закладок>("[rmsUid=de543d87-4d96-41a1-9b65-55b7f356e7ee]");
        }

        
public class BarsUpPageCmp_TabPanel_Панель_закладок : ExtJsTabPanel {
    public BarsUpPageCmp_TabPanel_Панель_закладок(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public BarsUpPageCmp_TabPanel_Панель_закладок(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

    /// <summary>
    /// Закладка [Контакты]
    /// Идентификатор [47e31e2d-1c03-425a-bec3-eddf7c188db7]
    /// </summary>
    [Display("Контакты")]
    public BarsUpPageCmp_Tab_Контакты Контакты { get; internal set; }

    /// <summary>
    /// Закладка [Подразделения]
    /// Идентификатор [a43cf966-c60e-4eb7-9dc3-4d3ac4be2ab3]
    /// </summary>
    [Display("Подразделения")]
    public BarsUpPageCmp_Tab_Подразделения Подразделения { get; internal set; }

    /// <summary>
    /// Закладка [Сотрудники]
    /// Идентификатор [4f5c5134-d8eb-49d7-8c6c-3497ef5a5ea8]
    /// </summary>
    [Display("Сотрудники")]
    public BarsUpPageCmp_Tab_Сотрудники Сотрудники { get; internal set; }

    /// <summary>
    /// Закладка [Программы финансирования]
    /// Идентификатор [f0117339-7df9-4b78-acc3-d4197cd20b4e]
    /// </summary>
    [Display("Программы финансирования")]
    public BarsUpPageCmp_Tab_Программы_финансирования Программы_финансирования { get; internal set; }

    /// <summary>
    /// Закладка [Профили]
    /// Идентификатор [b6393dc2-68e1-4fd9-a36c-542e83b780a1]
    /// </summary>
    [Display("Профили")]
    public BarsUpPageCmp_Tab_Профили Профили { get; internal set; }

    /// <summary>
    /// Закладка [Взаимосвязанные организации]
    /// Идентификатор [1c7839c6-8f66-4c90-84dd-0201796e82f9]
    /// </summary>
    [Display("Взаимосвязанные организации")]
    public BarsUpPageCmp_Tab_Взаимосвязанные_организации Взаимосвязанные_организации { get; internal set; }
    protected override void Initialize() {
        base.Initialize();
        Контакты = Down<BarsUpPageCmp_Tab_Контакты>("[rmsUid=47e31e2d-1c03-425a-bec3-eddf7c188db7]");
        Подразделения = Down<BarsUpPageCmp_Tab_Подразделения>("[rmsUid=a43cf966-c60e-4eb7-9dc3-4d3ac4be2ab3]");
        Сотрудники = Down<BarsUpPageCmp_Tab_Сотрудники>("[rmsUid=4f5c5134-d8eb-49d7-8c6c-3497ef5a5ea8]");
        Программы_финансирования = Down<BarsUpPageCmp_Tab_Программы_финансирования>("[rmsUid=f0117339-7df9-4b78-acc3-d4197cd20b4e]");
        Профили = Down<BarsUpPageCmp_Tab_Профили>("[rmsUid=b6393dc2-68e1-4fd9-a36c-542e83b780a1]");
        Взаимосвязанные_организации = Down<BarsUpPageCmp_Tab_Взаимосвязанные_организации>("[rmsUid=1c7839c6-8f66-4c90-84dd-0201796e82f9]");
    }

    public class BarsUpPageCmp_Tab_Контакты : ExtJsTab {
        public BarsUpPageCmp_Tab_Контакты(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Контакты(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Контакты.Организация]
        /// Идентификатор [542d988f-c13a-4abf-9773-8f7b7bddc79b]
        /// </summary>
        [Display("Контакты.Организация")]
        public OrganizationContactsListPageObject Контакты_Организация { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Контакты_Организация = Down<OrganizationContactsListPageObject>("[rmsUid=542d988f-c13a-4abf-9773-8f7b7bddc79b]");
        }
    }


    public class BarsUpPageCmp_Tab_Подразделения : ExtJsTab {
        public BarsUpPageCmp_Tab_Подразделения(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Подразделения(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Подразделения.Организация]
        /// Идентификатор [2bd09945-7b59-431c-b05a-a90003098ec5]
        /// </summary>
        [Display("Подразделения.Организация")]
        public DepartmentsListPageObject Подразделения_Организация { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Подразделения_Организация = Down<DepartmentsListPageObject>("[rmsUid=2bd09945-7b59-431c-b05a-a90003098ec5]");
        }
    }


    public class BarsUpPageCmp_Tab_Сотрудники : ExtJsTab {
        public BarsUpPageCmp_Tab_Сотрудники(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Сотрудники(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Сотрудники.Организация]
        /// Идентификатор [dc0d23ec-305f-4892-b9b6-0deef3a9385b]
        /// </summary>
        [Display("Сотрудники.Организация")]
        public StaffListPageObject Сотрудники_Организация { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Сотрудники_Организация = Down<StaffListPageObject>("[rmsUid=dc0d23ec-305f-4892-b9b6-0deef3a9385b]");
        }
    }


    public class BarsUpPageCmp_Tab_Программы_финансирования : ExtJsTab {
        public BarsUpPageCmp_Tab_Программы_финансирования(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Программы_финансирования(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Программы.Организация]
        /// Идентификатор [fc58811c-44cb-48aa-879b-a16438ac1388]
        /// </summary>
        [Display("Программы.Организация")]
        public OrganizationFundingProgramsListPageObject Программы_Организация { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Программы_Организация = Down<OrganizationFundingProgramsListPageObject>("[rmsUid=fc58811c-44cb-48aa-879b-a16438ac1388]");
        }
    }


    public class BarsUpPageCmp_Tab_Профили : ExtJsTab {
        public BarsUpPageCmp_Tab_Профили(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Профили(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Профили.Организация]
        /// Идентификатор [8dbc5025-53e5-4b7d-9d21-63b2801b3038]
        /// </summary>
        [Display("Профили.Организация")]
        public OrganizationProfilesListPageObject Профили_Организация { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Профили_Организация = Down<OrganizationProfilesListPageObject>("[rmsUid=8dbc5025-53e5-4b7d-9d21-63b2801b3038]");
        }
    }


    public class BarsUpPageCmp_Tab_Взаимосвязанные_организации : ExtJsTab {
        public BarsUpPageCmp_Tab_Взаимосвязанные_организации(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Взаимосвязанные_организации(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Связанные организации.Организация]
        /// Идентификатор [4b7447e6-7130-4b6c-94de-2178565fa862]
        /// </summary>
        [Display("Связанные организации.Организация")]
        public RelatedOrganizationsListPageObject Связанные_организации_Организация { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Связанные_организации_Организация = Down<RelatedOrganizationsListPageObject>("[rmsUid=4b7447e6-7130-4b6c-94de-2178565fa862]");
        }
    }

}

    }
}