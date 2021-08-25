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
    /// Описание формы 'Физическое лицо' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-individualseditor")]
    [Display("Редактор [Физическое лицо]")]
    public class IndividualsEditorPageObject : BarsUpGeneratedEditorView<IndividualsEditorModel>
    {  
        public IndividualsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public IndividualsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Однострочный редактор текста [Фамилия]
/// Идентификатор [ace72536-1b25-42f3-8d96-50882e457efd]
/// Поле сущности: Физические лица.Фамилия
/// </summary>
[Display("Фамилия")]
public ExtJsFormField<System.String> Фамилия { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Имя]
/// Идентификатор [5591bf2a-a7fc-416d-aea3-bea89ec4953e]
/// Поле сущности: Физические лица.Имя
/// </summary>
[Display("Имя")]
public ExtJsFormField<System.String> Имя { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Отчество]
/// Идентификатор [d8115caf-502d-43fd-bef2-0a8d5c903ed5]
/// Поле сущности: Физические лица.Отчество
/// </summary>
[Display("Отчество")]
public ExtJsFormField<System.String> Отчество { get; internal set; }

/// <summary>
/// Однострочный редактор текста [ФИО]
/// Идентификатор [2d48ca36-49f4-4fa4-9b69-366d793a51fa]
/// Поле сущности: Физические лица.ФИО
/// </summary>
[Display("ФИО")]
public ExtJsFormField<System.String> ФИО { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [c2758611-1346-4bcf-9ba2-db34beef7c63]
/// Поле сущности: Физические лица.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Фамилия = Down<ExtJsFormField<System.String>>("[rmsUid=ace72536-1b25-42f3-8d96-50882e457efd]");
Имя = Down<ExtJsFormField<System.String>>("[rmsUid=5591bf2a-a7fc-416d-aea3-bea89ec4953e]");
Отчество = Down<ExtJsFormField<System.String>>("[rmsUid=d8115caf-502d-43fd-bef2-0a8d5c903ed5]");
ФИО = Down<ExtJsFormField<System.String>>("[rmsUid=2d48ca36-49f4-4fa4-9b69-366d793a51fa]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=c2758611-1346-4bcf-9ba2-db34beef7c63]");
        }

            }
}