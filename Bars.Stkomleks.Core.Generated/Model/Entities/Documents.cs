
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Документы
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Документы")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("3bea8edd-4cf7-419a-bb60-ce54a37ffc46")]    
    [BarsUp.Utils.Attributes.Uid("3bea8edd-4cf7-419a-bb60-ce54a37ffc46")]
        public class Documents : BarsUp.DataAccess.BaseEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public Documents() : base() {
                    }
        
        private Bars.Stkomleks.DocumentsType _Type;
/// <summary>
/// Тип
/// </summary>
[BarsUp.Utils.Display("Тип")]
[BarsUp.Utils.Attributes.Uid("0f6064c1-45ca-47e4-be18-33eee57fa04b")]
public virtual Bars.Stkomleks.DocumentsType Type{
    get { return _Type; }
    set { _Type = value; }
}
public virtual long? GetTypeId(){
    var objectOrProxy = _Type;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Номер
/// </summary>
[BarsUp.Utils.Display("Номер")]
[BarsUp.Utils.Attributes.Uid("9df17c5e-8715-4688-bc45-290994cbc255")]
public virtual System.String ContractNumber{ get; set; }
/// <summary>
/// Дата
/// </summary>
[BarsUp.Utils.Display("Дата")]
[BarsUp.Utils.Attributes.Uid("b7575223-e6af-4784-8e40-8da609185bbf")]
public virtual System.DateTime ContractDate{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("0220c1a3-f545-4eb6-85f2-28b4384841af")]
public virtual System.String Comment{ get; set; }
        
            }

    }

