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
    /// Описание формы 'Заказ' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-orderseditor")]
    [Display("Редактор [Заказ]")]
    public class OrdersEditorPageObject : BarsUpGeneratedEditorView<OrdersEditorModel>
    {  
        public OrdersEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrdersEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Однострочный редактор текста [Номер]
/// Идентификатор [90d74d06-9e1c-4bae-91cc-f8a54ec861fd]
/// Поле сущности: Заказы.Номер
/// </summary>
[Display("Номер")]
public ExtJsFormField<System.String> Номер { get; internal set; }

/// <summary>
/// Поле ввода даты [Дата]
/// Идентификатор [b477d19c-aee8-4e02-b1d0-839b34b76598]
/// Поле сущности: Заказы.Дата
/// </summary>
[Display("Дата")]
public ExtJsFormField<System.DateTime?> Дата { get; internal set; }

/// <summary>
/// Выбор из справочника [Заказчик]
/// Идентификатор [1adc66bb-f2a6-42f2-ad47-bca4ec7f7b25]
/// Поле сущности: Заказы.Заказчик
/// </summary>
[Display("Заказчик")]
public BarsUpSelectorField<OrganizationProfilesListModel> Заказчик { get; internal set; }

/// <summary>
/// Выбор из справочника [Менеджер]
/// Идентификатор [f42a0cdf-dc4b-4211-a0ef-e4652a986169]
/// Поле сущности: Заказы.Менеджер
/// </summary>
[Display("Менеджер")]
public BarsUpSelectorField<StaffListModel> Менеджер { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [67de81d6-9c11-46ab-b862-7c352b920943]
/// Поле сущности: Заказы.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }

/// <summary>
/// Панель закладок [Панель закладок]
/// Идентификатор [ad1048a9-1e9a-4773-8578-39eb33d882d9]
/// </summary>
[Display("Панель закладок")]
public BarsUpPageCmp_TabPanel_Панель_закладок Панель_закладок { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Номер = Down<ExtJsFormField<System.String>>("[rmsUid=90d74d06-9e1c-4bae-91cc-f8a54ec861fd]");
Дата = Down<ExtJsFormField<System.DateTime?>>("[rmsUid=b477d19c-aee8-4e02-b1d0-839b34b76598]");
Заказчик = Down<BarsUpSelectorField<OrganizationProfilesListModel>>("[rmsUid=1adc66bb-f2a6-42f2-ad47-bca4ec7f7b25]");
Менеджер = Down<BarsUpSelectorField<StaffListModel>>("[rmsUid=f42a0cdf-dc4b-4211-a0ef-e4652a986169]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=67de81d6-9c11-46ab-b862-7c352b920943]");
Панель_закладок = Down<BarsUpPageCmp_TabPanel_Панель_закладок>("[rmsUid=ad1048a9-1e9a-4773-8578-39eb33d882d9]");
        }

        
public class BarsUpPageCmp_TabPanel_Панель_закладок : ExtJsTabPanel {
    public BarsUpPageCmp_TabPanel_Панель_закладок(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public BarsUpPageCmp_TabPanel_Панель_закладок(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

    /// <summary>
    /// Закладка [Объекты]
    /// Идентификатор [83d83d1d-cbc7-4f04-984d-ec9d7f6cf67b]
    /// </summary>
    [Display("Объекты")]
    public BarsUpPageCmp_Tab_Объекты Объекты { get; internal set; }

    /// <summary>
    /// Закладка [Организации]
    /// Идентификатор [26936da3-4bd0-42a9-9303-1cd4b87dbdaa]
    /// </summary>
    [Display("Организации")]
    public BarsUpPageCmp_Tab_Организации Организации { get; internal set; }
    protected override void Initialize() {
        base.Initialize();
        Объекты = Down<BarsUpPageCmp_Tab_Объекты>("[rmsUid=83d83d1d-cbc7-4f04-984d-ec9d7f6cf67b]");
        Организации = Down<BarsUpPageCmp_Tab_Организации>("[rmsUid=26936da3-4bd0-42a9-9303-1cd4b87dbdaa]");
    }

    public class BarsUpPageCmp_Tab_Объекты : ExtJsTab {
        public BarsUpPageCmp_Tab_Объекты(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Объекты(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Объекты.Заказа]
        /// Идентификатор [56478bd5-eb79-47aa-8264-408553cbd463]
        /// </summary>
        [Display("Объекты.Заказа")]
        public ObjectsOrdersListPageObject Объекты_Заказа { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Объекты_Заказа = Down<ObjectsOrdersListPageObject>("[rmsUid=56478bd5-eb79-47aa-8264-408553cbd463]");
        }
    }


    public class BarsUpPageCmp_Tab_Организации : ExtJsTab {
        public BarsUpPageCmp_Tab_Организации(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Организации(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Организации.Заказ]
        /// Идентификатор [f8b64983-4cce-4108-8faa-aeee15bbfbd3]
        /// </summary>
        [Display("Организации.Заказ")]
        public OrderOrganizationListPageObject Организации_Заказ { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Организации_Заказ = Down<OrderOrganizationListPageObject>("[rmsUid=f8b64983-4cce-4108-8faa-aeee15bbfbd3]");
        }
    }

}

    }
}