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
    /// Модель записи реестра 'Контакты.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Контакты.Организация")]
    public class OrganizationContactsListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Type
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Type")]
        [BarsUp.Utils.Attributes.Uid("65ED59C95A0DA518730524AFF8E7FEB3")]
        public virtual long? Type_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Тип.Наименование' (псевдоним: Type_Name)
        /// </summary>
        [BarsUp.Utils.Display("Тип.Наименование")]
        [BarsUp.Utils.Attributes.Uid("272e62f2-f97c-42e5-b0a0-25197e44d78e")]
        public virtual System.String Type_Name { get; set; }

        /// <summary>
        /// Поле 'Контакт' (псевдоним: Contact)
        /// </summary>
        [BarsUp.Utils.Display("Контакт")]
        [BarsUp.Utils.Attributes.Uid("0d53186d-6a69-482f-98d8-a5d357c7bcea")]
        public virtual System.String Contact { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("3e04c7cd-3dc1-4b8e-8690-e02cbe98e0f9")]
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
        [BarsUp.Utils.Attributes.Uid("fd02eec9-cf92-423f-aa0a-c4faefce66d3")]
        public virtual System.Int64? Organization_Id { get; set; }

    }	

}