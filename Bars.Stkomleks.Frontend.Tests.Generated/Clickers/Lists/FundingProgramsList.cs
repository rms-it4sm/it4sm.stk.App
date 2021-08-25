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
    /// Класс-кликер, содержащий код для обхода списка Программы финансирования
    /// </summary>       
    [Display("Кликер списка [Программы финансирования]")]
    [Display("Список [Программы финансирования]")]
    public class FundingProgramsListClicker : WebElementClicker<FundingProgramsListPageObject>
    {          
        public FundingProgramsListClicker(AbstractWebDriverTest test, FundingProgramsListPageObject view) : base(test, view) {}

        public override void Run()
        {
            Group("Проверяем представление [Программы финансирования]", 
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
        Log.WriteLine("Получаем записи первой страницы");
        var records = View.GetRecords();

        if (Test.ListViewRecordsToProcess != null)
        {
            records = records.Take(Test.ListViewRecordsToProcess.Value).ToArray();
        }
        Step("Обходим записи и открываем каждую на редактирование", 
            () => {
                SetStepProperty("RecordsCount", records.Length);
                Step("Открытие записи редактором [Программа финансирования]", 
                    () => {
                        SkipIfNotInteractable(_view => _view.Верхняя_панель.Редактировать);
                        for (var index = 0; index < records.Length; index++) {
                            Step($"Открытие редактора для записи #{index}", 
                                () => {
                                    View.SelectRecordByIndex(index);
                                    var editor = View.Верхняя_панель.Редактировать.Edit();
                                    if (editor == null)
                                    {
                                        Fail(WellKnownUiFailures.CouldNotOpenEditor(records[index], View.Верхняя_панель.Редактировать));
                                    }
                                    else
                                    {
                                        Test.RunClicker<FundingProgramsEditorClicker>(editor);
                                        editor.Close();
                                    }
                                }
                            );
                        }
                    }
                );
            }
        );
    }
);
        }                
    }
}