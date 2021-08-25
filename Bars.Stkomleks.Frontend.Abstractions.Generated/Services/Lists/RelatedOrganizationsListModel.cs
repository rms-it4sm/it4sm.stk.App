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
    /// Модель записи реестра 'Связанные организации.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Связанные организации.Организация")]
    public class RelatedOrganizationsListModel  : DataTransferObject
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
        [BarsUp.Utils.Attributes.Uid("b7405679-38ac-4d94-884c-345c7afd65ba")]
        public virtual System.Int64? Organization_Id { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля RelatedOrg
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля RelatedOrg")]
        [BarsUp.Utils.Attributes.Uid("11A463E84800FB6972BE870F608ABFBB")]
        public virtual long? RelatedOrg_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Связанная организация.Наименование' (псевдоним: RelatedOrg_Name)
        /// </summary>
        [BarsUp.Utils.Display("Связанная организация.Наименование")]
        [BarsUp.Utils.Attributes.Uid("46d37f5c-5d79-44af-a495-791d4b6e7518")]
        public virtual System.String RelatedOrg_Name { get; set; }

    }	

}