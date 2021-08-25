// ReSharper disable InconsistentNaming
// ReSharper disable ClassNeverInstantiated.Global
namespace Bars.Stkomleks.Frontend.Tests.Clickers
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
    using Bars.Stkomleks.Frontend.Tests.PageObjects;

    using Xunit;
    using Xunit.Abstractions;
    using OpenQA.Selenium;

    /// <summary>    
    /// Класс-кликер, содержащий код для обхода редактора Должность подразделения
    /// </summary>       
    [Display("Кликер редактора [Должность подразделения]")]
    public class DepartmentsPositionsEditorClicker : WebElementClicker<DepartmentsPositionsEditorPageObject>
    {          
        public DepartmentsPositionsEditorClicker(AbstractWebDriverTest test, DepartmentsPositionsEditorPageObject view) : base(test, view) {}

        public override void Run()
        {
            Group("Проверка панели закладок [Панель_закладок]", 
    () => {
        SkipIfNotInteractable(_view => _view.Панель_закладок);
        var tp81d8bd32b2754a56922e1253710ee6c8 = View.Панель_закладок;
        Step("Проверка вкладки [Сотрудники]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Сотрудники, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Сотрудники]");
                View.Панель_закладок.Сотрудники.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Сотрудники);
                Step("Проверка вложенного элемента [Занимаемые должности.Подразделение]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Сотрудники.Занимаемые_должности_Подразделение);
                        Test.RunClicker<CurrentPositionsDepartmentsListClicker>(View.Панель_закладок.Сотрудники.Занимаемые_должности_Подразделение);
                    }
                );
            }
        );
    }
);
        }                
    }
}