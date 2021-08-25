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
    /// Модель записи реестра 'Организации'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Организации")]
    public class OrganizationListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Наименование' (псевдоним: Name)
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("5f31e805-105e-4050-8f0c-206e67390122")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Поле 'Полное наименование' (псевдоним: FullName)
        /// </summary>
        [BarsUp.Utils.Display("Полное наименование")]
        [BarsUp.Utils.Attributes.Uid("15c5cdb0-05de-4ad3-92d8-daed5fe5de5b")]
        public virtual System.String FullName { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("c311ec24-1523-4070-9ad2-4294efb0756a")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Статус записи
        /// </summary>
        [BarsUp.Utils.Display("Статус записи")]
        [BarsUp.Utils.Attributes.Uid("_State")]
        public virtual BarsUp.Modules.States.StateDTO _State { get; set; }

        /// <summary>
        /// Наименование статуса записи
        /// </summary>
        [BarsUp.Utils.Display("Наименование статуса записи")]
        [BarsUp.Utils.Attributes.Uid("_StateName")]
        public virtual string _StateName { get; set; }

        /// <summary>
        /// Идентификатор статуса записи
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор статуса записи")]
        [BarsUp.Utils.Attributes.Uid("_StateId")]
        public virtual long? _StateId { get; set; }

    }	

}