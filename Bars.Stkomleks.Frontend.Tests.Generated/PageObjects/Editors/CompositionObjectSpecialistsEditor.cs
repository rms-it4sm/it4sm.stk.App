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
    /// Описание формы 'Специалист объекта' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-compositionobjectspecialistseditor")]
    [Display("Редактор [Специалист объекта]")]
    public class CompositionObjectSpecialistsEditorPageObject : BarsUpGeneratedEditorView<CompositionObjectSpecialistsEditorModel>
    {  
        public CompositionObjectSpecialistsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public CompositionObjectSpecialistsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Объект]
/// Идентификатор [ee6aac1d-7f16-447d-a4f8-d47f06134b29]
/// Поле сущности: Специалисты объектов.Объект
/// </summary>
[Display("Объект")]
public BarsUpSelectorField<OrdersObjectsListModel> Объект { get; internal set; }

/// <summary>
/// Выбор из справочника [Роль]
/// Идентификатор [5d246691-97db-4aa2-a56d-1c4312ad6807]
/// Поле сущности: Специалисты объектов.Роль
/// </summary>
[Display("Роль")]
public BarsUpSelectorField<WorksRolesListModel> Роль { get; internal set; }

/// <summary>
/// Выбор из справочника [Сотрудник]
/// Идентификатор [1c2fe304-8ce2-4934-94fe-83cade766219]
/// Поле сущности: Специалисты объектов.Сотрудник
/// </summary>
[Display("Сотрудник")]
public BarsUpSelectorField<CurrentPositionsDepartmentsListModel> Сотрудник { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [884058c1-498e-497b-8708-e894edb22a80]
/// Поле сущности: Специалисты объектов.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Объект = Down<BarsUpSelectorField<OrdersObjectsListModel>>("[rmsUid=ee6aac1d-7f16-447d-a4f8-d47f06134b29]");
Роль = Down<BarsUpSelectorField<WorksRolesListModel>>("[rmsUid=5d246691-97db-4aa2-a56d-1c4312ad6807]");
Сотрудник = Down<BarsUpSelectorField<CurrentPositionsDepartmentsListModel>>("[rmsUid=1c2fe304-8ce2-4934-94fe-83cade766219]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=884058c1-498e-497b-8708-e894edb22a80]");
        }

            }
}