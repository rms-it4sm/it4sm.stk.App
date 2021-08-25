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
    /// Описание реестра 'Работы.Объект' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-compositionworksobjectslist")]
    [Display("Список [Работы.Объект]")]
    public class CompositionWorksObjectsListPageObject : BarsUpGeneratedListView<CompositionWorksObjectsListModel>
    {  
        public CompositionWorksObjectsListPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public CompositionWorksObjectsListPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

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
    /// Редактор: 4e04503b-095f-40ac-a590-d3b44110768f
    /// Режим: В окне
    /// </summary>
    [Display("Редактировать")]
    public ExtJsListViewEditAction<CompositionWorksObjectsEditorPageObject> Редактировать { get; private set; }

    public Toolbar_Верхняя_панель(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public Toolbar_Верхняя_панель(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    protected override void Initialize() {
        base.Initialize();
        Обновить = Down<ExtJsButton>("[rmsUid=7a122cba-0549-476d-9a37-c23b9cdeb3f3]");
        Добавить = Down<ExtJsButton>("[rmsUid=4e2d2b76-9499-46f4-bd36-251985798035]");
        Редактировать = Down<ExtJsListViewEditAction<CompositionWorksObjectsEditorPageObject>>("[rmsUid=626b9c6b-ec6d-421c-b3fc-9b32b7632b9c]", 
            x => {
                x.EditorUid = "4e04503b-095f-40ac-a590-d3b44110768f";
                x.Mode = ExtJsListViewEditActionMode.InWindow;
                x.ListView = (ExtJsGridPanel)Initializer;
            }
        );

    }
}

    }
}