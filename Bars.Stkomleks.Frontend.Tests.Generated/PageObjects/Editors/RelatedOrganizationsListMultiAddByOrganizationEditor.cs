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
    [ExtJsXType("rms-relatedorganizationslistmultiaddbyorganizationeditor")]
    [Display("Редактор []")]
    public class RelatedOrganizationsListMultiAddByOrganizationEditorPageObject : BarsUpGeneratedEditorView<RelatedOrganizationsListMultiAddByOrganizationEditorModel>
    {  
        public RelatedOrganizationsListMultiAddByOrganizationEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public RelatedOrganizationsListMultiAddByOrganizationEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Организация]
/// Идентификатор [a9913a4a-6560-cb62-ab3a-82fb6689cc52]
/// Поле сущности: Связанные организации.Организация
/// </summary>
[Display("Организация")]
public BarsUpSelectorField<OrganizationListModel> Организация { get; internal set; }

/// <summary>
/// Реестр []
/// Идентификатор [b1421b1f-2784-0477-4f1c-ebb2a364f317]
/// </summary>
[Display("Реестр_b1421b1f278404774f1cebb2a364f317")]
public OrganizationListPageObject Реестр { get; internal set; }

/// <summary>
/// Выбор из справочника [Связанная организация]
/// Идентификатор [1cb0d009-0f5a-4361-204a-1744329a84e0]
/// Поле сущности: Связанные организации.Связанная организация
/// </summary>
[Display("Связанная организация")]
public BarsUpSelectorField<OrganizationListModel> Связанная_организация { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Организация = Down<BarsUpSelectorField<OrganizationListModel>>("[rmsUid=a9913a4a-6560-cb62-ab3a-82fb6689cc52]");
Реестр = Down<OrganizationListPageObject>("[rmsUid=b1421b1f-2784-0477-4f1c-ebb2a364f317]");
Связанная_организация = Down<BarsUpSelectorField<OrganizationListModel>>("[rmsUid=1cb0d009-0f5a-4361-204a-1744329a84e0]");
        }

            }
}