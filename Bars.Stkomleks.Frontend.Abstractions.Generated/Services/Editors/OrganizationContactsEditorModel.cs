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
        /// Модель редактора 'Контакт организации'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Контакт организации")]
        public class OrganizationContactsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public OrganizationContactsEditorModel(){
        }
        /// <summary>
        /// Организация
        /// </summary>
        [BarsUp.Utils.Display("Организация")]
        [BarsUp.Utils.Attributes.Uid("5bc8a725-8141-4786-8b89-295f6a741051")]
        public virtual Bars.Stkomleks.OrganizationListModel Organization { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        [BarsUp.Utils.Display("Тип")]
        [BarsUp.Utils.Attributes.Uid("0716e607-5126-4514-9753-10e22e55cf33")]
        public virtual Bars.Stkomleks.ContactsTypeListModel Type { get; set; }

        /// <summary>
        /// Свойство 'Контакт'
        /// </summary>
        [BarsUp.Utils.Display("Контакт")]
        [BarsUp.Utils.Attributes.Uid("8e2f1526-27be-49c5-ace5-4d75e6a0fd66")]
        public virtual System.String Contact { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("cdf68203-272f-439b-af3a-2fd2f8b799d5")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Свойство 'Тип.Наименование' (заголовок формы)
        /// </summary>
        [BarsUp.Utils.Display("Тип.Наименование")]
        public virtual System.String Type_Name { get; set; }

        }

}