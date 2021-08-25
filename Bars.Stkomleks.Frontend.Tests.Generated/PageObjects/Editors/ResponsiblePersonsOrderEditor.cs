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
    /// Описание формы 'Ответственное лицо заказа' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-responsiblepersonsordereditor")]
    [Display("Редактор [Ответственное лицо заказа]")]
    public class ResponsiblePersonsOrderEditorPageObject : BarsUpGeneratedEditorView<ResponsiblePersonsOrderEditorModel>
    {  
        public ResponsiblePersonsOrderEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public ResponsiblePersonsOrderEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Организация заказа]
/// Идентификатор [3dfdd012-7ea1-47fa-86d7-10aaa70d0ab2]
/// Поле сущности: Ответственные лица заказа.Организация заказа
/// </summary>
[Display("Организация заказа")]
public BarsUpSelectorField<OrderOrganizationListModel> Организация_заказа { get; internal set; }

/// <summary>
/// Выбор из справочника [Сотрудник]
/// Идентификатор [cca396ee-fdd6-4e2a-9d9c-44007b0c8690]
/// Поле сущности: Ответственные лица заказа.Сотрудник
/// </summary>
[Display("Сотрудник")]
public BarsUpSelectorField<StaffListModel> Сотрудник { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Назначение]
/// Идентификатор [cc815e19-f5bd-42ae-801b-00cf22861ec0]
/// Поле сущности: Ответственные лица заказа.Назначение
/// </summary>
[Display("Назначение")]
public ExtJsFormField<System.String> Назначение { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Организация_заказа = Down<BarsUpSelectorField<OrderOrganizationListModel>>("[rmsUid=3dfdd012-7ea1-47fa-86d7-10aaa70d0ab2]");
Сотрудник = Down<BarsUpSelectorField<StaffListModel>>("[rmsUid=cca396ee-fdd6-4e2a-9d9c-44007b0c8690]");
Назначение = Down<ExtJsFormField<System.String>>("[rmsUid=cc815e19-f5bd-42ae-801b-00cf22861ec0]");
        }

            }
}