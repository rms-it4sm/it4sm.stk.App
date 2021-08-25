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
        /// Модель редактора 'Ответственное лицо заказа'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Ответственное лицо заказа")]
        public class ResponsiblePersonsOrderEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public ResponsiblePersonsOrderEditorModel(){
        }
        /// <summary>
        /// Организация заказа
        /// </summary>
        [BarsUp.Utils.Display("Организация заказа")]
        [BarsUp.Utils.Attributes.Uid("3dfdd012-7ea1-47fa-86d7-10aaa70d0ab2")]
        public virtual Bars.Stkomleks.OrderOrganizationListModel OrderOrganization { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        [BarsUp.Utils.Display("Сотрудник")]
        [BarsUp.Utils.Attributes.Uid("cca396ee-fdd6-4e2a-9d9c-44007b0c8690")]
        public virtual Bars.Stkomleks.StaffListModel Staff { get; set; }

        /// <summary>
        /// Свойство 'Назначение'
        /// </summary>
        [BarsUp.Utils.Display("Назначение")]
        [BarsUp.Utils.Attributes.Uid("cc815e19-f5bd-42ae-801b-00cf22861ec0")]
        public virtual System.String Appointment { get; set; }

        }

}