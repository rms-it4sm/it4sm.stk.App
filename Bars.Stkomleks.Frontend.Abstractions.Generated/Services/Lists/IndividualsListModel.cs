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
    /// Модель записи реестра 'Физические лица'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Физические лица")]
    public class IndividualsListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'ФИО' (псевдоним: FIO)
        /// </summary>
        [BarsUp.Utils.Display("ФИО")]
        [BarsUp.Utils.Attributes.Uid("1e5d7cd4-bd4c-4abd-9b2e-e06caa0811f2")]
        public virtual System.String FIO { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("160acee7-01fc-4be0-a0b4-2c2578b1995a")]
        public virtual System.String Comment { get; set; }

    }	

}