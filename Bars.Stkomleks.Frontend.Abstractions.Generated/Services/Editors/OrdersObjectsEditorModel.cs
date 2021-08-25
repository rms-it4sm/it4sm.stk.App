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
        /// Модель редактора 'Объект.Создание'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Объект.Создание")]
        public class OrdersObjectsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public OrdersObjectsEditorModel(){
        }
        /// <summary>
        /// Заказ
        /// </summary>
        [BarsUp.Utils.Display("Заказ")]
        [BarsUp.Utils.Attributes.Uid("faa15d75-45a3-402c-ba44-7328200f8326")]
        public virtual Bars.Stkomleks.OrdersListModel Zakaz { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        [BarsUp.Utils.Display("Тип")]
        [BarsUp.Utils.Attributes.Uid("0f18129a-9cc4-4822-9706-7b4c8d14676c")]
        public virtual Bars.Stkomleks.ObjectsTypesListModel Type { get; set; }

        /// <summary>
        /// Свойство 'Наименование'
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("150c18a2-54b7-4d5b-b5fb-b2d3ae7ab13c")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("c2f57d34-eddd-48ee-b6f6-208376814756")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Свойство 'Lon'
        /// </summary>
        [BarsUp.Utils.Display("Lon")]
        [BarsUp.Utils.Attributes.Uid("8bb2e4f1-bf2d-4361-9606-af21cceb166a")]
        public virtual System.String Lon { get; set; }

        /// <summary>
        /// Свойство 'Lat'
        /// </summary>
        [BarsUp.Utils.Display("Lat")]
        [BarsUp.Utils.Attributes.Uid("62f42c68-2733-4d24-b244-269f4f5d73be")]
        public virtual System.String Lat { get; set; }

        /// <summary>
        /// Статус записи
        /// </summary>
        [BarsUp.Utils.Display("Статус записи")]
        [BarsUp.Utils.Attributes.Uid("_State")]
        public virtual BarsUp.Modules.States.StateDTO _State { get; set; }

        }

}