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
    /// Описание формы 'Организация заказа' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-orderorganizationeditor")]
    [Display("Редактор [Организация заказа]")]
    public class OrderOrganizationEditorPageObject : BarsUpGeneratedEditorView<OrderOrganizationEditorModel>
    {  
        public OrderOrganizationEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrderOrganizationEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Заказ]
/// Идентификатор [06e1b195-0b50-4691-8a48-01e826ef8311]
/// Поле сущности: Организации заказа.Заказ
/// </summary>
[Display("Заказ")]
public BarsUpSelectorField<OrdersListModel> Заказ { get; internal set; }

/// <summary>
/// Выбор из справочника [Профиль]
/// Идентификатор [213f9170-9e05-426a-9529-8394defefd3c]
/// Поле сущности: Организации заказа.Профиль
/// </summary>
[Display("Профиль")]
public BarsUpSelectorField<ProfilesOrganizationsListModel> Профиль { get; internal set; }

/// <summary>
/// Выбор из справочника [Организация]
/// Идентификатор [c3b85dc8-9185-4dcd-8290-3412f84ebbbb]
/// Поле сущности: Организации заказа.Организация
/// </summary>
[Display("Организация")]
public BarsUpSelectorField<OrganizationProfilesList2Model> Организация { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [0405b220-229b-44b3-9e70-9ca4ae8de489]
/// Поле сущности: Организации заказа.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }

/// <summary>
/// Реестр [Ответственные лица]
/// Идентификатор [1d7f1108-d152-426d-b268-cc56de6021a0]
/// </summary>
[Display("Ответственные лица")]
public ResponsiblePersonsOrderListPageObject Ответственные_лица { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Заказ = Down<BarsUpSelectorField<OrdersListModel>>("[rmsUid=06e1b195-0b50-4691-8a48-01e826ef8311]");
Профиль = Down<BarsUpSelectorField<ProfilesOrganizationsListModel>>("[rmsUid=213f9170-9e05-426a-9529-8394defefd3c]");
Организация = Down<BarsUpSelectorField<OrganizationProfilesList2Model>>("[rmsUid=c3b85dc8-9185-4dcd-8290-3412f84ebbbb]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=0405b220-229b-44b3-9e70-9ca4ae8de489]");
Ответственные_лица = Down<ResponsiblePersonsOrderListPageObject>("[rmsUid=1d7f1108-d152-426d-b268-cc56de6021a0]");
        }

            }
}