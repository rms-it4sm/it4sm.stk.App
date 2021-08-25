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
        /// Модель редактора 'Тип объекта'
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("Тип объекта")]
        public class ObjectsTypesEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public ObjectsTypesEditorModel(){
        }
        /// <summary>
        /// Свойство 'Наименование'
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("a543d799-f327-40a3-b39f-c0a7e2dd658b")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Свойство 'Иконка'
        /// </summary>
        [BarsUp.Utils.Display("Иконка")]
        [BarsUp.Utils.Attributes.Uid("03c3dd4d-f056-4e5a-b0dd-47fd23e69b09")]
        public virtual System.String IconObjectType { get; set; }

        /// <summary>
        /// Свойство 'Цвет'
        /// </summary>
        [BarsUp.Utils.Display("Цвет")]
        [BarsUp.Utils.Attributes.Uid("cf8e7da9-9ef1-41ff-90ce-f71ec541f58e")]
        public virtual System.String ColorIconObjectType { get; set; }

        }

}