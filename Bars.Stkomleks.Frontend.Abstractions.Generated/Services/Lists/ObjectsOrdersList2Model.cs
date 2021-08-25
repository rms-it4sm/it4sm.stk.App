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
    /// Модель записи реестра 'Заказы.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Заказы.Объект")]
    public class ObjectsOrdersList2Model  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Zakaz
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Zakaz")]
        [BarsUp.Utils.Attributes.Uid("8710FBCC671B5AFB953FE5E7C74E598B")]
        public virtual long? Zakaz_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Заказ.Заказчик.Организация.Наименование' (псевдоним: Zakaz_Client_Organization_Name)
        /// </summary>
        [BarsUp.Utils.Display("Заказ.Заказчик.Организация.Наименование")]
        [BarsUp.Utils.Attributes.Uid("0b2fa8fd-efe9-46ef-a517-808603ac2275")]
        public virtual System.String Zakaz_Client_Organization_Name { get; set; }

        /// <summary>
        /// Поле 'Заказ.Номер' (псевдоним: Zakaz_Number)
        /// </summary>
        [BarsUp.Utils.Display("Заказ.Номер")]
        [BarsUp.Utils.Attributes.Uid("00f99087-3480-4b69-b80a-006906b83439")]
        public virtual System.String Zakaz_Number { get; set; }

        /// <summary>
        /// Поле 'Заказ.Дата' (псевдоним: Zakaz_Date)
        /// </summary>
        [BarsUp.Utils.Display("Заказ.Дата")]
        [BarsUp.Utils.Attributes.Uid("53e31121-480d-4a01-a43e-b778c3356566")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? Zakaz_Date { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Object
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Object")]
        [BarsUp.Utils.Attributes.Uid("4EE7BEF1AD3002066486033BE58A0444")]
        public virtual long? Object_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Объект.Идентификатор' (псевдоним: Object_Id)
        /// </summary>
        [BarsUp.Utils.Display("Объект.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("b81dc3f5-189b-45d4-8c07-912978fc850d")]
        public virtual System.Int64? Object_Id { get; set; }

        /// <summary>
        /// Поле 'Заказ.Идентификатор' (псевдоним: Zakaz_Id)
        /// </summary>
        [BarsUp.Utils.Display("Заказ.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("000b7a0b-528d-444c-a4c8-a3732096f758")]
        public virtual System.Int64? Zakaz_Id { get; set; }

    }	

}