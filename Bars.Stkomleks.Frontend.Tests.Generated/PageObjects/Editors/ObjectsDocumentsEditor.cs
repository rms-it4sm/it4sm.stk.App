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
    /// Описание формы 'Документ объекта' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-objectsdocumentseditor")]
    [Display("Редактор [Документ объекта]")]
    public class ObjectsDocumentsEditorPageObject : BarsUpGeneratedEditorView<ObjectsDocumentsEditorModel>
    {  
        public ObjectsDocumentsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public ObjectsDocumentsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Объект]
/// Идентификатор [bc491af1-a8fe-45bd-b9fb-b80dfe7fde76]
/// Поле сущности: Документы объекта.Объект
/// </summary>
[Display("Объект")]
public BarsUpSelectorField<OrdersObjectsListModel> Объект { get; internal set; }

/// <summary>
/// Поле выбора изображения [Файл]
/// Идентификатор [3c636c63-b29e-457a-a6f9-7805410c7efd]
/// Поле сущности: Документы объекта.Файл
/// </summary>
[Display("Файл")]
public ExtJsFormField<BarsUp.Modules.FileStorage.FileInfo> Файл { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [702cdb2a-2f51-4656-aa02-c13fc875c177]
/// Поле сущности: Документы объекта.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Объект = Down<BarsUpSelectorField<OrdersObjectsListModel>>("[rmsUid=bc491af1-a8fe-45bd-b9fb-b80dfe7fde76]");
Файл = Down<ExtJsFormField<BarsUp.Modules.FileStorage.FileInfo>>("[rmsUid=3c636c63-b29e-457a-a6f9-7805410c7efd]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=702cdb2a-2f51-4656-aa02-c13fc875c177]");
        }

            }
}