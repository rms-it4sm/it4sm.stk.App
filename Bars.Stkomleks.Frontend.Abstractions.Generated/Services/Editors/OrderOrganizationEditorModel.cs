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
        /// Модель редактора 'Организация заказа'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Организация заказа")]
        public class OrderOrganizationEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public OrderOrganizationEditorModel(){
        }
        /// <summary>
        /// Заказ
        /// </summary>
        [BarsUp.Utils.Display("Заказ")]
        [BarsUp.Utils.Attributes.Uid("06e1b195-0b50-4691-8a48-01e826ef8311")]
        public virtual Bars.Stkomleks.OrdersListModel Zakaz { get; set; }

        /// <summary>
        /// Профиль
        /// </summary>
        [BarsUp.Utils.Display("Профиль")]
        [BarsUp.Utils.Attributes.Uid("213f9170-9e05-426a-9529-8394defefd3c")]
        public virtual Bars.Stkomleks.ProfilesOrganizationsListModel Profile { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        [BarsUp.Utils.Display("Организация")]
        [BarsUp.Utils.Attributes.Uid("c3b85dc8-9185-4dcd-8290-3412f84ebbbb")]
        public virtual Bars.Stkomleks.OrganizationProfilesList2Model Organization { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("0405b220-229b-44b3-9e70-9ca4ae8de489")]
        public virtual System.String Comment { get; set; }

        }

}