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
    [ExtJsXType("rms-organizationprofileslistmultiaddbyorganizationeditor")]
    [Display("Редактор []")]
    public class OrganizationProfilesListMultiAddByOrganizationEditorPageObject : BarsUpGeneratedEditorView<OrganizationProfilesListMultiAddByOrganizationEditorModel>
    {  
        public OrganizationProfilesListMultiAddByOrganizationEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrganizationProfilesListMultiAddByOrganizationEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Организация]
/// Идентификатор [3f6a27a7-9537-6b5e-172c-f61ca13808c4]
/// Поле сущности: Организации по профилю.Организация
/// </summary>
[Display("Организация")]
public BarsUpSelectorField<OrganizationListModel> Организация { get; internal set; }

/// <summary>
/// Реестр []
/// Идентификатор [7fcb5033-cbfe-1dc9-5d12-c1cf269e022f]
/// </summary>
[Display("Реестр_7fcb5033cbfe1dc95d12c1cf269e022f")]
public ProfilesOrganizationsListPageObject Реестр { get; internal set; }

/// <summary>
/// Выбор из справочника [Профиль]
/// Идентификатор [f41fc75b-99e9-2cb7-334f-1847641581ea]
/// Поле сущности: Организации по профилю.Профиль
/// </summary>
[Display("Профиль")]
public BarsUpSelectorField<ProfilesOrganizationsListModel> Профиль { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Организация = Down<BarsUpSelectorField<OrganizationListModel>>("[rmsUid=3f6a27a7-9537-6b5e-172c-f61ca13808c4]");
Реестр = Down<ProfilesOrganizationsListPageObject>("[rmsUid=7fcb5033-cbfe-1dc9-5d12-c1cf269e022f]");
Профиль = Down<BarsUpSelectorField<ProfilesOrganizationsListModel>>("[rmsUid=f41fc75b-99e9-2cb7-334f-1847641581ea]");
        }

            }
}