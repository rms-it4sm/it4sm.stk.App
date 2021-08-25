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
    /// Модель записи реестра 'Оганизации.Программа финансирования'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Оганизации.Программа финансирования")]
    public class OrganizationFundingProgramsList2Model  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля FundingPrograms
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля FundingPrograms")]
        [BarsUp.Utils.Attributes.Uid("0FB91CD8AEC65F9116F683128500D7EF")]
        public virtual long? FundingPrograms_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Программа финансирования.Идентификатор' (псевдоним: FundingPrograms_Id)
        /// </summary>
        [BarsUp.Utils.Display("Программа финансирования.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("44fdf0bc-8985-479a-a1db-83c6efc228a2")]
        public virtual System.Int64? FundingPrograms_Id { get; set; }

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
        [BarsUp.Utils.Attributes.Uid("07b1ed0a-0d2f-4b22-a863-984e46db9e8f")]
        public virtual System.String Organization_Name { get; set; }

        /// <summary>
        /// Поле 'Организация.Описание' (псевдоним: Organization_Comment)
        /// </summary>
        [BarsUp.Utils.Display("Организация.Описание")]
        [BarsUp.Utils.Attributes.Uid("4c624b37-a4e2-4ce9-a895-b3d5f253b386")]
        public virtual System.String Organization_Comment { get; set; }

    }	

}