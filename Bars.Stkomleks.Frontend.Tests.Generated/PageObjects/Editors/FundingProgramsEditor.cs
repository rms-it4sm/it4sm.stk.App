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
    /// Описание формы 'Программа финансирования' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-fundingprogramseditor")]
    [Display("Редактор [Программа финансирования]")]
    public class FundingProgramsEditorPageObject : BarsUpGeneratedEditorView<FundingProgramsEditorModel>
    {  
        public FundingProgramsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public FundingProgramsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Однострочный редактор текста [Наименование]
/// Идентификатор [a4fb2f2c-d3cc-4618-9927-7dfb3d2e130f]
/// Поле сущности: Программы финансирования.Наименование
/// </summary>
[Display("Наименование")]
public ExtJsFormField<System.String> Наименование { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [16ca362f-e0ed-4abb-9ebc-68219710c8f3]
/// Поле сущности: Программы финансирования.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }

/// <summary>
/// Реестр [Оганизации]
/// Идентификатор [c9c0bad9-cce1-48e5-a1ed-220dd4a9b952]
/// </summary>
[Display("Оганизации")]
public OrganizationFundingProgramsList2PageObject Оганизации { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Наименование = Down<ExtJsFormField<System.String>>("[rmsUid=a4fb2f2c-d3cc-4618-9927-7dfb3d2e130f]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=16ca362f-e0ed-4abb-9ebc-68219710c8f3]");
Оганизации = Down<OrganizationFundingProgramsList2PageObject>("[rmsUid=c9c0bad9-cce1-48e5-a1ed-220dd4a9b952]");
        }

            }
}