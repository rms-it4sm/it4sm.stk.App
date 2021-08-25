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
        public class RelatedOrganizationsListMultiAddByOrganizationEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public RelatedOrganizationsListMultiAddByOrganizationEditorModel(){
        }
        /// <summary>
        /// Организация
        /// </summary>
        [BarsUp.Utils.Display("Организация")]
        [BarsUp.Utils.Attributes.Uid("a9913a4a-6560-cb62-ab3a-82fb6689cc52")]
        public virtual Bars.Stkomleks.OrganizationListModel Organization { get; set; }

        /// <summary>
        /// Связанная организация
        /// </summary>
        [BarsUp.Utils.Display("Связанная организация")]
        [BarsUp.Utils.Attributes.Uid("1cb0d009-0f5a-4361-204a-1744329a84e0")]
        public virtual Bars.Stkomleks.OrganizationListModel RelatedOrg { get; set; }

        }

}