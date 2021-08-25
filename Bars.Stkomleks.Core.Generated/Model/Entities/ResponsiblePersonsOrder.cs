
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Ответственные лица заказа
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Ответственные лица заказа")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("ad3b2737-f4d5-4495-b388-44a6dfd03bd9")]    
    [BarsUp.Utils.Attributes.Uid("ad3b2737-f4d5-4495-b388-44a6dfd03bd9")]
        public class ResponsiblePersonsOrder : BarsUp.DataAccess.BaseEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ResponsiblePersonsOrder() : base() {
                    }
        
        private Bars.Stkomleks.OrderOrganization _OrderOrganization;
/// <summary>
/// Организация заказа
/// </summary>
[BarsUp.Utils.Display("Организация заказа")]
[BarsUp.Utils.Attributes.Uid("2173306f-90af-4867-96b1-ff443b3bc289")]
public virtual Bars.Stkomleks.OrderOrganization OrderOrganization{
    get { return _OrderOrganization; }
    set { _OrderOrganization = value; }
}
public virtual long? GetOrderOrganizationId(){
    var objectOrProxy = _OrderOrganization;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.Staff _Staff;
/// <summary>
/// Сотрудник
/// </summary>
[BarsUp.Utils.Display("Сотрудник")]
[BarsUp.Utils.Attributes.Uid("d72d7037-1006-4e36-9322-acb7fac2c8ea")]
public virtual Bars.Stkomleks.Staff Staff{
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
/// Назначение
/// </summary>
[BarsUp.Utils.Display("Назначение")]
[BarsUp.Utils.Attributes.Uid("7194780a-1ae7-4273-a332-85e86223a895")]
public virtual System.String Appointment{ get; set; }
        
            }

    }

