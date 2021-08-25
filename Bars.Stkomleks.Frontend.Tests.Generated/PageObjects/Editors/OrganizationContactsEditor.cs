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
    /// Описание формы 'Контакт организации' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-organizationcontactseditor")]
    [Display("Редактор [Контакт организации]")]
    public class OrganizationContactsEditorPageObject : BarsUpGeneratedEditorView<OrganizationContactsEditorModel>
    {  
        public OrganizationContactsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrganizationContactsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Организация]
/// Идентификатор [5bc8a725-8141-4786-8b89-295f6a741051]
/// Поле сущности: Контакты организации.Организация
/// </summary>
[Display("Организация")]
public BarsUpSelectorField<OrganizationListModel> Организация { get; internal set; }

/// <summary>
/// Выбор из справочника [Тип]
/// Идентификатор [0716e607-5126-4514-9753-10e22e55cf33]
/// Поле сущности: Контакты организации.Тип
/// </summary>
[Display("Тип")]
public BarsUpSelectorField<ContactsTypeListModel> Тип { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Контакт]
/// Идентификатор [8e2f1526-27be-49c5-ace5-4d75e6a0fd66]
/// Поле сущности: Контакты организации.Контакт
/// </summary>
[Display("Контакт")]
public ExtJsFormField<System.String> Контакт { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [cdf68203-272f-439b-af3a-2fd2f8b799d5]
/// Поле сущности: Контакты организации.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Организация = Down<BarsUpSelectorField<OrganizationListModel>>("[rmsUid=5bc8a725-8141-4786-8b89-295f6a741051]");
Тип = Down<BarsUpSelectorField<ContactsTypeListModel>>("[rmsUid=0716e607-5126-4514-9753-10e22e55cf33]");
Контакт = Down<ExtJsFormField<System.String>>("[rmsUid=8e2f1526-27be-49c5-ace5-4d75e6a0fd66]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=cdf68203-272f-439b-af3a-2fd2f8b799d5]");
        }

            }
}