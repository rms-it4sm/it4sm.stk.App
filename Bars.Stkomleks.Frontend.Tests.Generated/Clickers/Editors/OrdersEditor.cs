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
    /// Класс-кликер, содержащий код для обхода редактора Заказ
    /// </summary>       
    [Display("Кликер редактора [Заказ]")]
    public class OrdersEditorClicker : WebElementClicker<OrdersEditorPageObject>
    {          
        public OrdersEditorClicker(AbstractWebDriverTest test, OrdersEditorPageObject view) : base(test, view) {}

        public override void Run()
        {
            Group("Проверка панели закладок [Панель_закладок]", 
    () => {
        SkipIfNotInteractable(_view => _view.Панель_закладок);
        var tpad1048a91e9a4773857839eb33d882d9 = View.Панель_закладок;
        Step("Проверка вкладки [Объекты]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Объекты, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Объекты]");
                View.Панель_закладок.Объекты.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Объекты);
                Step("Проверка вложенного элемента [Объекты.Заказа]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Объекты.Объекты_Заказа);
                        Test.RunClicker<ObjectsOrdersListClicker>(View.Панель_закладок.Объекты.Объекты_Заказа);
                    }
                );
            }
        );
        Step("Проверка вкладки [Организации]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Организации, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Организации]");
                View.Панель_закладок.Организации.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Организации);
                Step("Проверка вложенного элемента [Организации.Заказ]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Организации.Организации_Заказ);
                        Test.RunClicker<OrderOrganizationListClicker>(View.Панель_закладок.Организации.Организации_Заказ);
                    }
                );
            }
        );
    }
);
        }                
    }
}