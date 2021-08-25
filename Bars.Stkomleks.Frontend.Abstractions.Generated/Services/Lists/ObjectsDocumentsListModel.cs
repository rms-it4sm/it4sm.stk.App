namespace Bars.Stkomleks
{
    using System;
    using System.Linq;
    using BarsUp;
    using BarsUp.DataAccess;
    using System.Collections.Generic;
    
    using System.Diagnostics;
    using BarsUp.Windsor;
    using BarsUp.IoC;
    using BarsUp.Utils;
    using Newtonsoft.Json;
    using BarsUp.Designer.GeneratedApp.Commons;
    using BarsUp.Core.Serialization;

    /// <summary>
    /// Модель записи реестра 'Документы.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Документы.Объект")]
    public class ObjectsDocumentsListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("ea8c0461-96ee-4284-966d-659d7545709b")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Поле 'Файл' (псевдоним: File)
        /// </summary>
        [BarsUp.Utils.Display("Скачать")]
        [BarsUp.Utils.Attributes.Uid("76347bed-514a-4aef-861c-7cc3a41c8750")]
        public virtual BarsUp.Modules.FileStorage.FileInfo File { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля ObjectWork
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля ObjectWork")]
        [BarsUp.Utils.Attributes.Uid("E0995849CF8BE7719A834B5C00C0E90B")]
        public virtual long? ObjectWork_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Объект.Идентификатор' (псевдоним: ObjectWork_Id)
        /// </summary>
        [BarsUp.Utils.Display("Объект.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("3331e6b3-479f-47cd-82af-735a78af9d66")]
        public virtual System.Int64? ObjectWork_Id { get; set; }

    }	

}