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
    /// Описание реестра 'Объекты' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-ordersobjectslist2")]
    [Display("Список [Объекты]")]
    public class OrdersObjectsList2PageObject : BarsUpGeneratedListView<OrdersObjectsList2Model>
    {  
        public OrdersObjectsList2PageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrdersObjectsList2PageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

        [Display("Верхняя_панель")]
public Toolbar_Верхняя_панель Верхняя_панель { get; internal set; }
        
        protected override void Initialize()
        {
            base.Initialize();
            Верхняя_панель = Down<Toolbar_Верхняя_панель>("[dock=top]");
        }

        /// <summary>
/// Панель действие реестра 'Верхняя панель'
/// </summary>
public class Toolbar_Верхняя_панель : ExtJsToolbar {
    /// <summary>
    /// Действие обновления данных реестра
    /// </summary>
    [Display("Обновить")]
    public ExtJsButton Обновить { get; private set; }
    /// <summary>
    /// Действие редактирования записи реестра
    /// Редактор: d0c2a2f2-1963-47b7-8908-491cb7e146fb
    /// Режим: В рабочем столе
    /// </summary>
    [Display("Редактировать")]
    public ExtJsListViewEditAction<OrdersObjectsEditor_Copy_0PageObject> Редактировать { get; private set; }

    public Toolbar_Верхняя_панель(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public Toolbar_Верхняя_панель(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    protected override void Initialize() {
        base.Initialize();
        Обновить = Down<ExtJsButton>("[rmsUid=806546d6-367d-48ea-aa05-bb794f1fc8e6]");
        Редактировать = Down<ExtJsListViewEditAction<OrdersObjectsEditor_Copy_0PageObject>>("[rmsUid=864cbdc3-a46d-4bc2-a480-9aad970e5991]", 
            x => {
                x.EditorUid = "d0c2a2f2-1963-47b7-8908-491cb7e146fb";
                x.Mode = ExtJsListViewEditActionMode.Default;
                x.ListView = (ExtJsGridPanel)Initializer;
            }
        );

    }
}

    }
}