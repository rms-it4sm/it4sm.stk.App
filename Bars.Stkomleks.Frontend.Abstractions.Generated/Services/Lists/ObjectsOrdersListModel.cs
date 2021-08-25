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
    /// Модель записи реестра 'Объекты.Заказа'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Объекты.Заказа")]
    public class ObjectsOrdersListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Zakaz
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Zakaz")]
        [BarsUp.Utils.Attributes.Uid("8710FBCC671B5AFB953FE5E7C74E598B")]
        public virtual long? Zakaz_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Заказ.Идентификатор' (псевдоним: Zakaz_Id)
        /// </summary>
        [BarsUp.Utils.Display("Заказ.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("866209b8-d883-47f5-877c-63123a3e6ca3")]
        public virtual System.Int64? Zakaz_Id { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Object
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Object")]
        [BarsUp.Utils.Attributes.Uid("4EE7BEF1AD3002066486033BE58A0444")]
        public virtual long? Object_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Объект.Статус.Наименование' (псевдоним: Object_State_Name)
        /// </summary>
        [BarsUp.Utils.Display("Объект.Статус.Наименование")]
        [BarsUp.Utils.Attributes.Uid("ad231022-eb3e-4f7e-92c4-a5b0a519f219")]
        public virtual System.String Object_State_Name { get; set; }

        /// <summary>
        /// Поле 'Объект.Тип.Наименование' (псевдоним: Object_Type_Name)
        /// </summary>
        [BarsUp.Utils.Display("Объект.Тип.Наименование")]
        [BarsUp.Utils.Attributes.Uid("12aae422-d51c-47b8-94c5-06a27264a18d")]
        public virtual System.String Object_Type_Name { get; set; }

        /// <summary>
        /// Поле 'Объект.Наименование' (псевдоним: Object_Name)
        /// </summary>
        [BarsUp.Utils.Display("Объект.Наименование")]
        [BarsUp.Utils.Attributes.Uid("0d3bca4b-753f-49cf-8c50-819f1f1ced9a")]
        public virtual System.String Object_Name { get; set; }

        /// <summary>
        /// Поле 'Объект.Идентификатор' (псевдоним: Object_Id)
        /// </summary>
        [BarsUp.Utils.Display("Объект.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("4d727803-39d5-4c66-9464-09c4e6735518")]
        public virtual System.Int64? Object_Id { get; set; }

    }	

}