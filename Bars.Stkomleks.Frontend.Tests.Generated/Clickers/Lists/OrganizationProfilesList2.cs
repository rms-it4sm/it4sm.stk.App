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
    /// Класс-кликер, содержащий код для обхода списка Организации по профилю.Выбор
    /// </summary>       
    [Display("Кликер списка [Организации по профилю.Выбор]")]
    [Display("Список [Организации по профилю.Выбор]")]
    public class OrganizationProfilesList2Clicker : WebElementClicker<OrganizationProfilesList2PageObject>
    {          
        public OrganizationProfilesList2Clicker(AbstractWebDriverTest test, OrganizationProfilesList2PageObject view) : base(test, view) {}

        public override void Run()
        {
            Group("Проверяем представление [Организации по профилю.Выбор]", 
    () => 
    {
        SkipIfConditionFails(_view => _view, 
            (x => x.IsInteractable(), "Представление скрыто или выключено"),
            (x => !x.IsCollapsed(), "Представление свернуто")
        );
        Step("Возможность обновления кнопкой [Обновить]", 
            () => {
                SkipIfNotInteractable(_view => _view.Верхняя_панель.Обновить);
                Log.WriteLine("Нажимаем на кнопку [Обновить]");
                View.Верхняя_панель.Обновить.Click();
            }
        );
    }
);
        }                
    }
}