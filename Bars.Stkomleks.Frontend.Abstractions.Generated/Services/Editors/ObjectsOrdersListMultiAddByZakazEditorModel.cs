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
        /// Модель редактора ''
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("")]
        public class ObjectsOrdersListMultiAddByZakazEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public ObjectsOrdersListMultiAddByZakazEditorModel(){
        }
        /// <summary>
        /// Заказ
        /// </summary>
        [BarsUp.Utils.Display("Заказ")]
        [BarsUp.Utils.Attributes.Uid("d1f930be-a7aa-6faa-bc4f-1ee7902ff55e")]
        public virtual Bars.Stkomleks.OrdersListModel Zakaz { get; set; }

        /// <summary>
        /// Объект
        /// </summary>
        [BarsUp.Utils.Display("Объект")]
        [BarsUp.Utils.Attributes.Uid("896813d8-7b87-e74b-2185-d568ade68d51")]
        public virtual Bars.Stkomleks.OrdersObjectsListModel Object { get; set; }

        }

}