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
        /// Модель редактора 'Занимаемая должность подразделения'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Занимаемая должность подразделения")]
        public class CurrentPositionsDepartmentsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public CurrentPositionsDepartmentsEditorModel(){
        }
        /// <summary>
        /// Должность подразделения
        /// </summary>
        [BarsUp.Utils.Display("Должность подразделения")]
        [BarsUp.Utils.Attributes.Uid("ab8f4df2-bb87-4293-847e-d488615cdc83")]
        public virtual Bars.Stkomleks.DepartmentsPositionsListModel DepartmentPosition { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        [BarsUp.Utils.Display("Сотрудник")]
        [BarsUp.Utils.Attributes.Uid("062171fa-0c1d-4fa5-b31e-3d325d0f344e")]
        public virtual Bars.Stkomleks.StaffListModel Staff { get; set; }

        /// <summary>
        /// Свойство 'Начало'
        /// </summary>
        [BarsUp.Utils.Display("Начало")]
        [BarsUp.Utils.Attributes.Uid("f0555789-6bc1-4662-b7ec-ed7a8187b0fb")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? Start { get; set; }

        /// <summary>
        /// Свойство 'Завершение'
        /// </summary>
        [BarsUp.Utils.Display("Завершение")]
        [BarsUp.Utils.Attributes.Uid("d7767b20-476e-488e-9317-271ff8beb4c9")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? Finish { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("236ab0cb-e3d9-4611-a02c-670ae5464ea5")]
        public virtual System.String Comment { get; set; }

        }

}