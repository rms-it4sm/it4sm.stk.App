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
    /// Модель записи реестра 'Занимаемые должности.Подразделение'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Занимаемые должности.Подразделение")]
    public class CurrentPositionsDepartmentsListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Начало' (псевдоним: Start)
        /// </summary>
        [BarsUp.Utils.Display("Начало")]
        [BarsUp.Utils.Attributes.Uid("562f18fe-db14-4d90-96b4-5ca0fb309c6d")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? Start { get; set; }

        /// <summary>
        /// Поле 'Завершение' (псевдоним: Finish)
        /// </summary>
        [BarsUp.Utils.Display("Завершение")]
        [BarsUp.Utils.Attributes.Uid("219ebdf0-7a0c-4ff0-9244-7b9ea8955d46")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? Finish { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Staff
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Staff")]
        [BarsUp.Utils.Attributes.Uid("A5C950D3A9978FF83F8F7489D5A6A79E")]
        public virtual long? Staff_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Сотрудник.Физ лицо.ФИО' (псевдоним: Staff_Individual_FIO)
        /// </summary>
        [BarsUp.Utils.Display("Сотрудник.Физ лицо.ФИО")]
        [BarsUp.Utils.Attributes.Uid("7637c338-5995-4c80-814e-fc26d2d8c80c")]
        public virtual System.String Staff_Individual_FIO { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("d34037dd-1a85-4f49-8af4-1cd4f740cf93")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля DepartmentPosition
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля DepartmentPosition")]
        [BarsUp.Utils.Attributes.Uid("6C889C6332FFF77025759B7A466041AF")]
        public virtual long? DepartmentPosition_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Должность подразделения.Идентификатор' (псевдоним: DepartmentPosition_Id)
        /// </summary>
        [BarsUp.Utils.Display("Должность подразделения.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("27fc86ef-c007-4050-b64d-eccb0bc15a61")]
        public virtual System.Int64? DepartmentPosition_Id { get; set; }

    }	

}