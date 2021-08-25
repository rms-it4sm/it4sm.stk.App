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
    /// Описание формы '' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-objectsorderslistmultiaddbyzakazeditor")]
    [Display("Редактор []")]
    public class ObjectsOrdersListMultiAddByZakazEditorPageObject : BarsUpGeneratedEditorView<ObjectsOrdersListMultiAddByZakazEditorModel>
    {  
        public ObjectsOrdersListMultiAddByZakazEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public ObjectsOrdersListMultiAddByZakazEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Заказ]
/// Идентификатор [d1f930be-a7aa-6faa-bc4f-1ee7902ff55e]
/// Поле сущности: Заказы Объекты.Заказ
/// </summary>
[Display("Заказ")]
public BarsUpSelectorField<OrdersListModel> Заказ { get; internal set; }

/// <summary>
/// Реестр []
/// Идентификатор [03d0bd85-eabf-8530-3dcd-c4ae446780dc]
/// </summary>
[Display("Реестр_03d0bd85eabf85303dcdc4ae446780dc")]
public OrdersObjectsList2PageObject Реестр { get; internal set; }

/// <summary>
/// Выбор из справочника [Объект]
/// Идентификатор [896813d8-7b87-e74b-2185-d568ade68d51]
/// Поле сущности: Заказы Объекты.Объект
/// </summary>
[Display("Объект")]
public BarsUpSelectorField<OrdersObjectsListModel> Объект { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Заказ = Down<BarsUpSelectorField<OrdersListModel>>("[rmsUid=d1f930be-a7aa-6faa-bc4f-1ee7902ff55e]");
Реестр = Down<OrdersObjectsList2PageObject>("[rmsUid=03d0bd85-eabf-8530-3dcd-c4ae446780dc]");
Объект = Down<BarsUpSelectorField<OrdersObjectsListModel>>("[rmsUid=896813d8-7b87-e74b-2185-d568ade68d51]");
        }

            }
}