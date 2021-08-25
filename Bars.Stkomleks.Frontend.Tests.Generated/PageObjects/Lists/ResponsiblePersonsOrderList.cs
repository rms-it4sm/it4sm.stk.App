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
    /// Описание реестра 'Ответственные лица. Организация заказа' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-responsiblepersonsorderlist")]
    [Display("Список [Ответственные лица. Организация заказа]")]
    public class ResponsiblePersonsOrderListPageObject : BarsUpGeneratedListView<ResponsiblePersonsOrderListModel>
    {  
        public ResponsiblePersonsOrderListPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public ResponsiblePersonsOrderListPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

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
    /// Редактор: 67d498ae-2835-45e6-972f-62b96a4979aa
    /// Режим: В окне
    /// </summary>
    [Display("Редактировать")]
    public ExtJsListViewEditAction<ResponsiblePersonsOrderEditorPageObject> Редактировать { get; private set; }

    public Toolbar_Верхняя_панель(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public Toolbar_Верхняя_панель(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    protected override void Initialize() {
        base.Initialize();
        Обновить = Down<ExtJsButton>("[rmsUid=8650124c-b66e-488c-824f-8506bec13d52]");
        Добавить = Down<ExtJsButton>("[rmsUid=42b0fad9-76b1-4a4b-8e06-dc22e16214b2]");
        Редактировать = Down<ExtJsListViewEditAction<ResponsiblePersonsOrderEditorPageObject>>("[rmsUid=3c67c4e5-f3e2-4ed2-9f83-6c658e451c60]", 
            x => {
                x.EditorUid = "67d498ae-2835-45e6-972f-62b96a4979aa";
                x.Mode = ExtJsListViewEditActionMode.InWindow;
                x.ListView = (ExtJsGridPanel)Initializer;
            }
        );

    }
}

    }
}