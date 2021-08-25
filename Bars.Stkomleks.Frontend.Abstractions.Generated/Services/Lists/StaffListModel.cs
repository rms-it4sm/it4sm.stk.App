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
    /// Модель записи реестра 'Сотрудники.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Сотрудники.Организация")]
    public class StaffListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Individual
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Individual")]
        [BarsUp.Utils.Attributes.Uid("B251FADE422E20CFE18BC4EBEF24ACE4")]
        public virtual long? Individual_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Физ лицо.ФИО' (псевдоним: Individual_FIO)
        /// </summary>
        [BarsUp.Utils.Display("Физ лицо.ФИО")]
        [BarsUp.Utils.Attributes.Uid("498505c6-84b4-480f-a87b-d738613a2ff4")]
        public virtual System.String Individual_FIO { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("91ed3aa5-213c-40b8-88e6-bfd48ca8719f")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Organization
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Organization")]
        [BarsUp.Utils.Attributes.Uid("132A5B6C202C6CCB0881BDFF2F0A4066")]
        public virtual long? Organization_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Организация.Идентификатор' (псевдоним: Organization_Id)
        /// </summary>
        [BarsUp.Utils.Display("Организация.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("c3b470de-8054-484a-81b1-c3f4e090e951")]
        public virtual System.Int64? Organization_Id { get; set; }

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