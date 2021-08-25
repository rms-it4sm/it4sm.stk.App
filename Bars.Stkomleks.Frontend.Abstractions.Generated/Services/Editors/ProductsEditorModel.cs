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
        /// Модель редактора 'Комплектация'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Комплектация")]
        public class ProductsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public ProductsEditorModel(){
        }
        /// <summary>
        /// Спецификация объекта
        /// </summary>
        [BarsUp.Utils.Display("Спецификация объекта")]
        [BarsUp.Utils.Attributes.Uid("a4fcea41-0bd7-4e57-b40f-84be3a26bdd6")]
        public virtual Bars.Stkomleks.ObjectProductsListModel ObjectSpecification { get; set; }

        /// <summary>
        /// Поставщик
        /// </summary>
        [BarsUp.Utils.Display("Поставщик")]
        [BarsUp.Utils.Attributes.Uid("5c01b211-328b-4411-af83-92a396fb1415")]
        public virtual Bars.Stkomleks.OrganizationProfilesList2Model Supplier { get; set; }

        /// <summary>
        /// Свойство 'Товар'
        /// </summary>
        [BarsUp.Utils.Display("Товар")]
        [BarsUp.Utils.Attributes.Uid("698065ac-da84-461b-954d-e6bf595e4b6a")]
        public virtual System.String Product { get; set; }

        /// <summary>
        /// Свойство 'Артикул'
        /// </summary>
        [BarsUp.Utils.Display("Артикул")]
        [BarsUp.Utils.Attributes.Uid("134ea4b8-c2e4-4074-ae90-7f31bb973ffe")]
        public virtual System.String Code { get; set; }

        /// <summary>
        /// Свойство 'Количество'
        /// </summary>
        [BarsUp.Utils.Display("Количество")]
        [BarsUp.Utils.Attributes.Uid("b4bf1062-5fcf-4b02-b950-931c203c39e1")]
        public virtual System.Double? Quantity { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("5513760a-45b7-40bf-a245-aab20206ea14")]
        public virtual System.String Comment { get; set; }

        }

}