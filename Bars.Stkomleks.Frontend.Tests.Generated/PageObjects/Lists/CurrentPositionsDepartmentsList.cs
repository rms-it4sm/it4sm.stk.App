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
    /// Описание реестра 'Занимаемые должности.Подразделение' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-currentpositionsdepartmentslist")]
    [Display("Список [Занимаемые должности.Подразделение]")]
    public class CurrentPositionsDepartmentsListPageObject : BarsUpGeneratedListView<CurrentPositionsDepartmentsListModel>
    {  
        public CurrentPositionsDepartmentsListPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public CurrentPositionsDepartmentsListPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

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
    /// Редактор: 5384176d-011e-4051-a1ad-61487308dd00
    /// Режим: В окне
    /// </summary>
    [Display("Редактировать")]
    public ExtJsListViewEditAction<CurrentPositionsDepartmentsEditorPageObject> Редактировать { get; private set; }

    public Toolbar_Верхняя_панель(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public Toolbar_Верхняя_панель(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    protected override void Initialize() {
        base.Initialize();
        Обновить = Down<ExtJsButton>("[rmsUid=5c3d8c18-4ee0-4a56-9aea-a3375b8d9cfc]");
        Добавить = Down<ExtJsButton>("[rmsUid=315980a7-fd7f-4c37-840e-be8d7904cc74]");
        Редактировать = Down<ExtJsListViewEditAction<CurrentPositionsDepartmentsEditorPageObject>>("[rmsUid=80cb4ec4-4d70-4357-8b03-92d988bbc2d0]", 
            x => {
                x.EditorUid = "5384176d-011e-4051-a1ad-61487308dd00";
                x.Mode = ExtJsListViewEditActionMode.InWindow;
                x.ListView = (ExtJsGridPanel)Initializer;
            }
        );

    }
}

    }
}