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
    /// Описание реестра 'Специалисты.Объект' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-compositionobjectspecialistslist")]
    [Display("Список [Специалисты.Объект]")]
    public class CompositionObjectSpecialistsListPageObject : BarsUpGeneratedListView<CompositionObjectSpecialistsListModel>
    {  
        public CompositionObjectSpecialistsListPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public CompositionObjectSpecialistsListPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

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
    /// Редактор: 77a6afbc-c73b-4ee9-af30-3fa36d6a8a37
    /// Режим: В окне
    /// </summary>
    [Display("Редактировать")]
    public ExtJsListViewEditAction<CompositionObjectSpecialistsEditorPageObject> Редактировать { get; private set; }

    public Toolbar_Верхняя_панель(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public Toolbar_Верхняя_панель(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    protected override void Initialize() {
        base.Initialize();
        Обновить = Down<ExtJsButton>("[rmsUid=34af89ec-2341-44ef-afb3-e9d8d7ffb1fc]");
        Добавить = Down<ExtJsButton>("[rmsUid=5ccc5abf-1919-4eea-9a16-5e6641a02d39]");
        Редактировать = Down<ExtJsListViewEditAction<CompositionObjectSpecialistsEditorPageObject>>("[rmsUid=4bf59d38-c1d1-498e-b1ef-0a9d70ed5aaf]", 
            x => {
                x.EditorUid = "77a6afbc-c73b-4ee9-af30-3fa36d6a8a37";
                x.Mode = ExtJsListViewEditActionMode.InWindow;
                x.ListView = (ExtJsGridPanel)Initializer;
            }
        );

    }
}

    }
}