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
        /// Модель редактора 'Физическое лицо'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Физическое лицо")]
        public class IndividualsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public IndividualsEditorModel(){
        }
        /// <summary>
        /// Свойство 'Фамилия'
        /// </summary>
        [BarsUp.Utils.Display("Фамилия")]
        [BarsUp.Utils.Attributes.Uid("ace72536-1b25-42f3-8d96-50882e457efd")]
        public virtual System.String Surname { get; set; }

        /// <summary>
        /// Свойство 'Имя'
        /// </summary>
        [BarsUp.Utils.Display("Имя")]
        [BarsUp.Utils.Attributes.Uid("5591bf2a-a7fc-416d-aea3-bea89ec4953e")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Свойство 'Отчество'
        /// </summary>
        [BarsUp.Utils.Display("Отчество")]
        [BarsUp.Utils.Attributes.Uid("d8115caf-502d-43fd-bef2-0a8d5c903ed5")]
        public virtual System.String Patronymic { get; set; }

        /// <summary>
        /// Свойство 'ФИО'
        /// </summary>
        [BarsUp.Utils.Display("ФИО")]
        [BarsUp.Utils.Attributes.Uid("2d48ca36-49f4-4fa4-9b69-366d793a51fa")]
        public virtual System.String FIO { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("c2758611-1346-4bcf-9ba2-db34beef7c63")]
        public virtual System.String Comment { get; set; }

        }

}