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
    /// Класс-кликер, содержащий код для обхода редактора Занимаемая должность подразделения
    /// </summary>       
    [Display("Кликер редактора [Занимаемая должность подразделения]")]
    public class CurrentPositionsDepartmentsEditorClicker : WebElementClicker<CurrentPositionsDepartmentsEditorPageObject>
    {          
        public CurrentPositionsDepartmentsEditorClicker(AbstractWebDriverTest test, CurrentPositionsDepartmentsEditorPageObject view) : base(test, view) {}

        public override void Run()
        {
                    }                
    }
}