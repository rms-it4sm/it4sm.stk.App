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
    /// Модель записи реестра 'Объекты'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Объекты")]
    public class OrdersObjectsList2Model  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Zakaz
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Zakaz")]
        [BarsUp.Utils.Attributes.Uid("8710FBCC671B5AFB953FE5E7C74E598B")]
        public virtual long? Zakaz_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Заказ.Номер' (псевдоним: Order_Number)
        /// </summary>
        [BarsUp.Utils.Display("Заказ.Номер")]
        [BarsUp.Utils.Attributes.Uid("8fecf90d-8196-44cc-97c2-17101aed4fb7")]
        public virtual System.String Order_Number { get; set; }

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
        [BarsUp.Utils.Attributes.Uid("49cf854a-e6b6-45f0-8b2d-8c1a620bdba0")]
        public virtual System.String Type_Name { get; set; }

        /// <summary>
        /// Поле 'Наименование' (псевдоним: Name)
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("6ecaa7b8-27cc-4f18-9724-f78b627fa33e")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("da674c47-22f8-4b19-bb18-5079277da5cd")]
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