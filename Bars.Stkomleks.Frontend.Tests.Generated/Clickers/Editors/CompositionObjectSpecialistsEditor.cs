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
    /// Класс-кликер, содержащий код для обхода редактора Специалист объекта
    /// </summary>       
    [Display("Кликер редактора [Специалист объекта]")]
    public class CompositionObjectSpecialistsEditorClicker : WebElementClicker<CompositionObjectSpecialistsEditorPageObject>
    {          
        public CompositionObjectSpecialistsEditorClicker(AbstractWebDriverTest test, CompositionObjectSpecialistsEditorPageObject view) : base(test, view) {}

        public override void Run()
        {
                    }                
    }
}