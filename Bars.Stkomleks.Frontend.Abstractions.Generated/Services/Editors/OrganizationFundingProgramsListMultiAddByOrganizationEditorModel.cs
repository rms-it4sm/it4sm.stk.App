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
        public class OrganizationFundingProgramsListMultiAddByOrganizationEditorModel : DataTransferObject
        {
        /// <summary>
        /// Создание нового экземпляра модели
        /// </summary>
        public OrganizationFundingProgramsListMultiAddByOrganizationEditorModel(){
        }
        /// <summary>
        /// Организация
        /// </summary>
        [BarsUp.Utils.Display("Организация")]
        [BarsUp.Utils.Attributes.Uid("d293b26a-b89b-aefe-87a1-4bad120ba077")]
        public virtual Bars.Stkomleks.OrganizationListModel Organization { get; set; }

        /// <summary>
        /// Программа финансирования
        /// </summary>
        [BarsUp.Utils.Display("Программа финансирования")]
        [BarsUp.Utils.Attributes.Uid("85777005-b52b-9921-3685-5a412553cd80")]
        public virtual Bars.Stkomleks.FundingProgramsListModel FundingPrograms { get; set; }

        }

}