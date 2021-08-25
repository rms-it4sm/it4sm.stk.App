
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Контакты физ лиц
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Контакты физ лиц")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("1d0fdf9e-4bbb-45dd-824b-4ac7b21c254f")]    
    [BarsUp.Utils.Attributes.Uid("1d0fdf9e-4bbb-45dd-824b-4ac7b21c254f")]
        public class ContactsIndiv : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ContactsIndiv() : base() {
                    }
        
        private Bars.Stkomleks.Individuals _Individual;
/// <summary>
/// Физ лицо
/// </summary>
[BarsUp.Utils.Display("Физ лицо")]
[BarsUp.Utils.Attributes.Uid("20d08772-e29f-4577-9b80-d71eee18e15e")]
public virtual Bars.Stkomleks.Individuals Individual{
    get { return _Individual; }
    set { _Individual = value; }
}
public virtual long? GetIndividualId(){
    var objectOrProxy = _Individual;
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
[BarsUp.Utils.Attributes.Uid("bec5f501-0a7a-479d-bc81-779710e13b5d")]
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
[BarsUp.Utils.Attributes.Uid("f11c11f4-f927-444d-acc9-6e6017af37d5")]
public virtual System.String Contact{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("55498ca5-ac85-44a4-9786-cd7c04fdf987")]
public virtual System.String Comment{ get; set; }
        
            }

    }

