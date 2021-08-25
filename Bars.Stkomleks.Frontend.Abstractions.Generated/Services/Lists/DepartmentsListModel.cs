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
    /// Модель записи реестра 'Подразделения.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Подразделения.Организация")]
    public class DepartmentsListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Наименование' (псевдоним: Name)
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("12957709-1018-44d5-b00a-6f45fd58876e")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Type
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Type")]
        [BarsUp.Utils.Attributes.Uid("65ED59C95A0DA518730524AFF8E7FEB3")]
        public virtual long? Type_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Вид.Наименование' (псевдоним: Type_Name)
        /// </summary>
        [BarsUp.Utils.Display("Вид.Наименование")]
        [BarsUp.Utils.Attributes.Uid("41cfa364-2925-44a2-a571-02328fb371e0")]
        public virtual System.String Type_Name { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("b75abce6-1085-4c04-947d-5978bcfb680e")]
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
        [BarsUp.Utils.Attributes.Uid("c427a2cd-e03b-4dfc-b39c-2e7b1c350fad")]
        public virtual System.Int64? Organization_Id { get; set; }

    }	

}