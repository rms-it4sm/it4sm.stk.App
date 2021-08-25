
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Контакты организации
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Контакты организации")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("2ab43a3b-81eb-4f93-8d61-eb1304c71200")]    
    [BarsUp.Utils.Attributes.Uid("2ab43a3b-81eb-4f93-8d61-eb1304c71200")]
        public class OrganizationContacts : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public OrganizationContacts() : base() {
                    }
        
        private Bars.Stkomleks.Organization _Organization;
/// <summary>
/// Организация
/// </summary>
[BarsUp.Utils.Display("Организация")]
[BarsUp.Utils.Attributes.Uid("56a4d0ab-d6fa-4f25-aab9-24b4e09fa869")]
public virtual Bars.Stkomleks.Organization Organization{
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
private Bars.Stkomleks.ContactsType _Type;
/// <summary>
/// Тип
/// </summary>
[BarsUp.Utils.Display("Тип")]
[BarsUp.Utils.Attributes.Uid("a386480f-9a10-4e5d-bb26-988e998fe6f2")]
public virtual Bars.Stkomleks.ContactsType Type{
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
/// Контакт
/// </summary>
[BarsUp.Utils.Display("Контакт")]
[BarsUp.Utils.Attributes.Uid("97085dd4-c3b0-426b-85d2-dcd4d324177f")]
public virtual System.String Contact{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("5a634474-ec51-4c7b-bdd6-654d0c2914e7")]
public virtual System.String Comment{ get; set; }
        
            }

    }

