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
    /// Описание формы 'Должность подразделения' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-departmentspositionseditor")]
    [Display("Редактор [Должность подразделения]")]
    public class DepartmentsPositionsEditorPageObject : BarsUpGeneratedEditorView<DepartmentsPositionsEditorModel>
    {  
        public DepartmentsPositionsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public DepartmentsPositionsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Подразделение]
/// Идентификатор [2c050fdb-4916-4e3d-b8da-508462e9600a]
/// Поле сущности: Должности подразделения.Подразделение
/// </summary>
[Display("Подразделение")]
public BarsUpSelectorField<DepartmentsListModel> Подразделение { get; internal set; }

/// <summary>
/// Выбор из справочника [Вид]
/// Идентификатор [6bebd2c4-d428-4333-8a9d-2357a439a91b]
/// Поле сущности: Должности подразделения.Вид
/// </summary>
[Display("Вид")]
public BarsUpSelectorField<PositionsTypesListModel> Вид { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Должность]
/// Идентификатор [a3a81165-7954-4dcd-9e6e-e8da0f83eec2]
/// Поле сущности: Должности подразделения.Должность
/// </summary>
[Display("Должность")]
public ExtJsFormField<System.String> Должность { get; internal set; }

/// <summary>
/// Панель закладок [Панель закладок]
/// Идентификатор [81d8bd32-b275-4a56-922e-1253710ee6c8]
/// </summary>
[Display("Панель закладок")]
public BarsUpPageCmp_TabPanel_Панель_закладок Панель_закладок { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Подразделение = Down<BarsUpSelectorField<DepartmentsListModel>>("[rmsUid=2c050fdb-4916-4e3d-b8da-508462e9600a]");
Вид = Down<BarsUpSelectorField<PositionsTypesListModel>>("[rmsUid=6bebd2c4-d428-4333-8a9d-2357a439a91b]");
Должность = Down<ExtJsFormField<System.String>>("[rmsUid=a3a81165-7954-4dcd-9e6e-e8da0f83eec2]");
Панель_закладок = Down<BarsUpPageCmp_TabPanel_Панель_закладок>("[rmsUid=81d8bd32-b275-4a56-922e-1253710ee6c8]");
        }

        
public class BarsUpPageCmp_TabPanel_Панель_закладок : ExtJsTabPanel {
    public BarsUpPageCmp_TabPanel_Панель_закладок(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public BarsUpPageCmp_TabPanel_Панель_закладок(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

    /// <summary>
    /// Закладка [Сотрудники]
    /// Идентификатор [61b36cb0-8751-48ab-9b52-d86fc01814b2]
    /// </summary>
    [Display("Сотрудники")]
    public BarsUpPageCmp_Tab_Сотрудники Сотрудники { get; internal set; }
    protected override void Initialize() {
        base.Initialize();
        Сотрудники = Down<BarsUpPageCmp_Tab_Сотрудники>("[rmsUid=61b36cb0-8751-48ab-9b52-d86fc01814b2]");
    }

    public class BarsUpPageCmp_Tab_Сотрудники : ExtJsTab {
        public BarsUpPageCmp_Tab_Сотрудники(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Сотрудники(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Занимаемые должности.Подразделение]
        /// Идентификатор [c2df756f-e4df-47c5-b7fd-a26e39693337]
        /// </summary>
        [Display("Занимаемые должности.Подразделение")]
        public CurrentPositionsDepartmentsListPageObject Занимаемые_должности_Подразделение { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Занимаемые_должности_Подразделение = Down<CurrentPositionsDepartmentsListPageObject>("[rmsUid=c2df756f-e4df-47c5-b7fd-a26e39693337]");
        }
    }

}

    }
}