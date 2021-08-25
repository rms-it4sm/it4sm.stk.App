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
    /// Описание реестра 'Заказы' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-orderslist")]
    [Display("Список [Заказы]")]
    public class OrdersListPageObject : BarsUpGeneratedListView<OrdersListModel>
    {  
        public OrdersListPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public OrdersListPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

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
    /// Действие добавления записи реестра
    /// </summary>
    [Display("Добавить")]
    public ExtJsButton Добавить { get; private set; }
    /// <summary>
    /// Действие редактирования записи реестра
    /// Редактор: b3d0c6e3-6410-4c8b-b359-da6efc0248e9
    /// Режим: В рабочем столе
    /// </summary>
    [Display("Редактировать")]
    public ExtJsListViewEditAction<OrdersEditorPageObject> Редактировать { get; private set; }

    public Toolbar_Верхняя_панель(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public Toolbar_Верхняя_панель(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    protected override void Initialize() {
        base.Initialize();
        Обновить = Down<ExtJsButton>("[rmsUid=eb0c060c-2e5b-47b6-9661-43f482836c0f]");
        Добавить = Down<ExtJsButton>("[rmsUid=5c5e8777-f502-402a-8fb4-8d873d0f9264]");
        Редактировать = Down<ExtJsListViewEditAction<OrdersEditorPageObject>>("[rmsUid=6fa8b590-b3bc-4663-ac64-6949917fb99d]", 
            x => {
                x.EditorUid = "b3d0c6e3-6410-4c8b-b359-da6efc0248e9";
                x.Mode = ExtJsListViewEditActionMode.Default;
                x.ListView = (ExtJsGridPanel)Initializer;
            }
        );

    }
}

    }
}