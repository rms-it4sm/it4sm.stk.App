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
    /// Описание формы 'Сотрудник' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-staffeditor")]
    [Display("Редактор [Сотрудник]")]
    public class StaffEditorPageObject : BarsUpGeneratedEditorView<StaffEditorModel>
    {  
        public StaffEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public StaffEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Организация]
/// Идентификатор [8ea33522-4469-417c-aa77-ea5f9b462805]
/// Поле сущности: Сотрудники.Организация
/// </summary>
[Display("Организация")]
public BarsUpSelectorField<OrganizationListModel> Организация { get; internal set; }

/// <summary>
/// Выбор из справочника [Физ лицо]
/// Идентификатор [a4ebc6df-c58b-4297-8a7c-04610638ae05]
/// Поле сущности: Сотрудники.Физ лицо
/// </summary>
[Display("Физ лицо")]
public BarsUpSelectorField<IndividualsListModel> Физ_лицо { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [e3905ff8-9e8e-44e6-93fb-13dac3103cf5]
/// Поле сущности: Сотрудники.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Организация = Down<BarsUpSelectorField<OrganizationListModel>>("[rmsUid=8ea33522-4469-417c-aa77-ea5f9b462805]");
Физ_лицо = Down<BarsUpSelectorField<IndividualsListModel>>("[rmsUid=a4ebc6df-c58b-4297-8a7c-04610638ae05]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=e3905ff8-9e8e-44e6-93fb-13dac3103cf5]");
        }

            }
}