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
    /// Модель записи реестра 'Виды работ.Тип объекта'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Виды работ.Тип объекта")]
    public class TypesWorkTypesObjectsListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля WorkType
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля WorkType")]
        [BarsUp.Utils.Attributes.Uid("C39B6FDD2FF6D96B3EE68520C8FC1194")]
        public virtual long? WorkType_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Вид работы.Наименование' (псевдоним: WorkType_Name)
        /// </summary>
        [BarsUp.Utils.Display("Вид работы.Наименование")]
        [BarsUp.Utils.Attributes.Uid("3cdc2151-0b89-4cf1-ad88-1bee050680ff")]
        public virtual System.String WorkType_Name { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля ObjectType
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля ObjectType")]
        [BarsUp.Utils.Attributes.Uid("EB626E7D7D661C8C7424626452116DEE")]
        public virtual long? ObjectType_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Тип объекта.Идентификатор' (псевдоним: ObjectType_Id)
        /// </summary>
        [BarsUp.Utils.Display("Тип объекта.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("7bf62962-0c01-4bd1-84be-e6aec8532801")]
        public virtual System.Int64? ObjectType_Id { get; set; }

    }	

}