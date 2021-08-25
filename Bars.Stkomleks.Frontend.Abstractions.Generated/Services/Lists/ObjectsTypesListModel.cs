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
    /// Модель записи реестра 'Типы объектов'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Типы объектов")]
    public class ObjectsTypesListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Наименование' (псевдоним: Name)
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("e085bd2e-2e5b-4c0c-a890-86cd80892916")]
        public virtual System.String Name { get; set; }

        /// <summary>
        /// Поле 'Иконка' (псевдоним: IconObjectType)
        /// </summary>
        [BarsUp.Utils.Display("Иконка")]
        [BarsUp.Utils.Attributes.Uid("7393a213-1de7-47fb-aad2-263a6ac4a0bb")]
        public virtual System.String IconObjectType { get; set; }

        /// <summary>
        /// Поле 'Цвет' (псевдоним: ColorIconObjectType)
        /// </summary>
        [BarsUp.Utils.Display("Цвет")]
        [BarsUp.Utils.Attributes.Uid("529cf857-5551-4fbf-a311-f9bdb7449237")]
        public virtual System.String ColorIconObjectType { get; set; }

    }	

}