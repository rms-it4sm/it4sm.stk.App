
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Заказы
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Заказы")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("cac4cb82-577f-4682-bbd7-bf7d70fbfee1")]    
    [BarsUp.Utils.Attributes.Uid("cac4cb82-577f-4682-bbd7-bf7d70fbfee1")]
        public class Zakaz : BarsUp.DataAccess.BaseEntity,BarsUp.Modules.States.IStatefulEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public Zakaz() : base() {
                    }
        
        /// <summary>
/// Номер
/// </summary>
[BarsUp.Utils.Display("Номер")]
[BarsUp.Utils.Attributes.Uid("2f3de072-33f6-492c-8016-a55598f69f32")]
public virtual System.String Number{ get; set; }
/// <summary>
/// Дата
/// </summary>
[BarsUp.Utils.Display("Дата")]
[BarsUp.Utils.Attributes.Uid("94896f6f-f4a2-4c12-a701-0e988c92f462")]
public virtual System.DateTime? Date{ get; set; }
private Bars.Stkomleks.OrganizationProfiles _Client;
/// <summary>
/// Заказчик
/// </summary>
[BarsUp.Utils.Display("Заказчик")]
[BarsUp.Utils.Attributes.Uid("4082c604-c52d-4594-88ad-b59078285797")]
public virtual Bars.Stkomleks.OrganizationProfiles Client{
    get { return _Client; }
    set { _Client = value; }
}
public virtual long? GetClientId(){
    var objectOrProxy = _Client;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private BarsUp.Modules.States.State _State;
/// <summary>
/// Статус
/// </summary>
[BarsUp.Utils.Display("Статус")]
[BarsUp.Utils.Attributes.Uid("2c5ce838-ae20-45bb-8cf8-65848eb4fbec")]
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
private Bars.Stkomleks.Staff _Manager;
/// <summary>
/// Менеджер
/// </summary>
[BarsUp.Utils.Display("Менеджер")]
[BarsUp.Utils.Attributes.Uid("3ee53bb5-bb60-47aa-8a69-41594431f6e0")]
public virtual Bars.Stkomleks.Staff Manager{
    get { return _Manager; }
    set { _Manager = value; }
}
public virtual long? GetManagerId(){
    var objectOrProxy = _Manager;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("01be0595-d7b3-4466-bf15-f9110b6fa65f")]
public virtual System.String Comment{ get; set; }
        
            }

    }

