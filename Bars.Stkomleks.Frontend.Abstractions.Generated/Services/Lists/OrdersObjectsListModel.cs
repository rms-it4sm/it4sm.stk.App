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
    /// Модель записи реестра 'Объекты.Заказ'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Объекты.Заказ")]
    public class OrdersObjectsListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Type
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Type")]
        [BarsUp.Utils.Attributes.Uid("65ED59C95A0DA518730524AFF8E7FEB3")]
        public virtual long? Type_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Тип.Наименование' (псевдоним: Type_Name)
        /// </summary>
        [BarsUp.Utils.Display("Тип.Наименование")]
        [BarsUp.Utils.Attributes.Uid("ada74523-c77d-4ed2-9ce2-c24a772cb8b7")]
        public virtual System.String Type_Name { get; set; }

        /// <summary>
        /// Поле 'Наименование' (псевдоним: Name)
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("52451e79-6189-4cad-a6c8-34f7c3dc6bb9")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("753efc67-8713-4eaa-8915-5e41ff0edf70")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Поле 'Тип.Идентификатор' (псевдоним: Type_Id)
        /// </summary>
        [BarsUp.Utils.Display("Тип.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("a8a9e464-a41f-4472-8ba3-5c0767f116d5")]
        public virtual System.Int64? Type_Id { get; set; }

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