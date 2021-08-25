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
    /// Модель записи реестра 'Программы.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Программы.Организация")]
    public class OrganizationFundingProgramsListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля FundingPrograms
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля FundingPrograms")]
        [BarsUp.Utils.Attributes.Uid("0FB91CD8AEC65F9116F683128500D7EF")]
        public virtual long? FundingPrograms_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Программа финансирования.Наименование' (псевдоним: FundingPrograms_Name)
        /// </summary>
        [BarsUp.Utils.Display("Программа финансирования.Наименование")]
        [BarsUp.Utils.Attributes.Uid("df401530-4f3e-4f03-a169-e41056470510")]
        public virtual System.String FundingPrograms_Name { get; set; }

        /// <summary>
        /// Поле 'Программа финансирования.Описание' (псевдоним: FundingPrograms_Comment)
        /// </summary>
        [BarsUp.Utils.Display("Программа финансирования.Описание")]
        [BarsUp.Utils.Attributes.Uid("81ad5fd7-60ec-4ff3-82e8-cc716eb86016")]
        public virtual System.String FundingPrograms_Comment { get; set; }

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
        [BarsUp.Utils.Attributes.Uid("741c46f1-8961-4a39-83bf-af67f33ff550")]
        public virtual System.Int64? Organization_Id { get; set; }

    }	

}