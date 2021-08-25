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
    /// Описание формы 'Объект заказа' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-objectsorderseditor")]
    [Display("Редактор [Объект заказа]")]
    public class ObjectsOrdersEditorPageObject : BarsUpGeneratedEditorView<ObjectsOrdersEditorModel>
    {  
        public ObjectsOrdersEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public ObjectsOrdersEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Заказ]
/// Идентификатор [f974f997-c8e5-4942-82dd-c6ce4a07669e]
/// Поле сущности: Заказы Объекты.Заказ
/// </summary>
[Display("Заказ")]
public BarsUpSelectorField<OrdersListModel> Заказ { get; internal set; }

/// <summary>
/// Форма редактирования поля [Объект.Создание]
/// Идентификатор [3d9f7801-7c6c-436e-a4b9-c1019a944061]
/// </summary>
[Display("Объект.Создание")]
public OrdersObjectsEditorPageObject Объект_Создание { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Заказ = Down<BarsUpSelectorField<OrdersListModel>>("[rmsUid=f974f997-c8e5-4942-82dd-c6ce4a07669e]");
Объект_Создание = Down<OrdersObjectsEditorPageObject>("[rmsUid=3d9f7801-7c6c-436e-a4b9-c1019a944061]");
        }

            }
}