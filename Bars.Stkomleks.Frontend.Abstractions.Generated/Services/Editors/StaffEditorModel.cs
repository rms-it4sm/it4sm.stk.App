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
        /// Модель редактора 'Сотрудник'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Сотрудник")]
        public class StaffEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public StaffEditorModel(){
        }
        /// <summary>
        /// Организация
        /// </summary>
        [BarsUp.Utils.Display("Организация")]
        [BarsUp.Utils.Attributes.Uid("8ea33522-4469-417c-aa77-ea5f9b462805")]
        public virtual Bars.Stkomleks.OrganizationListModel Organization { get; set; }

        /// <summary>
        /// Физ лицо
        /// </summary>
        [BarsUp.Utils.Display("Физ лицо")]
        [BarsUp.Utils.Attributes.Uid("a4ebc6df-c58b-4297-8a7c-04610638ae05")]
        public virtual Bars.Stkomleks.IndividualsListModel Individual { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("e3905ff8-9e8e-44e6-93fb-13dac3103cf5")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Статус записи
        /// </summary>
        [BarsUp.Utils.Display("Статус записи")]
        [BarsUp.Utils.Attributes.Uid("_State")]
        public virtual BarsUp.Modules.States.StateDTO _State { get; set; }

        }

}