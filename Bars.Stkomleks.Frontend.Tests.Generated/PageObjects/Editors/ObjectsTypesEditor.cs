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
    /// Описание формы 'Тип объекта' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-objectstypeseditor")]
    [Display("Редактор [Тип объекта]")]
    public class ObjectsTypesEditorPageObject : BarsUpGeneratedEditorView<ObjectsTypesEditorModel>
    {  
        public ObjectsTypesEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public ObjectsTypesEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Однострочный редактор текста [Наименование]
/// Идентификатор [a543d799-f327-40a3-b39f-c0a7e2dd658b]
/// Поле сущности: Типы объектов.Наименование
/// </summary>
[Display("Наименование")]
public ExtJsFormField<System.String> Наименование { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Иконка]
/// Идентификатор [03c3dd4d-f056-4e5a-b0dd-47fd23e69b09]
/// Поле сущности: Типы объектов.Иконка
/// </summary>
[Display("Иконка")]
public ExtJsFormField<System.String> Иконка { get; internal set; }

/// <summary>
/// Выбор цвета [Цвет]
/// Идентификатор [cf8e7da9-9ef1-41ff-90ce-f71ec541f58e]
/// Поле сущности: Типы объектов.Цвет
/// </summary>
[Display("Цвет")]
public ExtJsFormField<System.String> Цвет { get; internal set; }

/// <summary>
/// Реестр [Виды работ]
/// Идентификатор [d9897e33-543c-44b4-a708-0f4bb84082c3]
/// </summary>
[Display("Виды работ")]
public TypesWorkTypesObjectsListPageObject Виды_работ { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Наименование = Down<ExtJsFormField<System.String>>("[rmsUid=a543d799-f327-40a3-b39f-c0a7e2dd658b]");
Иконка = Down<ExtJsFormField<System.String>>("[rmsUid=03c3dd4d-f056-4e5a-b0dd-47fd23e69b09]");
Цвет = Down<ExtJsFormField<System.String>>("[rmsUid=cf8e7da9-9ef1-41ff-90ce-f71ec541f58e]");
Виды_работ = Down<TypesWorkTypesObjectsListPageObject>("[rmsUid=d9897e33-543c-44b4-a708-0f4bb84082c3]");
        }

            }
}