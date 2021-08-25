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
    [ExtJsXType("rms-typesworktypesobjectslistmultiaddbyobjecttypeeditor")]
    [Display("Редактор []")]
    public class TypesWorkTypesObjectsListMultiAddByObjectTypeEditorPageObject : BarsUpGeneratedEditorView<TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel>
    {  
        public TypesWorkTypesObjectsListMultiAddByObjectTypeEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public TypesWorkTypesObjectsListMultiAddByObjectTypeEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Тип объекта]
/// Идентификатор [ebdd5fe9-9210-f16b-7757-e1f143f913ff]
/// Поле сущности: Виды работ.Типы объектов.Тип объекта
/// </summary>
[Display("Тип объекта")]
public BarsUpSelectorField<ObjectsTypesListModel> Тип_объекта { get; internal set; }

/// <summary>
/// Реестр []
/// Идентификатор [911df279-1631-50bf-34e8-29f9e4fd4972]
/// </summary>
[Display("Реестр_911df279163150bf34e829f9e4fd4972")]
public WorksTypesListPageObject Реестр { get; internal set; }

/// <summary>
/// Выбор из справочника [Вид работы]
/// Идентификатор [1399e726-b041-b66e-68e9-9f46ac1eeba5]
/// Поле сущности: Виды работ.Типы объектов.Вид работы
/// </summary>
[Display("Вид работы")]
public BarsUpSelectorField<WorksTypesListModel> Вид_работы { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Тип_объекта = Down<BarsUpSelectorField<ObjectsTypesListModel>>("[rmsUid=ebdd5fe9-9210-f16b-7757-e1f143f913ff]");
Реестр = Down<WorksTypesListPageObject>("[rmsUid=911df279-1631-50bf-34e8-29f9e4fd4972]");
Вид_работы = Down<BarsUpSelectorField<WorksTypesListModel>>("[rmsUid=1399e726-b041-b66e-68e9-9f46ac1eeba5]");
        }

            }
}