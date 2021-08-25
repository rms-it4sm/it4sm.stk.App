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
    /// Модель записи реестра 'Организации.Заказ'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Организации.Заказ")]
    public class OrderOrganizationListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Organization
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Organization")]
        [BarsUp.Utils.Attributes.Uid("132A5B6C202C6CCB0881BDFF2F0A4066")]
        public virtual long? Organization_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Организация.Организация.Наименование' (псевдоним: Organization_Organization_Name)
        /// </summary>
        [BarsUp.Utils.Display("Организация.Организация.Наименование")]
        [BarsUp.Utils.Attributes.Uid("e9a2560f-e833-4f5e-b71b-eb528853e39f")]
        public virtual System.String Organization_Organization_Name { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Profile
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Profile")]
        [BarsUp.Utils.Attributes.Uid("5AD03F1615217DA6B168F42DB8640D1C")]
        public virtual long? Profile_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Профиль.Наименование' (псевдоним: Profile_Name)
        /// </summary>
        [BarsUp.Utils.Display("Профиль.Наименование")]
        [BarsUp.Utils.Attributes.Uid("72c7e258-1b64-4267-8d76-5fa64baa1939")]
        public virtual System.String Profile_Name { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("21aa6105-7e06-49b5-bded-3d4bda34192c")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Zakaz
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Zakaz")]
        [BarsUp.Utils.Attributes.Uid("8710FBCC671B5AFB953FE5E7C74E598B")]
        public virtual long? Zakaz_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Заказ.Идентификатор' (псевдоним: Zakaz_Id)
        /// </summary>
        [BarsUp.Utils.Display("Заказ.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("b887602f-423b-441d-a580-f7a98f3cae56")]
        public virtual System.Int64? Zakaz_Id { get; set; }

        /// <summary>
        /// Поле 'Организация.Идентификатор' (псевдоним: Organization_Id)
        /// </summary>
        [BarsUp.Utils.Display("Организация.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("a772b6cb-bfa7-4b87-91c5-840c1b1673d5")]
        public virtual System.Int64? Organization_Id { get; set; }

    }	

}