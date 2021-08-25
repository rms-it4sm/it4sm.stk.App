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
    /// Описание формы 'Объект.Изменение' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-ordersobjectseditor_copy_0")]
    [Display("Редактор [Объект.Изменение]")]
    public class OrdersObjectsEditor_Copy_0PageObject : BarsUpGeneratedEditorView<OrdersObjectsEditor_Copy_0Model>
    {  
        public OrdersObjectsEditor_Copy_0PageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrdersObjectsEditor_Copy_0PageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Вложенная форма [Объект.Создание]
/// Идентификатор [7ac403e4-faf4-4360-9f50-df22ba53258b]
/// </summary>
[Display("Объект.Создание")]
public OrdersObjectsEditorPageObject Объект_Создание { get; internal set; }

/// <summary>
/// Панель закладок [Панель закладок]
/// Идентификатор [a7490370-2042-43eb-8cda-c3a847bab32c]
/// </summary>
[Display("Панель закладок")]
public BarsUpPageCmp_TabPanel_Панель_закладок Панель_закладок { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Объект_Создание = Down<OrdersObjectsEditorPageObject>("[rmsUid=7ac403e4-faf4-4360-9f50-df22ba53258b]");
Панель_закладок = Down<BarsUpPageCmp_TabPanel_Панель_закладок>("[rmsUid=a7490370-2042-43eb-8cda-c3a847bab32c]");
        }

        
public class BarsUpPageCmp_TabPanel_Панель_закладок : ExtJsTabPanel {
    public BarsUpPageCmp_TabPanel_Панель_закладок(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public BarsUpPageCmp_TabPanel_Панель_закладок(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

    /// <summary>
    /// Закладка [Заказы]
    /// Идентификатор [20003a88-1d05-488d-b6d4-45b2a48206ec]
    /// </summary>
    [Display("Заказы")]
    public BarsUpPageCmp_Tab_Заказы Заказы { get; internal set; }

    /// <summary>
    /// Закладка [Спецификация]
    /// Идентификатор [099e3673-e4c9-493b-a2ec-380075f89c64]
    /// </summary>
    [Display("Спецификация")]
    public BarsUpPageCmp_Tab_Спецификация Спецификация { get; internal set; }

    /// <summary>
    /// Закладка [Специалисты]
    /// Идентификатор [3ae9ca09-7bf8-42a2-a452-da2bd2d42b10]
    /// </summary>
    [Display("Специалисты")]
    public BarsUpPageCmp_Tab_Специалисты Специалисты { get; internal set; }

    /// <summary>
    /// Закладка [Работы]
    /// Идентификатор [870c57c5-c968-406e-ae85-a3337b5f35ca]
    /// </summary>
    [Display("Работы")]
    public BarsUpPageCmp_Tab_Работы Работы { get; internal set; }

    /// <summary>
    /// Закладка [Документы]
    /// Идентификатор [9e93016b-e70e-4459-8a93-357650944dd1]
    /// </summary>
    [Display("Документы")]
    public BarsUpPageCmp_Tab_Документы Документы { get; internal set; }
    protected override void Initialize() {
        base.Initialize();
        Заказы = Down<BarsUpPageCmp_Tab_Заказы>("[rmsUid=20003a88-1d05-488d-b6d4-45b2a48206ec]");
        Спецификация = Down<BarsUpPageCmp_Tab_Спецификация>("[rmsUid=099e3673-e4c9-493b-a2ec-380075f89c64]");
        Специалисты = Down<BarsUpPageCmp_Tab_Специалисты>("[rmsUid=3ae9ca09-7bf8-42a2-a452-da2bd2d42b10]");
        Работы = Down<BarsUpPageCmp_Tab_Работы>("[rmsUid=870c57c5-c968-406e-ae85-a3337b5f35ca]");
        Документы = Down<BarsUpPageCmp_Tab_Документы>("[rmsUid=9e93016b-e70e-4459-8a93-357650944dd1]");
    }

    public class BarsUpPageCmp_Tab_Заказы : ExtJsTab {
        public BarsUpPageCmp_Tab_Заказы(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Заказы(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Заказы.Объект]
        /// Идентификатор [59e97e65-fbf0-44b6-8e99-3d95e98e21e3]
        /// </summary>
        [Display("Заказы.Объект")]
        public ObjectsOrdersList2PageObject Заказы_Объект { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Заказы_Объект = Down<ObjectsOrdersList2PageObject>("[rmsUid=59e97e65-fbf0-44b6-8e99-3d95e98e21e3]");
        }
    }


    public class BarsUpPageCmp_Tab_Спецификация : ExtJsTab {
        public BarsUpPageCmp_Tab_Спецификация(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Спецификация(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Продукция.Объект]
        /// Идентификатор [fabd707c-82b8-44ed-9cdd-260f478ef401]
        /// </summary>
        [Display("Продукция.Объект")]
        public ObjectProductsListPageObject Продукция_Объект { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Продукция_Объект = Down<ObjectProductsListPageObject>("[rmsUid=fabd707c-82b8-44ed-9cdd-260f478ef401]");
        }
    }


    public class BarsUpPageCmp_Tab_Специалисты : ExtJsTab {
        public BarsUpPageCmp_Tab_Специалисты(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Специалисты(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Состав специалистов.Объекта]
        /// Идентификатор [33c89400-fcc8-47e0-bf6d-14ed0d4f4855]
        /// </summary>
        [Display("Состав специалистов.Объекта")]
        public CompositionObjectSpecialistsListPageObject Состав_специалистов_Объекта { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Состав_специалистов_Объекта = Down<CompositionObjectSpecialistsListPageObject>("[rmsUid=33c89400-fcc8-47e0-bf6d-14ed0d4f4855]");
        }
    }


    public class BarsUpPageCmp_Tab_Работы : ExtJsTab {
        public BarsUpPageCmp_Tab_Работы(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Работы(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Работы.Объект]
        /// Идентификатор [78b27a1d-5b0d-49af-97e1-ccb97222cdba]
        /// </summary>
        [Display("Работы.Объект")]
        public CompositionWorksObjectsListPageObject Работы_Объект { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Работы_Объект = Down<CompositionWorksObjectsListPageObject>("[rmsUid=78b27a1d-5b0d-49af-97e1-ccb97222cdba]");
        }
    }


    public class BarsUpPageCmp_Tab_Документы : ExtJsTab {
        public BarsUpPageCmp_Tab_Документы(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
        public BarsUpPageCmp_Tab_Документы(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    
        /// <summary>
        /// Реестр [Документы.Объект]
        /// Идентификатор [34547090-ec5b-4be1-b5eb-6771419a6a2b]
        /// </summary>
        [Display("Документы.Объект")]
        public ObjectsDocumentsListPageObject Документы_Объект { get; internal set; }
        protected override void Initialize() {
            base.Initialize();
            Документы_Объект = Down<ObjectsDocumentsListPageObject>("[rmsUid=34547090-ec5b-4be1-b5eb-6771419a6a2b]");
        }
    }

}

    }
}