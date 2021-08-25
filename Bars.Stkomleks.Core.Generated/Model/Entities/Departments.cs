
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Подразделения
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Подразделения")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("493d5e72-6f08-4da0-9fa7-bfd88e202a82")]    
    [BarsUp.Utils.Attributes.Uid("493d5e72-6f08-4da0-9fa7-bfd88e202a82")]
        public class Departments : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public Departments() : base() {
                    }
        
        private Bars.Stkomleks.Organization _Organization;
/// <summary>
/// Организация
/// </summary>
[BarsUp.Utils.Display("Организация")]
[BarsUp.Utils.Attributes.Uid("4232236c-1a3f-44b0-9871-c455627e996f")]
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
/// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("31eb0ef3-24ba-477d-a32e-31fa9d658932")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual System.String Name{ get; set; }
private Bars.Stkomleks.DepartmentsType _Type;
/// <summary>
/// Вид
/// </summary>
[BarsUp.Utils.Display("Вид")]
[BarsUp.Utils.Attributes.Uid("f4affac2-1b88-4f95-8f8c-ad4c66ba22bd")]
public virtual Bars.Stkomleks.DepartmentsType Type{
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
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("d577bb47-5437-47b1-8c10-65d243db1f04")]
public virtual System.String Comment{ get; set; }
        
            }

    }

