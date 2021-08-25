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
    /// Модель записи реестра 'Специалисты.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Специалисты.Объект")]
    public class CompositionObjectSpecialistsListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля Object
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Object")]
        [BarsUp.Utils.Attributes.Uid("4EE7BEF1AD3002066486033BE58A0444")]
        public virtual long? Object_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Объект.Идентификатор' (псевдоним: Object_Id)
        /// </summary>
        [BarsUp.Utils.Display("Объект.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("b9a4c01c-5ed8-4a8f-86a9-847bd0e149c3")]
        public virtual System.Int64? Object_Id { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Role
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Role")]
        [BarsUp.Utils.Attributes.Uid("EF1D1E016C978856217F20BC679135A6")]
        public virtual long? Role_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Роль.Наименование' (псевдоним: Role_Name)
        /// </summary>
        [BarsUp.Utils.Display("Роль.Наименование")]
        [BarsUp.Utils.Attributes.Uid("5f14aa1f-de64-4ed1-9d50-a40577aa8808")]
        public virtual System.String Role_Name { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля Staff
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля Staff")]
        [BarsUp.Utils.Attributes.Uid("A5C950D3A9978FF83F8F7489D5A6A79E")]
        public virtual long? Staff_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Сотрудник.Должность подразделения.Должность' (псевдоним: Staff_DepartmentPosition_Position)
        /// </summary>
        [BarsUp.Utils.Display("Сотрудник.Должность подразделения.Должность")]
        [BarsUp.Utils.Attributes.Uid("03e2b03b-e259-4b0b-bf8e-e73c7688f58a")]
        public virtual System.String Staff_DepartmentPosition_Position { get; set; }

        /// <summary>
        /// Поле 'Сотрудник.Сотрудник.Физ лицо.ФИО' (псевдоним: Staff_Staff_Individual_FIO)
        /// </summary>
        [BarsUp.Utils.Display("Сотрудник.Сотрудник.Физ лицо.ФИО")]
        [BarsUp.Utils.Attributes.Uid("c89ba115-2d29-4ddb-9903-98df16f3c898")]
        public virtual System.String Staff_Staff_Individual_FIO { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("afd58360-ea36-4f3e-ae9b-5770701f3461")]
        public virtual System.String Comment { get; set; }

    }	

}