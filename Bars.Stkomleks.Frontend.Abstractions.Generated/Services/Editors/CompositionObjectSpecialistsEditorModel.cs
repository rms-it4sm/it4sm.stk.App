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
        /// Модель редактора 'Специалист объекта'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Специалист объекта")]
        public class CompositionObjectSpecialistsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public CompositionObjectSpecialistsEditorModel(){
        }
        /// <summary>
        /// Объект
        /// </summary>
        [BarsUp.Utils.Display("Объект")]
        [BarsUp.Utils.Attributes.Uid("ee6aac1d-7f16-447d-a4f8-d47f06134b29")]
        public virtual Bars.Stkomleks.OrdersObjectsListModel Object { get; set; }

        /// <summary>
        /// Роль
        /// </summary>
        [BarsUp.Utils.Display("Роль")]
        [BarsUp.Utils.Attributes.Uid("5d246691-97db-4aa2-a56d-1c4312ad6807")]
        public virtual Bars.Stkomleks.WorksRolesListModel Role { get; set; }

        /// <summary>
        /// Сотрудник
        /// </summary>
        [BarsUp.Utils.Display("Сотрудник")]
        [BarsUp.Utils.Attributes.Uid("1c2fe304-8ce2-4934-94fe-83cade766219")]
        public virtual Bars.Stkomleks.CurrentPositionsDepartmentsListModel Staff { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("884058c1-498e-497b-8708-e894edb22a80")]
        public virtual System.String Comment { get; set; }

        }

}