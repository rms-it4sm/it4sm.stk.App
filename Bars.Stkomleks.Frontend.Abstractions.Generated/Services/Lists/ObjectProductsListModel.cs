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
    /// Модель записи реестра 'Спецификация.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Спецификация.Объект")]
    public class ObjectProductsListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Код элемента' (псевдоним: Code)
        /// </summary>
        [BarsUp.Utils.Display("Код элемента")]
        [BarsUp.Utils.Attributes.Uid("73b87ddd-1e4e-4b85-8559-ee77d420cd1d")]
        public virtual System.String Code { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля TypeElement
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля TypeElement")]
        [BarsUp.Utils.Attributes.Uid("30657E2367CB44D71901786B3F174799")]
        public virtual long? TypeElement_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Тип элемента.Наименование' (псевдоним: TypeElement_Name)
        /// </summary>
        [BarsUp.Utils.Display("Тип элемента.Наименование")]
        [BarsUp.Utils.Attributes.Uid("613aeeb7-ee64-4a4f-bba3-7aa2bbcb1b98")]
        public virtual System.String TypeElement_Name { get; set; }

        /// <summary>
        /// Поле 'Количество' (псевдоним: Quantity)
        /// </summary>
        [BarsUp.Utils.Display("Количество")]
        [BarsUp.Utils.Attributes.Uid("b67d6103-67f8-4a2c-8cf6-7a2ea052fc55")]
        public virtual System.Double? Quantity { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля UnitMeasure
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля UnitMeasure")]
        [BarsUp.Utils.Attributes.Uid("BCD040FB8EE938F81667F5C45CCDFF5E")]
        public virtual long? UnitMeasure_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Ед. изм.Сокращенное наименование' (псевдоним: UnitMeasure_CutName)
        /// </summary>
        [BarsUp.Utils.Display("Ед. изм.Сокращенное наименование")]
        [BarsUp.Utils.Attributes.Uid("3a8e1477-abd7-478f-a3a4-f93818d24423")]
        public virtual System.String UnitMeasure_CutName { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("65730777-0002-4365-bd20-eef2995844c1")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля ObjectOrder
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля ObjectOrder")]
        [BarsUp.Utils.Attributes.Uid("74A52EEFB1B220729BDBD185D7F86C16")]
        public virtual long? ObjectOrder_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Объект.Идентификатор' (псевдоним: ObjectOrder_Id)
        /// </summary>
        [BarsUp.Utils.Display("Объект.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("b2aa66f5-eda5-4d8d-8ccc-7e16f38d5d9f")]
        public virtual System.Int64? ObjectOrder_Id { get; set; }

    }	

}