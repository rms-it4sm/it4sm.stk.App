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
    /// Модель записи реестра 'Профили.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Профили.Организация")]
    public class OrganizationProfilesListModel  : DataTransferObject
    {
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
        [BarsUp.Utils.Attributes.Uid("dc2bd87a-ff12-4eb0-b69a-38f38fd8d625")]
        public virtual System.Int64? Organization_Id { get; set; }

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
        [BarsUp.Utils.Attributes.Uid("901e4efa-b5ec-4754-b117-2b7c717a19f6")]
        public virtual System.String Profile_Name { get; set; }

        /// <summary>
        /// Поле 'Организация.Наименование' (псевдоним: Organization_Name)
        /// </summary>
        [BarsUp.Utils.Display("Организация.Наименование")]
        [BarsUp.Utils.Attributes.Uid("e7d95c71-8599-4e6d-8619-71ca43a0703d")]
        public virtual System.String Organization_Name { get; set; }

    }	

}