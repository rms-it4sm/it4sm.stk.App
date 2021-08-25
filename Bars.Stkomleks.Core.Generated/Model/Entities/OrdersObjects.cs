
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Объекты
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Объекты")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("aa6ab35e-8dca-491d-8261-0bf3c834ab3b")]    
    [BarsUp.Utils.Attributes.Uid("aa6ab35e-8dca-491d-8261-0bf3c834ab3b")]
        public class OrdersObjects : BarsUp.DataAccess.BaseEntity,BarsUp.Modules.States.IStatefulEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public OrdersObjects() : base() {
                    }
        
        private Bars.Stkomleks.Zakaz _Zakaz;
/// <summary>
/// Заказ
/// </summary>
[BarsUp.Utils.Display("Заказ")]
[BarsUp.Utils.Attributes.Uid("b059c2ef-ece8-4541-8ca6-11a818c0a53a")]
public virtual Bars.Stkomleks.Zakaz Zakaz{
    get { return _Zakaz; }
    set { _Zakaz = value; }
}
public virtual long? GetZakazId(){
    var objectOrProxy = _Zakaz;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("8abbde9d-6cd1-4f40-84e7-9d387c970f1b")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual System.String Name{ get; set; }
private Bars.Stkomleks.ObjectsTypes _Type;
/// <summary>
/// Тип
/// </summary>
[BarsUp.Utils.Display("Тип")]
[BarsUp.Utils.Attributes.Uid("a861dd69-8067-4c54-a160-4086f003580f")]
public virtual Bars.Stkomleks.ObjectsTypes Type{
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
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("00da65d1-e495-4651-acbe-a299e13fef87")]
public virtual System.String Comment{ get; set; }
private BarsUp.Modules.States.State _State;
/// <summary>
/// Статус
/// </summary>
[BarsUp.Utils.Display("Статус")]
[BarsUp.Utils.Attributes.Uid("d547b8fb-bba6-4d6d-aac0-9000a3d5a1a7")]
public virtual BarsUp.Modules.States.State State{
    get { return _State; }
    set { _State = value; }
}
public virtual long? GetStateId(){
    var objectOrProxy = _State;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Lat
/// </summary>
[BarsUp.Utils.Display("Lat")]
[BarsUp.Utils.Attributes.Uid("b090549f-a003-44b9-95c3-f1f9021c9717")]
public virtual System.String Lat{ get; set; }
/// <summary>
/// Lon
/// </summary>
[BarsUp.Utils.Display("Lon")]
[BarsUp.Utils.Attributes.Uid("56d3d3eb-5e2b-4b4e-aab3-b82e2d50bb04")]
public virtual System.String Lon{ get; set; }
        
            }

    }

