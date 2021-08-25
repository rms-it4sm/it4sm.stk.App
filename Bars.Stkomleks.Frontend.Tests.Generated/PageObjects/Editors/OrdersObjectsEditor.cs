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
    /// Описание формы 'Объект.Создание' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-ordersobjectseditor")]
    [Display("Редактор [Объект.Создание]")]
    public class OrdersObjectsEditorPageObject : BarsUpGeneratedEditorView<OrdersObjectsEditorModel>
    {  
        public OrdersObjectsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrdersObjectsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Заказ]
/// Идентификатор [faa15d75-45a3-402c-ba44-7328200f8326]
/// Поле сущности: Объекты.Заказ
/// </summary>
[Display("Заказ")]
public BarsUpSelectorField<OrdersListModel> Заказ { get; internal set; }

/// <summary>
/// Выбор из справочника [Тип]
/// Идентификатор [0f18129a-9cc4-4822-9706-7b4c8d14676c]
/// Поле сущности: Объекты.Тип
/// </summary>
[Display("Тип")]
public BarsUpSelectorField<ObjectsTypesListModel> Тип { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Наименование]
/// Идентификатор [150c18a2-54b7-4d5b-b5fb-b2d3ae7ab13c]
/// Поле сущности: Объекты.Наименование
/// </summary>
[Display("Наименование")]
public ExtJsFormField<System.String> Наименование { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [c2f57d34-eddd-48ee-b6f6-208376814756]
/// Поле сущности: Объекты.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }

/// <summary>
/// Скрытое поле [Lon]
/// Идентификатор [8bb2e4f1-bf2d-4361-9606-af21cceb166a]
/// Поле сущности: Объекты.Lon
/// </summary>
[Display("Lon")]
public ExtJsFormField<System.String> Lon { get; internal set; }

/// <summary>
/// Скрытое поле [Lat]
/// Идентификатор [62f42c68-2733-4d24-b244-269f4f5d73be]
/// Поле сущности: Объекты.Lat
/// </summary>
[Display("Lat")]
public ExtJsFormField<System.String> Lat { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Заказ = Down<BarsUpSelectorField<OrdersListModel>>("[rmsUid=faa15d75-45a3-402c-ba44-7328200f8326]");
Тип = Down<BarsUpSelectorField<ObjectsTypesListModel>>("[rmsUid=0f18129a-9cc4-4822-9706-7b4c8d14676c]");
Наименование = Down<ExtJsFormField<System.String>>("[rmsUid=150c18a2-54b7-4d5b-b5fb-b2d3ae7ab13c]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=c2f57d34-eddd-48ee-b6f6-208376814756]");
Lon = Down<ExtJsFormField<System.String>>("[rmsUid=8bb2e4f1-bf2d-4361-9606-af21cceb166a]");
Lat = Down<ExtJsFormField<System.String>>("[rmsUid=62f42c68-2733-4d24-b244-269f4f5d73be]");
        }

            }
}