
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Специалисты объектов
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Специалисты объектов")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2")]    
    [BarsUp.Utils.Attributes.Uid("e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2")]
        public class CompositionObjectSpecialists : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public CompositionObjectSpecialists() : base() {
                    }
        
        private Bars.Stkomleks.OrdersObjects _Object;
/// <summary>
/// Объект
/// </summary>
[BarsUp.Utils.Display("Объект")]
[BarsUp.Utils.Attributes.Uid("4dfa5472-c553-43e8-b2e7-af1b34fab335")]
public virtual Bars.Stkomleks.OrdersObjects Object{
    get { return _Object; }
    set { _Object = value; }
}
public virtual long? GetObjectId(){
    var objectOrProxy = _Object;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.WorksRoles _Role;
/// <summary>
/// Роль
/// </summary>
[BarsUp.Utils.Display("Роль")]
[BarsUp.Utils.Attributes.Uid("6a3ca1e4-f71f-453d-9fe6-9a9dbfd364ab")]
public virtual Bars.Stkomleks.WorksRoles Role{
    get { return _Role; }
    set { _Role = value; }
}
public virtual long? GetRoleId(){
    var objectOrProxy = _Role;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.CurrentPositionsDepartments _Staff;
/// <summary>
/// Сотрудник
/// </summary>
[BarsUp.Utils.Display("Сотрудник")]
[BarsUp.Utils.Attributes.Uid("fb8e963d-efd7-47e3-b908-21358bea5fcb")]
public virtual Bars.Stkomleks.CurrentPositionsDepartments Staff{
    get { return _Staff; }
    set { _Staff = value; }
}
public virtual long? GetStaffId(){
    var objectOrProxy = _Staff;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("b3a7961a-bf00-4c1b-8dc4-13e207a3c9d9")]
public virtual System.String Comment{ get; set; }
        
            }

    }

