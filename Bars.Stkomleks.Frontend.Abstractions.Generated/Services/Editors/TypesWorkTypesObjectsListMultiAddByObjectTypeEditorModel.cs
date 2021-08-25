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
        /// Модель редактора ''
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("")]
        public class TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public TypesWorkTypesObjectsListMultiAddByObjectTypeEditorModel(){
        }
        /// <summary>
        /// Тип объекта
        /// </summary>
        [BarsUp.Utils.Display("Тип объекта")]
        [BarsUp.Utils.Attributes.Uid("ebdd5fe9-9210-f16b-7757-e1f143f913ff")]
        public virtual Bars.Stkomleks.ObjectsTypesListModel ObjectType { get; set; }

        /// <summary>
        /// Вид работы
        /// </summary>
        [BarsUp.Utils.Display("Вид работы")]
        [BarsUp.Utils.Attributes.Uid("1399e726-b041-b66e-68e9-9f46ac1eeba5")]
        public virtual Bars.Stkomleks.WorksTypesListModel WorkType { get; set; }

        }

}