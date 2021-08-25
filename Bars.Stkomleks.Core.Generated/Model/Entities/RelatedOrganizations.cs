
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Связанные организации
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Связанные организации")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("ba084c30-4998-4494-a718-d6eca64c6140")]    
    [BarsUp.Utils.Attributes.Uid("ba084c30-4998-4494-a718-d6eca64c6140")]
        public class RelatedOrganizations : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public RelatedOrganizations() : base() {
                    }
        
        private Bars.Stkomleks.Organization _Organization;
/// <summary>
/// Организация
/// </summary>
[BarsUp.Utils.Display("Организация")]
[BarsUp.Utils.Attributes.Uid("42fbc98d-ab6c-474a-8a5e-74f8b1811518")]
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
private Bars.Stkomleks.Organization _RelatedOrg;
/// <summary>
/// Связанная организация
/// </summary>
[BarsUp.Utils.Display("Связанная организация")]
[BarsUp.Utils.Attributes.Uid("21c4785e-e297-40c1-a26a-595bd3238a35")]
public virtual Bars.Stkomleks.Organization RelatedOrg{
    get { return _RelatedOrg; }
    set { _RelatedOrg = value; }
}
public virtual long? GetRelatedOrgId(){
    var objectOrProxy = _RelatedOrg;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
        
            }

    }

