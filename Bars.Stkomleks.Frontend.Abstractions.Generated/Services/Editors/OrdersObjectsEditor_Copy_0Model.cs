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
        /// Модель редактора 'Объект.Изменение'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Объект.Изменение")]
        public class OrdersObjectsEditor_Copy_0Model : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public OrdersObjectsEditor_Copy_0Model(){
        }
        /// <summary>
        /// Свойство 'OrdersObjectsEditor'
        /// </summary>
        [BarsUp.Utils.Display("OrdersObjectsEditor")]
        [BarsUp.Utils.Attributes.Uid("OrdersObjectsEditor")]
        public virtual Bars.Stkomleks.OrdersObjectsEditorModel OrdersObjectsEditor { get; set; }

        /// <summary>
        /// Статус записи
        /// </summary>
        [BarsUp.Utils.Display("Статус записи")]
        [BarsUp.Utils.Attributes.Uid("_State")]
        public virtual BarsUp.Modules.States.StateDTO _State { get; set; }

        /// <summary>
        /// Свойство 'Наименование' (заголовок формы)
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        public virtual System.String Name { get; set; }

        }

}