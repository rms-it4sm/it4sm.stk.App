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
    /// Модель записи реестра 'Должности.Подразделение'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Должности.Подразделение")]
    public class DepartmentsPositionsListModel  : DataTransferObject
    {
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
        [BarsUp.Utils.Attributes.Uid("64246d85-29e6-48be-afc7-b9f8c8287d26")]
        public virtual System.String Type_Name { get; set; }

        /// <summary>
        /// Поле 'Должность' (псевдоним: Position)
        /// </summary>
        [BarsUp.Utils.Display("Должность")]
        [BarsUp.Utils.Attributes.Uid("fa18b37a-52a2-4203-a55a-27d29f5e0af6")]
        public virtual System.String Position { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Department
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Department")]
        [BarsUp.Utils.Attributes.Uid("EB95DF3BA72454F52F0A72C5DC67DFB2")]
        public virtual long? Department_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Подразделение.Идентификатор' (псевдоним: Department_Id)
        /// </summary>
        [BarsUp.Utils.Display("Подразделение.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("8037acd6-44d3-4bf8-927b-fdde53ab0e3b")]
        public virtual System.Int64? Department_Id { get; set; }

    }	

}