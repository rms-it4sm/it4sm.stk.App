
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Организации заказа
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Организации заказа")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e")]    
    [BarsUp.Utils.Attributes.Uid("e329cd7b-6e49-4f39-a3f2-dc81c7c9f63e")]
        public class OrderOrganization : BarsUp.DataAccess.BaseEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public OrderOrganization() : base() {
                    }
        
        private Bars.Stkomleks.Zakaz _Zakaz;
/// <summary>
/// Заказ
/// </summary>
[BarsUp.Utils.Display("Заказ")]
[BarsUp.Utils.Attributes.Uid("f7ae25e3-ce68-4402-a491-414fcd634df3")]
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
private Bars.Stkomleks.ProfilesOrganizations _Profile;
/// <summary>
/// Профиль
/// </summary>
[BarsUp.Utils.Display("Профиль")]
[BarsUp.Utils.Attributes.Uid("b3680cb2-895a-4302-b935-4f34a4fdbb84")]
public virtual Bars.Stkomleks.ProfilesOrganizations Profile{
    get { return _Profile; }
    set { _Profile = value; }
}
public virtual long? GetProfileId(){
    var objectOrProxy = _Profile;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.OrganizationProfiles _Organization;
/// <summary>
/// Организация
/// </summary>
[BarsUp.Utils.Display("Организация")]
[BarsUp.Utils.Attributes.Uid("6ba61f70-f527-49f0-8be6-6b3ad80631e0")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual Bars.Stkomleks.OrganizationProfiles Organization{
    get { return _Organization; }
    set { _Organization = value; }
}
public virtual long? GetOrganizationId(){
    var objectOrProxy = _Organization;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("4ff1b371-5045-429f-b88e-9d6c6f52dd4e")]
public virtual System.String Comment{ get; set; }
        
            }

    }

