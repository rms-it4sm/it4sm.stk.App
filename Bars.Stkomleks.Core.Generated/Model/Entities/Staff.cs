
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Сотрудники
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Сотрудники")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("0b83a4c4-1b8b-49d6-b16b-dcb3a373a391")]    
    [BarsUp.Utils.Attributes.Uid("0b83a4c4-1b8b-49d6-b16b-dcb3a373a391")]
        public class Staff : BarsUp.DataAccess.PersistentObject,BarsUp.Modules.States.IStatefulEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public Staff() : base() {
                    }
        
        private Bars.Stkomleks.Organization _Organization;
/// <summary>
/// Организация
/// </summary>
[BarsUp.Utils.Display("Организация")]
[BarsUp.Utils.Attributes.Uid("877ada62-82d4-4fca-8574-61c4290187d5")]
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
private Bars.Stkomleks.Individuals _Individual;
/// <summary>
/// Физ лицо
/// </summary>
[BarsUp.Utils.Display("Физ лицо")]
[BarsUp.Utils.Attributes.Uid("2841e6bd-6760-4243-92b0-d26a48633898")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
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
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("0fc2221c-b809-4739-a087-7a9acf5438c5")]
public virtual System.String Comment{ get; set; }
private BarsUp.Modules.States.State _State;
/// <summary>
/// Статус
/// </summary>
[BarsUp.Utils.Display("Статус")]
[BarsUp.Utils.Attributes.Uid("35c9fe0e-04ae-4d01-a79d-3926deb694e0")]
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
        
            }

    }

