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
    /// Описание формы 'Элемент объекта' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-objectproductseditor")]
    [Display("Редактор [Элемент объекта]")]
    public class ObjectProductsEditorPageObject : BarsUpGeneratedEditorView<ObjectProductsEditorModel>
    {  
        public ObjectProductsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public ObjectProductsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Объект]
/// Идентификатор [3cf94cb1-42e9-4254-afca-c28c08e691ec]
/// Поле сущности: Спецификация объекта.Объект
/// </summary>
[Display("Объект")]
public BarsUpSelectorField<OrdersObjectsListModel> Объект { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Код]
/// Идентификатор [cbc724ed-f3cb-4bdf-a0c4-ae359b86385d]
/// Поле сущности: Спецификация объекта.Код элемента
/// </summary>
[Display("Код")]
public ExtJsFormField<System.String> Код { get; internal set; }

/// <summary>
/// Выбор из справочника [Тип элемента]
/// Идентификатор [43f0269e-c14c-4220-acbd-88f6319e957d]
/// Поле сущности: Спецификация объекта.Тип элемента
/// </summary>
[Display("Тип элемента")]
public BarsUpSelectorField<ProductsTypesListModel> Тип_элемента { get; internal set; }

/// <summary>
/// Поле ввода числа [Количество]
/// Идентификатор [dbd3ce47-2b79-4a9b-834c-4201d5ad71a1]
/// Поле сущности: Спецификация объекта.Количество
/// </summary>
[Display("Количество")]
public ExtJsFormField<System.Double?> Количество { get; internal set; }

/// <summary>
/// Выбор из справочника [Ед. изм.]
/// Идентификатор [ae31252f-4c9d-47e3-a3b3-ea28b0c91aa4]
/// Поле сущности: Спецификация объекта.Ед. изм.
/// </summary>
[Display("Ед. изм.")]
public BarsUpSelectorField<UnitMeasureListModel> Ед_изм { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [10141fa8-9345-49e2-9689-d39c659d81a4]
/// Поле сущности: Спецификация объекта.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }

/// <summary>
/// Реестр [Товары]
/// Идентификатор [f45b14ca-05ee-4b0a-9f79-58bd22eadf0f]
/// </summary>
[Display("Товары")]
public ProductsListPageObject Товары { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Объект = Down<BarsUpSelectorField<OrdersObjectsListModel>>("[rmsUid=3cf94cb1-42e9-4254-afca-c28c08e691ec]");
Код = Down<ExtJsFormField<System.String>>("[rmsUid=cbc724ed-f3cb-4bdf-a0c4-ae359b86385d]");
Тип_элемента = Down<BarsUpSelectorField<ProductsTypesListModel>>("[rmsUid=43f0269e-c14c-4220-acbd-88f6319e957d]");
Количество = Down<ExtJsFormField<System.Double?>>("[rmsUid=dbd3ce47-2b79-4a9b-834c-4201d5ad71a1]");
Ед_изм = Down<BarsUpSelectorField<UnitMeasureListModel>>("[rmsUid=ae31252f-4c9d-47e3-a3b3-ea28b0c91aa4]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=10141fa8-9345-49e2-9689-d39c659d81a4]");
Товары = Down<ProductsListPageObject>("[rmsUid=f45b14ca-05ee-4b0a-9f79-58bd22eadf0f]");
        }

            }
}