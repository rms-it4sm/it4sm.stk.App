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
    [ExtJsXType("rms-organizationfundingprogramslistmultiaddbyorganizationeditor")]
    [Display("Редактор []")]
    public class OrganizationFundingProgramsListMultiAddByOrganizationEditorPageObject : BarsUpGeneratedEditorView<OrganizationFundingProgramsListMultiAddByOrganizationEditorModel>
    {  
        public OrganizationFundingProgramsListMultiAddByOrganizationEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrganizationFundingProgramsListMultiAddByOrganizationEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Организация]
/// Идентификатор [d293b26a-b89b-aefe-87a1-4bad120ba077]
/// Поле сущности: Программы финансирования организации.Организация
/// </summary>
[Display("Организация")]
public BarsUpSelectorField<OrganizationListModel> Организация { get; internal set; }

/// <summary>
/// Реестр []
/// Идентификатор [6aca93db-5c20-864a-9c1b-c5b573f943ab]
/// </summary>
[Display("Реестр_6aca93db5c20864a9c1bc5b573f943ab")]
public FundingProgramsListPageObject Реестр { get; internal set; }

/// <summary>
/// Выбор из справочника [Программа финансирования]
/// Идентификатор [85777005-b52b-9921-3685-5a412553cd80]
/// Поле сущности: Программы финансирования организации.Программа финансирования
/// </summary>
[Display("Программа финансирования")]
public BarsUpSelectorField<FundingProgramsListModel> Программа_финансирования { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Организация = Down<BarsUpSelectorField<OrganizationListModel>>("[rmsUid=d293b26a-b89b-aefe-87a1-4bad120ba077]");
Реестр = Down<FundingProgramsListPageObject>("[rmsUid=6aca93db-5c20-864a-9c1b-c5b573f943ab]");
Программа_финансирования = Down<BarsUpSelectorField<FundingProgramsListModel>>("[rmsUid=85777005-b52b-9921-3685-5a412553cd80]");
        }

            }
}