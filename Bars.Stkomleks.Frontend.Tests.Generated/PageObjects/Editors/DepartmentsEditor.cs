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
    /// Описание формы 'Подразделение' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-departmentseditor")]
    [Display("Редактор [Подразделение]")]
    public class DepartmentsEditorPageObject : BarsUpGeneratedEditorView<DepartmentsEditorModel>
    {  
        public DepartmentsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public DepartmentsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Организация]
/// Идентификатор [90129f07-21b7-4503-91d6-ca0217b398e0]
/// Поле сущности: Подразделения.Организация
/// </summary>
[Display("Организация")]
public BarsUpSelectorField<OrganizationListModel> Организация { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Наименование]
/// Идентификатор [4ca0d1ef-3e33-4fdc-b1ca-99e934fc0588]
/// Поле сущности: Подразделения.Наименование
/// </summary>
[Display("Наименование")]
public ExtJsFormField<System.String> Наименование { get; internal set; }

/// <summary>
/// Выбор из справочника [Вид]
/// Идентификатор [53e57f8a-2b2d-4fde-92bd-2b7d4ebdad54]
/// Поле сущности: Подразделения.Вид
/// </summary>
[Display("Вид")]
public BarsUpSelectorField<DepartmentsTypeListModel> Вид { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [cf3778c4-1dd0-40bd-b58d-a56e2cc1dc07]
/// Поле сущности: Подразделения.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }

/// <summary>
/// Панель закладок [Панель закладок]
/// Идентификатор [b2dc4bf2-6d28-4279-9cfe-2ad2fefc4775]
/// </summary>
[Display("Панель закладок")]
public BarsUpPageCmp_TabPanel_Панель_закладок Панель_закладок { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Организация = Down<BarsUpSelectorField<OrganizationListModel>>("[rmsUid=90129f07-21b7-4503-91d6-ca0217b398e0]");
Наименование = Down<ExtJsFormField<System.String>>("[rmsUid=4ca0d1ef-3e33-4fdc-b1ca-99e934fc0588]");
Вид = Down<BarsUpSelectorField<DepartmentsTypeListModel>>("[rmsUid=53e57f8a-2b2d-4fde-92bd-2b7d4ebdad54]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=cf3778c4-1dd0-40bd-b58d-a56e2cc1dc07]");
Панель_закладок = Down<BarsUpPageCmp_TabPanel_Панель_закладок>("[rmsUid=b2dc4bf2-6d28-4279-9cfe-2ad2fefc4775]");
        }

        
public class BarsUpPageCmp_TabPanel_Панель_закладок : ExtJsTabPanel {
    public BarsUpPageCmp_TabPanel_Панель_закладок(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public BarsUpPageCmp_TabPanel_Панель_закладок(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

    /// <summary>
    /// Закладка [Должности]
    /// Идентификатор [42134958-1749-4f8b-a485-ed2b1d96d3b8]
    /// </summary>
    [Display("Должности")]
    public BarsUpPageCmp_Tab_Должности Должности { get; internal set; }
    protected override void Initialize() {
        base.Initialize();
        Должности = Down<BarsUpPageCmp_Tab_Должности>("[rmsUid=42134958-1749-4f8b-a485-ed2b1d96d3b8]");
    }

    public class BarsUpPageCmp_Tab_Должности : ExtJsTab {
        public BarsUpPageCmp_Tab_Должности(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Должности(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Должности.Подразделение]
        /// Идентификатор [20ff84c6-cf96-4b38-8267-bd951a6cb743]
        /// </summary>
        [Display("Должности.Подразделение")]
        public DepartmentsPositionsListPageObject Должности_Подразделение { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Должности_Подразделение = Down<DepartmentsPositionsListPageObject>("[rmsUid=20ff84c6-cf96-4b38-8267-bd951a6cb743]");
        }
    }

}

    }
}