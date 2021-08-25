namespace Bars.Stkomleks
{
    using System;
    using System.Linq;
    using BarsUp;
    using BarsUp.DataAccess;
    using System.Collections.Generic;
        
    using BarsUp.Windsor;
    using BarsUp.IoC;
    using BarsUp.Utils;
    
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Designer.GeneratedApp.Editors;
    using BarsUp.Core.Exceptions;
    using BarsUp.Designer.Core;
    using BarsUp.Designer.Core.TypeSystem;
    using BarsUp.Designer.GeneratedApp.Commons;
    using BarsUp.Core.Serialization;

        /// <summary>
        /// Модель редактора 'Работа объекта'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Работа объекта")]
        public class CompositionWorksObjectsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public CompositionWorksObjectsEditorModel(){
        }
        /// <summary>
        /// Объект
        /// </summary>
        [BarsUp.Utils.Display("Объект")]
        [BarsUp.Utils.Attributes.Uid("2b8b0c57-d464-4752-9361-5696f0af7042")]
        public virtual Bars.Stkomleks.OrdersObjectsListModel ObjectWork { get; set; }

        /// <summary>
        /// Вид работы
        /// </summary>
        [BarsUp.Utils.Display("Вид работы")]
        [BarsUp.Utils.Attributes.Uid("a762a472-885d-4ce8-8109-14fb441047cb")]
        public virtual Bars.Stkomleks.TypesWorkTypesObjectsListModel WorkType { get; set; }

        /// <summary>
        /// Элемент объекта
        /// </summary>
        [BarsUp.Utils.Display("Элемент объекта")]
        [BarsUp.Utils.Attributes.Uid("f45a5a1f-42d8-4cb7-b20c-7c4d1aab7c29")]
        public virtual Bars.Stkomleks.ObjectProductsListModel ObjectElement { get; set; }

        /// <summary>
        /// Свойство 'Начало (план)'
        /// </summary>
        [BarsUp.Utils.Display("Начало (план)")]
        [BarsUp.Utils.Attributes.Uid("6b7a114e-df05-4f5a-a3dd-b2070e1ba00c")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? PlanStart { get; set; }

        /// <summary>
        /// Свойство 'Завершение (план)'
        /// </summary>
        [BarsUp.Utils.Display("Завершение (план)")]
        [BarsUp.Utils.Attributes.Uid("fa84fbec-e92b-4435-adeb-6d1d185cdc63")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? PlanFinish { get; set; }

        /// <summary>
        /// Свойство 'Способ выполнения'
        /// </summary>
        [BarsUp.Utils.Display("Способ выполнения")]
        [BarsUp.Utils.Attributes.Uid("e1d5e4c4-3020-4ea2-84c7-17d4e228ade9")]
        public virtual Bars.Stkomleks.TypesWorkPerformers? MethodWork { get; set; }

        /// <summary>
        /// Подрядчик
        /// </summary>
        [BarsUp.Utils.Display("Подрядчик")]
        [BarsUp.Utils.Attributes.Uid("b6a092b6-cd49-4b7b-b0d1-0c0c9b25b988")]
        public virtual Bars.Stkomleks.OrganizationProfilesList2Model ContractorWork { get; set; }

        /// <summary>
        /// Бригада
        /// </summary>
        [BarsUp.Utils.Display("Бригада")]
        [BarsUp.Utils.Attributes.Uid("d7aa4ba2-32fc-4a4f-9a3a-32c7519cc054")]
        public virtual Bars.Stkomleks.DepartmentsListModel Brigade { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("c0d4d8ce-0805-435a-bb42-f91a379fce3e")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Свойство 'Исполнитель'
        /// </summary>
        [BarsUp.Utils.Display("Исполнитель")]
        [BarsUp.Utils.Attributes.Uid("186250b8-243c-46dd-8485-aecd9df9c34d")]
        public virtual System.String Executor { get; set; }

        /// <summary>
        /// Статус записи
        /// </summary>
        [BarsUp.Utils.Display("Статус записи")]
        [BarsUp.Utils.Attributes.Uid("_State")]
        public virtual BarsUp.Modules.States.StateDTO _State { get; set; }

        }

}