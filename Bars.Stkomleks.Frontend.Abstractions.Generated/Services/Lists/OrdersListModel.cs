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
    /// Модель записи реестра 'Заказы'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Заказы")]
    public class OrdersListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Номер' (псевдоним: Number)
        /// </summary>
        [BarsUp.Utils.Display("Номер")]
        [BarsUp.Utils.Attributes.Uid("55baa0cd-c5f0-4e29-9a9e-553925b75c84")]
        public virtual System.String Number { get; set; }

        /// <summary>
        /// Поле 'Дата' (псевдоним: Date)
        /// </summary>
        [BarsUp.Utils.Display("Дата")]
        [BarsUp.Utils.Attributes.Uid("07847f0a-a5cf-48c1-9937-3dc2468dc640")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? Date { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Client
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Client")]
        [BarsUp.Utils.Attributes.Uid("4BC2175AED0903F0A88337C5F24C58E5")]
        public virtual long? Client_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Заказчик.Организация.Наименование' (псевдоним: Client_Organization_Name)
        /// </summary>
        [BarsUp.Utils.Display("Заказчик.Организация.Наименование")]
        [BarsUp.Utils.Attributes.Uid("d2cb28e1-bfd5-4c52-9232-5edb91dbfd07")]
        public virtual System.String Client_Organization_Name { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Manager
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Manager")]
        [BarsUp.Utils.Attributes.Uid("DAD145C859537C6557C1796F65F24730")]
        public virtual long? Manager_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Менеджер.Физ лицо.ФИО' (псевдоним: Manager_Individual_FIO)
        /// </summary>
        [BarsUp.Utils.Display("Менеджер.Физ лицо.ФИО")]
        [BarsUp.Utils.Attributes.Uid("b0776bd1-7390-4635-a11a-3201a130119d")]
        public virtual System.String Manager_Individual_FIO { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("057829d4-a0b3-467c-9c77-e4a64a471a2f")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Статус записи
        /// </summary>
        [BarsUp.Utils.Display("Статус записи")]
        [BarsUp.Utils.Attributes.Uid("_State")]
        public virtual BarsUp.Modules.States.StateDTO _State { get; set; }

        /// <summary>
        /// Наименование статуса записи
        /// </summary>
        [BarsUp.Utils.Display("Наименование статуса записи")]
        [BarsUp.Utils.Attributes.Uid("_StateName")]
        public virtual string _StateName { get; set; }

        /// <summary>
        /// Идентификатор статуса записи
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор статуса записи")]
        [BarsUp.Utils.Attributes.Uid("_StateId")]
        public virtual long? _StateId { get; set; }

    }	

}