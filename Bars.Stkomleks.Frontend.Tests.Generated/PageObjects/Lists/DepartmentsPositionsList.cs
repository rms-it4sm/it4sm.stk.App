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
    /// Описание реестра 'Должности.Подразделение' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-departmentspositionslist")]
    [Display("Список [Должности.Подразделение]")]
    public class DepartmentsPositionsListPageObject : BarsUpGeneratedListView<DepartmentsPositionsListModel>
    {  
        public DepartmentsPositionsListPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public DepartmentsPositionsListPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

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
    /// Редактор: 23beb68e-9c91-43c1-a435-257bf4e15d1b
    /// Режим: В окне
    /// </summary>
    [Display("Редактировать")]
    public ExtJsListViewEditAction<DepartmentsPositionsEditorPageObject> Редактировать { get; private set; }

    public Toolbar_Верхняя_панель(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public Toolbar_Верхняя_панель(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    protected override void Initialize() {
        base.Initialize();
        Обновить = Down<ExtJsButton>("[rmsUid=01dbb461-fe9c-4db6-8f6d-8b368769fda7]");
        Добавить = Down<ExtJsButton>("[rmsUid=8bed812c-46ed-40d2-a33c-8999e73a1d2f]");
        Редактировать = Down<ExtJsListViewEditAction<DepartmentsPositionsEditorPageObject>>("[rmsUid=1f790d98-22a2-41c7-9908-5b432ad80961]", 
            x => {
                x.EditorUid = "23beb68e-9c91-43c1-a435-257bf4e15d1b";
                x.Mode = ExtJsListViewEditActionMode.InWindow;
                x.ListView = (ExtJsGridPanel)Initializer;
            }
        );

    }
}

    }
}