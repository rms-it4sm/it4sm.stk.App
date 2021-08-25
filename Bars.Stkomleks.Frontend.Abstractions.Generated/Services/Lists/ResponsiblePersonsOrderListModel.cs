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
    /// Модель записи реестра 'Ответственные лица. Организация заказа'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Ответственные лица. Организация заказа")]
    public class ResponsiblePersonsOrderListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Staff
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Staff")]
        [BarsUp.Utils.Attributes.Uid("A5C950D3A9978FF83F8F7489D5A6A79E")]
        public virtual long? Staff_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Сотрудник.Физ лицо.ФИО' (псевдоним: Staff_Individual_FIO)
        /// </summary>
        [BarsUp.Utils.Display("Сотрудник.Физ лицо.ФИО")]
        [BarsUp.Utils.Attributes.Uid("ef4a0466-5616-4e78-b8fb-63f669f7aa67")]
        public virtual System.String Staff_Individual_FIO { get; set; }

        /// <summary>
        /// Поле 'Назначение' (псевдоним: Appointment)
        /// </summary>
        [BarsUp.Utils.Display("Назначение")]
        [BarsUp.Utils.Attributes.Uid("65da21ff-9f96-4e38-b8c6-dbd1b2cc1b7c")]
        public virtual System.String Appointment { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля OrderOrganization
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля OrderOrganization")]
        [BarsUp.Utils.Attributes.Uid("B179D8EA150502855FABBAE68A0BBCEE")]
        public virtual long? OrderOrganization_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Организация заказа.Идентификатор' (псевдоним: OrderOrganization_Id)
        /// </summary>
        [BarsUp.Utils.Display("Организация заказа.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("be1bdef2-73e0-419b-b224-3307bcc7549c")]
        public virtual System.Int64? OrderOrganization_Id { get; set; }

    }	

}