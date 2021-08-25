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
    /// Описание реестра 'Комплектация.Элемент спецификации' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-productslist")]
    [Display("Список [Комплектация.Элемент спецификации]")]
    public class ProductsListPageObject : BarsUpGeneratedListView<ProductsListModel>
    {  
        public ProductsListPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public ProductsListPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

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
    /// Редактор: 153ded49-b5ae-4c43-bdb2-a835368c2cf2
    /// Режим: В окне
    /// </summary>
    [Display("Редактировать")]
    public ExtJsListViewEditAction<ProductsEditorPageObject> Редактировать { get; private set; }

    public Toolbar_Верхняя_панель(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public Toolbar_Верхняя_панель(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    protected override void Initialize() {
        base.Initialize();
        Обновить = Down<ExtJsButton>("[rmsUid=f8ef86c4-533a-4c55-adf6-0b7fb36c477a]");
        Добавить = Down<ExtJsButton>("[rmsUid=3f7aaf28-5020-4b10-8b76-67c3ada5b8d1]");
        Редактировать = Down<ExtJsListViewEditAction<ProductsEditorPageObject>>("[rmsUid=9f5c36bc-bc38-4e26-85ab-2f1583bd0094]", 
            x => {
                x.EditorUid = "153ded49-b5ae-4c43-bdb2-a835368c2cf2";
                x.Mode = ExtJsListViewEditActionMode.InWindow;
                x.ListView = (ExtJsGridPanel)Initializer;
            }
        );

    }
}

    }
}