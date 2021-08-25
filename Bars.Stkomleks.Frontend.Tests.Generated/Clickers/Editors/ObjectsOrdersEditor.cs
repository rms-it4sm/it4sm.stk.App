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
    /// Класс-кликер, содержащий код для обхода редактора Объект заказа
    /// </summary>       
    [Display("Кликер редактора [Объект заказа]")]
    public class ObjectsOrdersEditorClicker : WebElementClicker<ObjectsOrdersEditorPageObject>
    {          
        public ObjectsOrdersEditorClicker(AbstractWebDriverTest test, ObjectsOrdersEditorPageObject view) : base(test, view) {}

        public override void Run()
        {
            Step("Проверка вложенного элемента [Объект.Создание]",
    () => 
    {
        SkipIfNotInteractable(_view => _view.Объект_Создание);
        Test.RunClicker<OrdersObjectsEditorClicker>(View.Объект_Создание);
    }
);
        }                
    }
}