
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Физические лица
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Физические лица")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d")]    
    [BarsUp.Utils.Attributes.Uid("49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d")]
        public class Individuals : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public Individuals() : base() {
                    }
        
        /// <summary>
/// Фамилия
/// </summary>
[BarsUp.Utils.Display("Фамилия")]
[BarsUp.Utils.Attributes.Uid("21ecbd16-6ed6-4e4e-af46-8a3b392cff2c")]
public virtual System.String Surname{ get; set; }
/// <summary>
/// Имя
/// </summary>
[BarsUp.Utils.Display("Имя")]
[BarsUp.Utils.Attributes.Uid("02c16e5e-79e3-42b2-837e-b9e8ec19aaa5")]
public virtual System.String Name{ get; set; }
/// <summary>
/// Отчество
/// </summary>
[BarsUp.Utils.Display("Отчество")]
[BarsUp.Utils.Attributes.Uid("8baa4ced-6274-402c-ac1b-0db307331b44")]
public virtual System.String Patronymic{ get; set; }
/// <summary>
/// ФИО
/// </summary>
[BarsUp.Utils.Display("ФИО")]
[BarsUp.Utils.Attributes.Uid("9eb7280e-5e7f-4c39-b975-ad80302db2f6")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual System.String FIO{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("6921b320-087a-421a-804d-0506c8838012")]
public virtual System.String Comment{ get; set; }
        
            }

    }

