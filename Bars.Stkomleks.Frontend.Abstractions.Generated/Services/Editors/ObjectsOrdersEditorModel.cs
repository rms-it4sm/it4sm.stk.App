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
        /// Модель редактора 'Объект заказа'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Объект заказа")]
        public class ObjectsOrdersEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public ObjectsOrdersEditorModel(){
        }
        /// <summary>
        /// Заказ
        /// </summary>
        [BarsUp.Utils.Display("Заказ")]
        [BarsUp.Utils.Attributes.Uid("f974f997-c8e5-4942-82dd-c6ce4a07669e")]
        public virtual Bars.Stkomleks.OrdersListModel Zakaz { get; set; }

        /// <summary>
        /// Идентификатор 'Объект'
        /// </summary>
        [BarsUp.Utils.Display("Объект")]
        [BarsUp.Utils.Attributes.Uid("Object_Id")]
        public virtual System.Int64? Object_Id { get; set; }

        /// <summary>
        /// Свойство 'Объект'
        /// </summary>
        [BarsUp.Utils.Display("Объект")]
        [BarsUp.Utils.Attributes.Uid("Object")]
        public virtual Bars.Stkomleks.OrdersObjectsEditorModel Object { get; set; }

        }
        /// <summary>
        /// Модель для отображения свойства 'Объект'
        /// </summary>
        public class ObjectsOrdersEditorObjectControlModel {
        /// <summary>
        /// Свойство 'Заказы Объекты.Объект.Идентификатор'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Заказы Объекты.Объект.Идентификатор")]
        public System.Int64? Id { get; set; } 
        }

}