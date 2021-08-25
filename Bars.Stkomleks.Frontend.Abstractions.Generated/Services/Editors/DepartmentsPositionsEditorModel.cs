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
        /// Модель редактора 'Должность подразделения'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Должность подразделения")]
        public class DepartmentsPositionsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public DepartmentsPositionsEditorModel(){
        }
        /// <summary>
        /// Подразделение
        /// </summary>
        [BarsUp.Utils.Display("Подразделение")]
        [BarsUp.Utils.Attributes.Uid("2c050fdb-4916-4e3d-b8da-508462e9600a")]
        public virtual Bars.Stkomleks.DepartmentsListModel Department { get; set; }

        /// <summary>
        /// Вид
        /// </summary>
        [BarsUp.Utils.Display("Вид")]
        [BarsUp.Utils.Attributes.Uid("6bebd2c4-d428-4333-8a9d-2357a439a91b")]
        public virtual Bars.Stkomleks.PositionsTypesListModel Type { get; set; }

        /// <summary>
        /// Свойство 'Должность'
        /// </summary>
        [BarsUp.Utils.Display("Должность")]
        [BarsUp.Utils.Attributes.Uid("a3a81165-7954-4dcd-9e6e-e8da0f83eec2")]
        public virtual System.String Position { get; set; }

        }

}