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
        /// Модель редактора 'Заказ'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Заказ")]
        public class OrdersEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public OrdersEditorModel(){
        }
        /// <summary>
        /// Свойство 'Номер'
        /// </summary>
        [BarsUp.Utils.Display("Номер")]
        [BarsUp.Utils.Attributes.Uid("90d74d06-9e1c-4bae-91cc-f8a54ec861fd")]
        public virtual System.String Number { get; set; }

        /// <summary>
        /// Свойство 'Дата'
        /// </summary>
        [BarsUp.Utils.Display("Дата")]
        [BarsUp.Utils.Attributes.Uid("b477d19c-aee8-4e02-b1d0-839b34b76598")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? Date { get; set; }

        /// <summary>
        /// Заказчик
        /// </summary>
        [BarsUp.Utils.Display("Заказчик")]
        [BarsUp.Utils.Attributes.Uid("1adc66bb-f2a6-42f2-ad47-bca4ec7f7b25")]
        public virtual Bars.Stkomleks.OrganizationProfilesListModel Client { get; set; }

        /// <summary>
        /// Менеджер
        /// </summary>
        [BarsUp.Utils.Display("Менеджер")]
        [BarsUp.Utils.Attributes.Uid("f42a0cdf-dc4b-4211-a0ef-e4652a986169")]
        public virtual Bars.Stkomleks.StaffListModel Manager { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("67de81d6-9c11-46ab-b862-7c352b920943")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Статус записи
        /// </summary>
        [BarsUp.Utils.Display("Статус записи")]
        [BarsUp.Utils.Attributes.Uid("_State")]
        public virtual BarsUp.Modules.States.StateDTO _State { get; set; }

        }

}