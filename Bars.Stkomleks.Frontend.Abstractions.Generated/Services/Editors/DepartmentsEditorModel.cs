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
        /// Модель редактора 'Подразделение'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Подразделение")]
        public class DepartmentsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public DepartmentsEditorModel(){
        }
        /// <summary>
        /// Организация
        /// </summary>
        [BarsUp.Utils.Display("Организация")]
        [BarsUp.Utils.Attributes.Uid("90129f07-21b7-4503-91d6-ca0217b398e0")]
        public virtual Bars.Stkomleks.OrganizationListModel Organization { get; set; }

        /// <summary>
        /// Свойство 'Наименование'
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("4ca0d1ef-3e33-4fdc-b1ca-99e934fc0588")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Вид
        /// </summary>
        [BarsUp.Utils.Display("Вид")]
        [BarsUp.Utils.Attributes.Uid("53e57f8a-2b2d-4fde-92bd-2b7d4ebdad54")]
        public virtual Bars.Stkomleks.DepartmentsTypeListModel Type { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("cf3778c4-1dd0-40bd-b58d-a56e2cc1dc07")]
        public virtual System.String Comment { get; set; }

        }

}