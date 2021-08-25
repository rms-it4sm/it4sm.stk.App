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
    /// Модель записи реестра 'Работы.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Работы.Объект")]
    public class CompositionWorksObjectsListModel  : DataTransferObject
    {
        /// <summary>
        /// Идентификатор ссылочного поля ObjectElement
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля ObjectElement")]
        [BarsUp.Utils.Attributes.Uid("9E42A219370FC57807882320D98E558B")]
        public virtual long? ObjectElement_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Элемент объекта.Тип элемента.Наименование' (псевдоним: ObjectElement_TypeElement_Name)
        /// </summary>
        [BarsUp.Utils.Display("Элемент объекта.Тип элемента.Наименование")]
        [BarsUp.Utils.Attributes.Uid("cf95128a-d732-48ac-a82b-cd81c1517bce")]
        public virtual System.String ObjectElement_TypeElement_Name { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля WorkType
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля WorkType")]
        [BarsUp.Utils.Attributes.Uid("C39B6FDD2FF6D96B3EE68520C8FC1194")]
        public virtual long? WorkType_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Вид работы.Вид работы.Наименование' (псевдоним: WorkType_WorkType_Name)
        /// </summary>
        [BarsUp.Utils.Display("Вид работы.Вид работы.Наименование")]
        [BarsUp.Utils.Attributes.Uid("6dbe1798-155d-4457-8a9b-df32a81cb2b3")]
        public virtual System.String WorkType_WorkType_Name { get; set; }

        /// <summary>
        /// Поле 'Начало (план)' (псевдоним: PlanStart)
        /// </summary>
        [BarsUp.Utils.Display("Начало (план)")]
        [BarsUp.Utils.Attributes.Uid("f8c6e65b-b91a-427d-a24d-2c98e85fc4d0")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? PlanStart { get; set; }

        /// <summary>
        /// Поле 'Завершение (план)' (псевдоним: PlanFinish)
        /// </summary>
        [BarsUp.Utils.Display("Завершение (план)")]
        [BarsUp.Utils.Attributes.Uid("4851cfa6-c576-428f-936c-98388616914e")]
        [JsonConverter(typeof(DateTimezoneIgnoreConverter))]
        public virtual System.DateTime? PlanFinish { get; set; }

        /// <summary>
        /// Поле 'Способ выполнения' (псевдоним: MethodWork)
        /// </summary>
        [BarsUp.Utils.Display("Способ выполнения")]
        [BarsUp.Utils.Attributes.Uid("0f7c8317-2603-4024-a218-c518fca508c1")]
        public virtual Bars.Stkomleks.TypesWorkPerformers? MethodWork { get; set; }

        /// <summary>
        /// Поле 'Исполнитель' (псевдоним: Executor)
        /// </summary>
        [BarsUp.Utils.Display("Исполнитель")]
        [BarsUp.Utils.Attributes.Uid("61d3623a-a678-4bed-af95-7fb20ef4fc0f")]
        public virtual System.String Executor { get; set; }

        /// <summary>
        /// Поле 'Описание' (псевдоним: Comment)
        /// </summary>
        [BarsUp.Utils.Display("Описание")]
        [BarsUp.Utils.Attributes.Uid("52cffedf-e02a-4165-832d-e803a707febc")]
        public virtual System.String Comment { get; set; }

        /// <summary>
        /// Идентификатор ссылочного поля ObjectWork
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор ссылочного поля ObjectWork")]
        [BarsUp.Utils.Attributes.Uid("E0995849CF8BE7719A834B5C00C0E90B")]
        public virtual long? ObjectWork_Ref_Id { get; set; }

        /// <summary>
        /// Поле 'Объект.Идентификатор' (псевдоним: ObjectWork_Id)
        /// </summary>
        [BarsUp.Utils.Display("Объект.Идентификатор")]
        [BarsUp.Utils.Attributes.Uid("dfd4b652-60e2-4cb5-b706-07b52983a8af")]
        public virtual System.Int64? ObjectWork_Id { get; set; }

        /// <summary>
        /// Статус записи
        /// </summary>
        [BarsUp.Utils.Display("Статус записи")]
        [BarsUp.Utils.Attributes.Uid("_State")]
        public virtual BarsUp.Modules.States.StateDTO _State { get; set; }

        /// <summary>
        /// Наименование статуса записи
        /// </summary>
        [BarsUp.Utils.Display("Наименование статуса записи")]
        [BarsUp.Utils.Attributes.Uid("_StateName")]
        public virtual string _StateName { get; set; }

        /// <summary>
        /// Идентификатор статуса записи
        /// </summary>
        [BarsUp.Utils.Display("Идентификатор статуса записи")]
        [BarsUp.Utils.Attributes.Uid("_StateId")]
        public virtual long? _StateId { get; set; }

    }	

}