namespace Bars.Stkomleks
{
    using System;
    using System.Linq;
    using BarsUp;
    using BarsUp.DataAccess;
    using System.Collections.Generic;
        
    using BarsUp.Windsor;
    using BarsUp.IoC;
    using BarsUp.Utils;
    
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Designer.GeneratedApp.Editors;
    using BarsUp.Core.Exceptions;
    using BarsUp.Designer.Core;
    using BarsUp.Designer.Core.TypeSystem;
    using BarsUp.Designer.GeneratedApp.Commons;
    using BarsUp.Core.Serialization;

        /// <summary>
        /// Модель редактора ''
        /// </summary>
        [BarsUp.Utils.DisplayAttribute("")]
        public class OrganizationProfilesListMultiAddByOrganizationEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public OrganizationProfilesListMultiAddByOrganizationEditorModel(){
        }
        /// <summary>
        /// Организация
        /// </summary>
        [BarsUp.Utils.Display("Организация")]
        [BarsUp.Utils.Attributes.Uid("3f6a27a7-9537-6b5e-172c-f61ca13808c4")]
        public virtual Bars.Stkomleks.OrganizationListModel Organization { get; set; }

        /// <summary>
        /// Профиль
        /// </summary>
        [BarsUp.Utils.Display("Профиль")]
        [BarsUp.Utils.Attributes.Uid("f41fc75b-99e9-2cb7-334f-1847641581ea")]
        public virtual Bars.Stkomleks.ProfilesOrganizationsListModel Profile { get; set; }

        }

}