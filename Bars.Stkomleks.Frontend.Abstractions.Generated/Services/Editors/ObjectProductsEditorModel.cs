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
        /// Модель редактора 'Элемент объекта'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Элемент объекта")]
        public class ObjectProductsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public ObjectProductsEditorModel(){
        }
        /// <summary>
        /// Объект
        /// </summary>
        [BarsUp.Utils.Display("Объект")]
        [BarsUp.Utils.Attributes.Uid("3cf94cb1-42e9-4254-afca-c28c08e691ec")]
        public virtual Bars.Stkomleks.OrdersObjectsListModel ObjectOrder { get; set; }

        /// <summary>
        /// Свойство 'Код элемента'
        /// </summary>
        [BarsUp.Utils.Display("Код элемента")]
        [BarsUp.Utils.Attributes.Uid("cbc724ed-f3cb-4bdf-a0c4-ae359b86385d")]
        public virtual System.String Code { get; set; }

        /// <summary>
        /// Тип элемента
        /// </summary>
        [BarsUp.Utils.Display("Тип элемента")]
        [BarsUp.Utils.Attributes.Uid("43f0269e-c14c-4220-acbd-88f6319e957d")]
        public virtual Bars.Stkomleks.ProductsTypesListModel TypeElement { get; set; }

        /// <summary>
        /// Свойство 'Количество'
        /// </summary>
        [BarsUp.Utils.Display("Количество")]
        [BarsUp.Utils.Attributes.Uid("dbd3ce47-2b79-4a9b-834c-4201d5ad71a1")]
        public virtual System.Double? Quantity { get; set; }

        /// <summary>
        /// Ед. изм.
        /// </summary>
        [BarsUp.Utils.Display("Ед. изм.")]
        [BarsUp.Utils.Attributes.Uid("ae31252f-4c9d-47e3-a3b3-ea28b0c91aa4")]
        public virtual Bars.Stkomleks.UnitMeasureListModel UnitMeasure { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("10141fa8-9345-49e2-9689-d39c659d81a4")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Свойство 'Тип элемента.Наименование' (заголовок формы)
        /// </summary>
        [BarsUp.Utils.Display("Тип элемента.Наименование")]
        public virtual System.String TypeElement_Name { get; set; }

        }

}