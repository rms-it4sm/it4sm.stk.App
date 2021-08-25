
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Программы финансирования организации
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Программы финансирования организации")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("0de41a18-2d17-4f59-b60b-e39e0559c240")]    
    [BarsUp.Utils.Attributes.Uid("0de41a18-2d17-4f59-b60b-e39e0559c240")]
        public class OrganizationFundingPrograms : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public OrganizationFundingPrograms() : base() {
                    }
        
        private Bars.Stkomleks.Organization _Organization;
/// <summary>
/// Организация
/// </summary>
[BarsUp.Utils.Display("Организация")]
[BarsUp.Utils.Attributes.Uid("a739203f-8f97-4e4a-b804-7d0a5ae76632")]
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
private Bars.Stkomleks.FundingPrograms _FundingPrograms;
/// <summary>
/// Программа финансирования
/// </summary>
[BarsUp.Utils.Display("Программа финансирования")]
[BarsUp.Utils.Attributes.Uid("f95a256b-5ae1-40f4-aa65-89e63c58f335")]
public virtual Bars.Stkomleks.FundingPrograms FundingPrograms{
    get { return _FundingPrograms; }
    set { _FundingPrograms = value; }
}
public virtual long? GetFundingProgramsId(){
    var objectOrProxy = _FundingPrograms;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
        
            }

    }

