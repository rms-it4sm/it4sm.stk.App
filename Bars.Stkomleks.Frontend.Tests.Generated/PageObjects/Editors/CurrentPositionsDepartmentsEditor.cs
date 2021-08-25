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
    /// Описание формы 'Занимаемая должность подразделения' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-currentpositionsdepartmentseditor")]
    [Display("Редактор [Занимаемая должность подразделения]")]
    public class CurrentPositionsDepartmentsEditorPageObject : BarsUpGeneratedEditorView<CurrentPositionsDepartmentsEditorModel>
    {  
        public CurrentPositionsDepartmentsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public CurrentPositionsDepartmentsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [DepartmentPosition]
/// Идентификатор [ab8f4df2-bb87-4293-847e-d488615cdc83]
/// Поле сущности: Занимаемые должности подразделений.Должность подразделения
/// </summary>
[Display("DepartmentPosition")]
public BarsUpSelectorField<DepartmentsPositionsListModel> DepartmentPosition { get; internal set; }

/// <summary>
/// Выбор из справочника [Сотрудник]
/// Идентификатор [062171fa-0c1d-4fa5-b31e-3d325d0f344e]
/// Поле сущности: Занимаемые должности подразделений.Сотрудник
/// </summary>
[Display("Сотрудник")]
public BarsUpSelectorField<StaffListModel> Сотрудник { get; internal set; }

/// <summary>
/// Поле ввода даты [Начало]
/// Идентификатор [f0555789-6bc1-4662-b7ec-ed7a8187b0fb]
/// Поле сущности: Занимаемые должности подразделений.Начало
/// </summary>
[Display("Начало")]
public ExtJsFormField<System.DateTime?> Начало { get; internal set; }

/// <summary>
/// Поле ввода даты [Завершение]
/// Идентификатор [d7767b20-476e-488e-9317-271ff8beb4c9]
/// Поле сущности: Занимаемые должности подразделений.Завершение
/// </summary>
[Display("Завершение")]
public ExtJsFormField<System.DateTime?> Завершение { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [236ab0cb-e3d9-4611-a02c-670ae5464ea5]
/// Поле сущности: Занимаемые должности подразделений.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            DepartmentPosition = Down<BarsUpSelectorField<DepartmentsPositionsListModel>>("[rmsUid=ab8f4df2-bb87-4293-847e-d488615cdc83]");
Сотрудник = Down<BarsUpSelectorField<StaffListModel>>("[rmsUid=062171fa-0c1d-4fa5-b31e-3d325d0f344e]");
Начало = Down<ExtJsFormField<System.DateTime?>>("[rmsUid=f0555789-6bc1-4662-b7ec-ed7a8187b0fb]");
Завершение = Down<ExtJsFormField<System.DateTime?>>("[rmsUid=d7767b20-476e-488e-9317-271ff8beb4c9]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=236ab0cb-e3d9-4611-a02c-670ae5464ea5]");
        }

            }
}