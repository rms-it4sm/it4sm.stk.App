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
    /// Класс-кликер, содержащий код для обхода редактора Подразделение
    /// </summary>       
    [Display("Кликер редактора [Подразделение]")]
    public class DepartmentsEditorClicker : WebElementClicker<DepartmentsEditorPageObject>
    {          
        public DepartmentsEditorClicker(AbstractWebDriverTest test, DepartmentsEditorPageObject view) : base(test, view) {}

        public override void Run()
        {
            Group("Проверка панели закладок [Панель_закладок]", 
    () => {
        SkipIfNotInteractable(_view => _view.Панель_закладок);
        var tpb2dc4bf26d2842799cfe2ad2fefc4775 = View.Панель_закладок;
        Step("Проверка вкладки [Должности]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Должности, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Должности]");
                View.Панель_закладок.Должности.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Должности);
                Step("Проверка вложенного элемента [Должности.Подразделение]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Должности.Должности_Подразделение);
                        Test.RunClicker<DepartmentsPositionsListClicker>(View.Панель_закладок.Должности.Должности_Подразделение);
                    }
                );
            }
        );
    }
);
        }                
    }
}