
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Организации по профилю
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Организации по профилю")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("2f3cc7da-d8a3-4c53-b83f-ec26f028202e")]    
    [BarsUp.Utils.Attributes.Uid("2f3cc7da-d8a3-4c53-b83f-ec26f028202e")]
        public class OrganizationProfiles : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public OrganizationProfiles() : base() {
                    }
        
        private Bars.Stkomleks.Organization _Organization;
/// <summary>
/// Организация
/// </summary>
[BarsUp.Utils.Display("Организация")]
[BarsUp.Utils.Attributes.Uid("e0a08ecf-f833-461a-8b0d-8d7e5d4e4778")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
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
private Bars.Stkomleks.ProfilesOrganizations _Profile;
/// <summary>
/// Профиль
/// </summary>
[BarsUp.Utils.Display("Профиль")]
[BarsUp.Utils.Attributes.Uid("5258c478-6f02-425d-a14e-025882b1b6c0")]
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
        
            }

    }

