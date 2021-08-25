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
    /// Модель записи реестра 'Единицы измерения'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Единицы измерения")]
    public class UnitMeasureListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Наименование' (псевдоним: Nema)
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("172ad929-8f47-4348-b547-f2556e6abd97")]
        public virtual System.String Nema { get; set; }

        /// <summary>
        /// Поле 'Сокращенное наименование' (псевдоним: CutName)
        /// </summary>
        [BarsUp.Utils.Display("Сокращенное наименование")]
        [BarsUp.Utils.Attributes.Uid("65cdd354-6cc7-4528-9e40-b44ab7c3f854")]
        public virtual System.String CutName { get; set; }

    }	

}