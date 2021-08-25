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
    /// Класс-кликер, содержащий код для обхода редактора Объект.Изменение
    /// </summary>       
    [Display("Кликер редактора [Объект.Изменение]")]
    public class OrdersObjectsEditor_Copy_0Clicker : WebElementClicker<OrdersObjectsEditor_Copy_0PageObject>
    {          
        public OrdersObjectsEditor_Copy_0Clicker(AbstractWebDriverTest test, OrdersObjectsEditor_Copy_0PageObject view) : base(test, view) {}

        public override void Run()
        {
            Step("Проверка вложенного элемента [Объект.Создание]",
    () => 
    {
        SkipIfNotInteractable(_view => _view.Объект_Создание);
        Test.RunClicker<OrdersObjectsEditorClicker>(View.Объект_Создание);
    }
);
Group("Проверка панели закладок [Панель_закладок]", 
    () => {
        SkipIfNotInteractable(_view => _view.Панель_закладок);
        var tpa7490370204243eb8cdac3a847bab32c = View.Панель_закладок;
        Step("Проверка вкладки [Заказы]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Заказы, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Заказы]");
                View.Панель_закладок.Заказы.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Заказы);
                Step("Проверка вложенного элемента [Заказы.Объект]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Заказы.Заказы_Объект);
                        Test.RunClicker<ObjectsOrdersList2Clicker>(View.Панель_закладок.Заказы.Заказы_Объект);
                    }
                );
            }
        );
        Step("Проверка вкладки [Спецификация]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Спецификация, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Спецификация]");
                View.Панель_закладок.Спецификация.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Спецификация);
                Step("Проверка вложенного элемента [Спецификация.Объект]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Спецификация.Продукция_Объект);
                        Test.RunClicker<ObjectProductsListClicker>(View.Панель_закладок.Спецификация.Продукция_Объект);
                    }
                );
            }
        );
        Step("Проверка вкладки [Специалисты]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Специалисты, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Специалисты]");
                View.Панель_закладок.Специалисты.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Специалисты);
                Step("Проверка вложенного элемента [Специалисты.Объект]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Специалисты.Состав_специалистов_Объекта);
                        Test.RunClicker<CompositionObjectSpecialistsListClicker>(View.Панель_закладок.Специалисты.Состав_специалистов_Объекта);
                    }
                );
            }
        );
        Step("Проверка вкладки [Работы]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Работы, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Работы]");
                View.Панель_закладок.Работы.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Работы);
                Step("Проверка вложенного элемента [Работы.Объект]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Работы.Работы_Объект);
                        Test.RunClicker<CompositionWorksObjectsListClicker>(View.Панель_закладок.Работы.Работы_Объект);
                    }
                );
            }
        );
        Step("Проверка вкладки [Документы]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Документы, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Документы]");
                View.Панель_закладок.Документы.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Документы);
                Step("Проверка вложенного элемента [Документы.Объект]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Документы.Документы_Объект);
                        Test.RunClicker<ObjectsDocumentsListClicker>(View.Панель_закладок.Документы.Документы_Объект);
                    }
                );
            }
        );
    }
);
        }                
    }
}