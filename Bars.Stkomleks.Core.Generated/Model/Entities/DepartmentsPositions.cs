
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Должности подразделения
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Должности подразделения")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("1cbc241a-85e4-47db-964b-6bec69dec86c")]    
    [BarsUp.Utils.Attributes.Uid("1cbc241a-85e4-47db-964b-6bec69dec86c")]
        public class DepartmentsPositions : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public DepartmentsPositions() : base() {
                    }
        
        private Bars.Stkomleks.Departments _Department;
/// <summary>
/// Подразделение
/// </summary>
[BarsUp.Utils.Display("Подразделение")]
[BarsUp.Utils.Attributes.Uid("403e67cf-fb18-4e44-8066-e9987352fdc0")]
public virtual Bars.Stkomleks.Departments Department{
    get { return _Department; }
    set { _Department = value; }
}
public virtual long? GetDepartmentId(){
    var objectOrProxy = _Department;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.PositionsTypes _Type;
/// <summary>
/// Вид
/// </summary>
[BarsUp.Utils.Display("Вид")]
[BarsUp.Utils.Attributes.Uid("f176197f-28ae-4253-a228-0f5ef5df9aea")]
public virtual Bars.Stkomleks.PositionsTypes Type{
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
/// Должность
/// </summary>
[BarsUp.Utils.Display("Должность")]
[BarsUp.Utils.Attributes.Uid("ac773733-14e9-4469-920f-500782bb6cef")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual System.String Position{ get; set; }
        
            }

    }

