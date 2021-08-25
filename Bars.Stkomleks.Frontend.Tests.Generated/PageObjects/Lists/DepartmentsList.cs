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
    /// Описание реестра 'Подразделения.Организация' для ui-тестирования
    /// </summary>       
    [ExtJsXType("rms-departmentslist")]
    [Display("Список [Подразделения.Организация]")]
    public class DepartmentsListPageObject : BarsUpGeneratedListView<DepartmentsListModel>
    {  
        public DepartmentsListPageObject(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}

        public DepartmentsListPageObject(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}

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
    /// Редактор: 130c4db5-a9b3-4c6f-b37e-01182825968c
    /// Режим: В окне
    /// </summary>
    [Display("Редактировать")]
    public ExtJsListViewEditAction<DepartmentsEditorPageObject> Редактировать { get; private set; }

    public Toolbar_Верхняя_панель(ExtJsComponent initializer, string elementId) : base(initializer, elementId) {}
    public Toolbar_Верхняя_панель(WebDriverAbstractFixture context, string elementId, ExtJsComponent initializer = null) : base(context, elementId, initializer) {}
    protected override void Initialize() {
        base.Initialize();
        Обновить = Down<ExtJsButton>("[rmsUid=27661cbf-b1d4-4b4e-a5f8-4b1222935d29]");
        Добавить = Down<ExtJsButton>("[rmsUid=c32cc702-fdee-4471-af38-785b07caf883]");
        Редактировать = Down<ExtJsListViewEditAction<DepartmentsEditorPageObject>>("[rmsUid=65f71078-208c-4157-a170-15ad5aa14a7a]", 
            x => {
                x.EditorUid = "130c4db5-a9b3-4c6f-b37e-01182825968c";
                x.Mode = ExtJsListViewEditActionMode.InWindow;
                x.ListView = (ExtJsGridPanel)Initializer;
            }
        );

    }
}

    }
}