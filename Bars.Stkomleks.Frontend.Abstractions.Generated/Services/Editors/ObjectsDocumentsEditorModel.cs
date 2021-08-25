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
        /// Модель редактора 'Документ объекта'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Документ объекта")]
        public class ObjectsDocumentsEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public ObjectsDocumentsEditorModel(){
        }
        /// <summary>
        /// Объект
        /// </summary>
        [BarsUp.Utils.Display("Объект")]
        [BarsUp.Utils.Attributes.Uid("bc491af1-a8fe-45bd-b9fb-b80dfe7fde76")]
        public virtual Bars.Stkomleks.OrdersObjectsListModel ObjectWork { get; set; }

        /// <summary>
        /// Файл
        /// </summary>
        [BarsUp.Utils.Display("Файл")]
        [BarsUp.Utils.Attributes.Uid("File")]
        public virtual BarsUp.Modules.FileStorage.FileInfo File { get; set; }

        /// <summary>
        /// Свойство 'Описание'
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("702cdb2a-2f51-4656-aa02-c13fc875c177")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Свойство 'Файл.Name' (заголовок формы)
        /// </summary>
        [BarsUp.Utils.Display("Файл.Name")]
        public virtual System.String File_Name { get; set; }

        }
        /// <summary>
        /// Модель для отображения свойства 'Файл'
        /// </summary>
        public class ObjectsDocumentsEditorFileControlModel {
        /// <summary>
        /// Свойство 'Документы объекта.Файл.Идентификатор'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Документы объекта.Файл.Идентификатор")]
        public System.Int64? Id { get; set; } 
        }

}