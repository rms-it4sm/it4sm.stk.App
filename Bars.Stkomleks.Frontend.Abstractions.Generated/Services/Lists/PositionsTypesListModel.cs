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
    /// Модель записи реестра 'Виды должностей'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Виды должностей")]
    public class PositionsTypesListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Наименование' (псевдоним: Name)
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("0ce82545-b89a-483a-acf5-7d6e3eae8dd4")]
        public virtual System.String Name { get; set; }

    }	

}