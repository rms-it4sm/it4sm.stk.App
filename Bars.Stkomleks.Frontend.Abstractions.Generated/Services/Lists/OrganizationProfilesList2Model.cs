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
    /// Модель записи реестра 'Организации по профилю.Выбор'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Организации по профилю.Выбор")]
    public class OrganizationProfilesList2Model  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Organization
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Organization")]
        [BarsUp.Utils.Attributes.Uid("132A5B6C202C6CCB0881BDFF2F0A4066")]
        public virtual long? Organization_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Организация.Наименование' (псевдоним: Organization_Name)
        /// </summary>
        [BarsUp.Utils.Display("Организация.Наименование")]
        [BarsUp.Utils.Attributes.Uid("2d14fd93-6b32-45c6-bce2-b7e6810cbfc5")]
        public virtual System.String Organization_Name { get; set; }

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
        [BarsUp.Utils.Attributes.Uid("6cf441dc-d81e-474a-82a0-1612faf155af")]
        public virtual System.String Profile_Name { get; set; }

        /// <summary>
        /// Поле 'Организация.Идентификатор' (псевдоним: Organization_Id)
        /// </summary>
        [BarsUp.Utils.Display("Организация.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("565de724-6828-4938-808f-88c4330d3cde")]
        public virtual System.Int64? Organization_Id { get; set; }

    }	

}