
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Документы договоров
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Документы договоров")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("71da323f-2f10-4d3f-a416-b408b3ea3f99")]    
    [BarsUp.Utils.Attributes.Uid("71da323f-2f10-4d3f-a416-b408b3ea3f99")]
        public class ContractDocuments : Bars.Stkomleks.Documents
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ContractDocuments() : base() {
                    }
        
        private Bars.Stkomleks.OrganizationProfiles _Side1;
/// <summary>
/// Сторона 1
/// </summary>
[BarsUp.Utils.Display("Сторона 1")]
[BarsUp.Utils.Attributes.Uid("59771e21-b034-45dd-a5a6-d37ac4dd818a")]
public virtual Bars.Stkomleks.OrganizationProfiles Side1{
    get { return _Side1; }
    set { _Side1 = value; }
}
public virtual long? GetSide1Id(){
    var objectOrProxy = _Side1;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.OrganizationProfiles _Side2;
/// <summary>
/// Сторона 2
/// </summary>
[BarsUp.Utils.Display("Сторона 2")]
[BarsUp.Utils.Attributes.Uid("730a1cf2-8fcd-49e4-a712-42ae45a8b8a2")]
public virtual Bars.Stkomleks.OrganizationProfiles Side2{
    get { return _Side2; }
    set { _Side2 = value; }
}
public virtual long? GetSide2Id(){
    var objectOrProxy = _Side2;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
        
            }

    }

