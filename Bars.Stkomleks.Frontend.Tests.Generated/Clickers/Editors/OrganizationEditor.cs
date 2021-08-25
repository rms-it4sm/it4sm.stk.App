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
    /// Класс-кликер, содержащий код для обхода редактора Организация
    /// </summary>       
    [Display("Кликер редактора [Организация]")]
    public class OrganizationEditorClicker : WebElementClicker<OrganizationEditorPageObject>
    {          
        public OrganizationEditorClicker(AbstractWebDriverTest test, OrganizationEditorPageObject view) : base(test, view) {}

        public override void Run()
        {
            Group("Проверка панели закладок [Панель_закладок]", 
    () => {
        SkipIfNotInteractable(_view => _view.Панель_закладок);
        var tpde543d874d9641a19b6555b7f356e7ee = View.Панель_закладок;
        Step("Проверка вкладки [Контакты]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Контакты, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Контакты]");
                View.Панель_закладок.Контакты.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Контакты);
                Step("Проверка вложенного элемента [Контакты.Организация]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Контакты.Контакты_Организация);
                        Test.RunClicker<OrganizationContactsListClicker>(View.Панель_закладок.Контакты.Контакты_Организация);
                    }
                );
            }
        );
        Step("Проверка вкладки [Подразделения]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Подразделения, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Подразделения]");
                View.Панель_закладок.Подразделения.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Подразделения);
                Step("Проверка вложенного элемента [Подразделения.Организация]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Подразделения.Подразделения_Организация);
                        Test.RunClicker<DepartmentsListClicker>(View.Панель_закладок.Подразделения.Подразделения_Организация);
                    }
                );
            }
        );
        Step("Проверка вкладки [Сотрудники]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Сотрудники, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Сотрудники]");
                View.Панель_закладок.Сотрудники.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Сотрудники);
                Step("Проверка вложенного элемента [Сотрудники.Организация]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Сотрудники.Сотрудники_Организация);
                        Test.RunClicker<StaffListClicker>(View.Панель_закладок.Сотрудники.Сотрудники_Организация);
                    }
                );
            }
        );
        Step("Проверка вкладки [Программы финансирования]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Программы_финансирования, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Программы финансирования]");
                View.Панель_закладок.Программы_финансирования.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Программы_финансирования);
                Step("Проверка вложенного элемента [Программы.Организация]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Программы_финансирования.Программы_Организация);
                        Test.RunClicker<OrganizationFundingProgramsListClicker>(View.Панель_закладок.Программы_финансирования.Программы_Организация);
                    }
                );
            }
        );
        Step("Проверка вкладки [Профили]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Профили, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Профили]");
                View.Панель_закладок.Профили.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Профили);
                Step("Проверка вложенного элемента [Профили.Организация]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Профили.Профили_Организация);
                        Test.RunClicker<OrganizationProfilesListClicker>(View.Панель_закладок.Профили.Профили_Организация);
                    }
                );
            }
        );
        Step("Проверка вкладки [Взаимосвязанные организации]",
            () => {
                SkipIfConditionFails(_view => _view.Панель_закладок.Взаимосвязанные_организации, t => t.IsTabVisible(), "Вкладка [@display] скрыта или выключена");
                Log.WriteLine("Активация вкладки [Взаимосвязанные организации]");
                View.Панель_закладок.Взаимосвязанные_организации.Activate();
                SkipIfNotInteractable(_view => _view.Панель_закладок.Взаимосвязанные_организации);
                Step("Проверка вложенного элемента [Связанные организации.Организация]",
                    () => 
                    {
                        SkipIfNotInteractable(_view => _view.Панель_закладок.Взаимосвязанные_организации.Связанные_организации_Организация);
                        Test.RunClicker<RelatedOrganizationsListClicker>(View.Панель_закладок.Взаимосвязанные_организации.Связанные_организации_Организация);
                    }
                );
            }
        );
    }
);
        }                
    }
}