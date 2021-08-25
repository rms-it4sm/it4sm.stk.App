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
    /// Модель записи реестра 'Комплектация.Элемент спецификации'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Комплектация.Элемент спецификации")]
    public class ProductsListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Артикул' (псевдоним: Code)
        /// </summary>
        [BarsUp.Utils.Display("Артикул")]
        [BarsUp.Utils.Attributes.Uid("175a67a3-1895-400c-832d-c42594a56900")]
        public virtual System.String Code { get; set; }

        /// <summary>
        /// Поле 'Товар' (псевдоним: Product)
        /// </summary>
        [BarsUp.Utils.Display("Товар")]
        [BarsUp.Utils.Attributes.Uid("a0bd4594-cba1-4239-bda4-86f5d783ba28")]
        public virtual System.String Product { get; set; }

        /// <summary>
        /// Поле 'Количество' (псевдоним: Quantity)
        /// </summary>
        [BarsUp.Utils.Display("Количество")]
        [BarsUp.Utils.Attributes.Uid("10004bb1-2856-4151-9047-07345bc85944")]
        public virtual System.Double? Quantity { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Supplier
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Supplier")]
        [BarsUp.Utils.Attributes.Uid("1EDCEF0EE18C774FE4A3C313AF5FD2C9")]
        public virtual long? Supplier_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Поставщик.Организация.Наименование' (псевдоним: Supplier_Organization_Name)
        /// </summary>
        [BarsUp.Utils.Display("Поставщик.Организация.Наименование")]
        [BarsUp.Utils.Attributes.Uid("2f41d228-0fa7-462d-8b74-b3c095a64863")]
        public virtual System.String Supplier_Organization_Name { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля ObjectSpecification
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля ObjectSpecification")]
        [BarsUp.Utils.Attributes.Uid("F389A297345A84A8EEF140ED758AED6B")]
        public virtual long? ObjectSpecification_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Спецификация объекта.Идентификатор' (псевдоним: ObjectSpecification_Id)
        /// </summary>
        [BarsUp.Utils.Display("Спецификация объекта.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("c00bc456-e803-4b75-8a70-68c4c24acf72")]
        public virtual System.Int64? ObjectSpecification_Id { get; set; }

    }	

}