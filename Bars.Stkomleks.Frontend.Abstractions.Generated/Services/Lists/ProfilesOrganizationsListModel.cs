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
    /// Модель записи реестра 'Профили организаций'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Профили организаций")]
    public class ProfilesOrganizationsListModel  : DataTransferObject
    {
        /// <summary>
        /// Поле 'Наименование' (псевдоним: Name)
        /// </summary>
        [BarsUp.Utils.Display("Наименование")]
        [BarsUp.Utils.Attributes.Uid("8561fb6c-599d-4447-bb41-bf10411b9cfc")]
        public virtual System.String Name { get; set; }

    }	

}