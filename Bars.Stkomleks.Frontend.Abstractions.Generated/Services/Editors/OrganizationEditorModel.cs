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
        /// Модель редактора 'Организация'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Организация")]
        public class OrganizationEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public OrganizationEditorModel(){
        }
        /// <summary>
        /// Свойство 'Наименование'
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("8967b231-f09f-444d-8ebf-df640d6e5ea7")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Свойство 'Полное наименование'
        /// </summary>
        [BarsUp.Utils.Display("Полное наименование")]
        [BarsUp.Utils.Attributes.Uid("d9aaab32-d046-44a2-9640-5112287c8446")]
        public virtual System.String FullName { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("5803587b-88bc-4dc9-9b20-69f8c6fbe17c")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Статус записи
        /// </summary>
        [BarsUp.Utils.Display("Статус записи")]
        [BarsUp.Utils.Attributes.Uid("_State")]
        public virtual BarsUp.Modules.States.StateDTO _State { get; set; }

        }

}