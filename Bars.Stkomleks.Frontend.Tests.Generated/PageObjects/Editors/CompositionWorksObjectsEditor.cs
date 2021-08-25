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
    /// Описание формы 'Работа объекта' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-compositionworksobjectseditor")]
    [Display("Редактор [Работа объекта]")]
    public class CompositionWorksObjectsEditorPageObject : BarsUpGeneratedEditorView<CompositionWorksObjectsEditorModel>
    {  
        public CompositionWorksObjectsEditorPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public CompositionWorksObjectsEditorPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        
/// <summary>
/// Выбор из справочника [Объект]
/// Идентификатор [2b8b0c57-d464-4752-9361-5696f0af7042]
/// Поле сущности: Работы объектов.Объект
/// </summary>
[Display("Объект")]
public BarsUpSelectorField<OrdersObjectsListModel> Объект { get; internal set; }

/// <summary>
/// Выбор из справочника [Вид работы]
/// Идентификатор [a762a472-885d-4ce8-8109-14fb441047cb]
/// Поле сущности: Работы объектов.Вид работы
/// </summary>
[Display("Вид работы")]
public BarsUpSelectorField<TypesWorkTypesObjectsListModel> Вид_работы { get; internal set; }

/// <summary>
/// Выбор из справочника [Элемент объекта]
/// Идентификатор [f45a5a1f-42d8-4cb7-b20c-7c4d1aab7c29]
/// Поле сущности: Работы объектов.Элемент объекта
/// </summary>
[Display("Элемент объекта")]
public BarsUpSelectorField<ObjectProductsListModel> Элемент_объекта { get; internal set; }

/// <summary>
/// Поле ввода даты [Начало (план)]
/// Идентификатор [6b7a114e-df05-4f5a-a3dd-b2070e1ba00c]
/// Поле сущности: Работы объектов.Начало (план)
/// </summary>
[Display("Начало (план)")]
public ExtJsFormField<System.DateTime?> Начало_план { get; internal set; }

/// <summary>
/// Поле ввода даты [Завершение (план)]
/// Идентификатор [fa84fbec-e92b-4435-adeb-6d1d185cdc63]
/// Поле сущности: Работы объектов.Завершение (план)
/// </summary>
[Display("Завершение (план)")]
public ExtJsFormField<System.DateTime?> Завершение_план { get; internal set; }

/// <summary>
/// Выпадающий список (перечисление) [Способ выполнения]
/// Идентификатор [e1d5e4c4-3020-4ea2-84c7-17d4e228ade9]
/// Поле сущности: Работы объектов.Способ выполнения
/// </summary>
[Display("Способ выполнения")]
public BarsUpEnumField<TypesWorkPerformers> Способ_выполнения { get; internal set; }

/// <summary>
/// Выбор из справочника [Подрядчик]
/// Идентификатор [b6a092b6-cd49-4b7b-b0d1-0c0c9b25b988]
/// Поле сущности: Работы объектов.Подрядчик
/// </summary>
[Display("Подрядчик")]
public BarsUpSelectorField<OrganizationProfilesList2Model> Подрядчик { get; internal set; }

/// <summary>
/// Выбор из справочника [Бригада]
/// Идентификатор [d7aa4ba2-32fc-4a4f-9a3a-32c7519cc054]
/// Поле сущности: Работы объектов.Бригада
/// </summary>
[Display("Бригада")]
public BarsUpSelectorField<DepartmentsListModel> Бригада { get; internal set; }

/// <summary>
/// Многострочный редактор текста [Описание]
/// Идентификатор [c0d4d8ce-0805-435a-bb42-f91a379fce3e]
/// Поле сущности: Работы объектов.Описание
/// </summary>
[Display("Описание")]
public ExtJsFormField<System.String> Описание { get; internal set; }

/// <summary>
/// Однострочный редактор текста [Исполнитель]
/// Идентификатор [186250b8-243c-46dd-8485-aecd9df9c34d]
/// Поле сущности: Работы объектов.Исполнитель
/// </summary>
[Display("Исполнитель")]
public ExtJsFormField<System.String> Исполнитель { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Объект = Down<BarsUpSelectorField<OrdersObjectsListModel>>("[rmsUid=2b8b0c57-d464-4752-9361-5696f0af7042]");
Вид_работы = Down<BarsUpSelectorField<TypesWorkTypesObjectsListModel>>("[rmsUid=a762a472-885d-4ce8-8109-14fb441047cb]");
Элемент_объекта = Down<BarsUpSelectorField<ObjectProductsListModel>>("[rmsUid=f45a5a1f-42d8-4cb7-b20c-7c4d1aab7c29]");
Начало_план = Down<ExtJsFormField<System.DateTime?>>("[rmsUid=6b7a114e-df05-4f5a-a3dd-b2070e1ba00c]");
Завершение_план = Down<ExtJsFormField<System.DateTime?>>("[rmsUid=fa84fbec-e92b-4435-adeb-6d1d185cdc63]");
Способ_выполнения = Down<BarsUpEnumField<TypesWorkPerformers>>("[rmsUid=e1d5e4c4-3020-4ea2-84c7-17d4e228ade9]");
Подрядчик = Down<BarsUpSelectorField<OrganizationProfilesList2Model>>("[rmsUid=b6a092b6-cd49-4b7b-b0d1-0c0c9b25b988]");
Бригада = Down<BarsUpSelectorField<DepartmentsListModel>>("[rmsUid=d7aa4ba2-32fc-4a4f-9a3a-32c7519cc054]");
Описание = Down<ExtJsFormField<System.String>>("[rmsUid=c0d4d8ce-0805-435a-bb42-f91a379fce3e]");
Исполнитель = Down<ExtJsFormField<System.String>>("[rmsUid=186250b8-243c-46dd-8485-aecd9df9c34d]");
        }

            }
}