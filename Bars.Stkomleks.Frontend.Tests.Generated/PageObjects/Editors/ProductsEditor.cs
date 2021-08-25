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
    /// Описание формы 'Комплектация' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-productseditor")]
    [Display("Редактор [Комплектация]")]
    public class ProductsEditorPageObject : BarsUpGeneratedEditorView<ProductsEditorModel>
    {  
        public ProductsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public ProductsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Спецификация объекта]
/// Идентификатор [a4fcea41-0bd7-4e57-b40f-84be3a26bdd6]
/// Поле сущности: Комплектация элементов объектов.Спецификация объекта
/// </summary>
[Display("Спецификация объекта")]
public BarsUpSelectorField<ObjectProductsListModel> Спецификация_объекта { get; internal set; }

/// <summary>
/// Выбор из справочника [Поставщик]
/// Идентификатор [5c01b211-328b-4411-af83-92a396fb1415]
/// Поле сущности: Комплектация элементов объектов.Поставщик
/// </summary>
[Display("Поставщик")]
public BarsUpSelectorField<OrganizationProfilesList2Model> Поставщик { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Товар]
/// Идентификатор [698065ac-da84-461b-954d-e6bf595e4b6a]
/// Поле сущности: Комплектация элементов объектов.Товар
/// </summary>
[Display("Товар")]
public ExtJsFormField<System.String> Товар { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Артикул]
/// Идентификатор [134ea4b8-c2e4-4074-ae90-7f31bb973ffe]
/// Поле сущности: Комплектация элементов объектов.Артикул
/// </summary>
[Display("Артикул")]
public ExtJsFormField<System.String> Артикул { get; internal set; }

/// <summary>
/// Поле ввода числа [Количество]
/// Идентификатор [b4bf1062-5fcf-4b02-b950-931c203c39e1]
/// Поле сущности: Комплектация элементов объектов.Количество
/// </summary>
[Display("Количество")]
public ExtJsFormField<System.Double?> Количество { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [5513760a-45b7-40bf-a245-aab20206ea14]
/// Поле сущности: Комплектация элементов объектов.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Спецификация_объекта = Down<BarsUpSelectorField<ObjectProductsListModel>>("[rmsUid=a4fcea41-0bd7-4e57-b40f-84be3a26bdd6]");
Поставщик = Down<BarsUpSelectorField<OrganizationProfilesList2Model>>("[rmsUid=5c01b211-328b-4411-af83-92a396fb1415]");
Товар = Down<ExtJsFormField<System.String>>("[rmsUid=698065ac-da84-461b-954d-e6bf595e4b6a]");
Артикул = Down<ExtJsFormField<System.String>>("[rmsUid=134ea4b8-c2e4-4074-ae90-7f31bb973ffe]");
Количество = Down<ExtJsFormField<System.Double?>>("[rmsUid=b4bf1062-5fcf-4b02-b950-931c203c39e1]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=5513760a-45b7-40bf-a245-aab20206ea14]");
        }

            }
}