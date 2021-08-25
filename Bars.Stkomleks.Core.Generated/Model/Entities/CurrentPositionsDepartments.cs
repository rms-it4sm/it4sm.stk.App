
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Занимаемые должности подразделений
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Занимаемые должности подразделений")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("788a15f1-40ba-4144-b7a9-45ce08fb1ffc")]    
    [BarsUp.Utils.Attributes.Uid("788a15f1-40ba-4144-b7a9-45ce08fb1ffc")]
        public class CurrentPositionsDepartments : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public CurrentPositionsDepartments() : base() {
                    }
        
        private Bars.Stkomleks.DepartmentsPositions _DepartmentPosition;
/// <summary>
/// Должность подразделения
/// </summary>
[BarsUp.Utils.Display("Должность подразделения")]
[BarsUp.Utils.Attributes.Uid("45701d0f-8b89-4f73-97ce-6b22afb0832e")]
public virtual Bars.Stkomleks.DepartmentsPositions DepartmentPosition{
    get { return _DepartmentPosition; }
    set { _DepartmentPosition = value; }
}
public virtual long? GetDepartmentPositionId(){
    var objectOrProxy = _DepartmentPosition;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.Staff _Staff;
/// <summary>
/// Сотрудник
/// </summary>
[BarsUp.Utils.Display("Сотрудник")]
[BarsUp.Utils.Attributes.Uid("ae322edc-4521-4ff9-9d21-49d1aacb76da")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual Bars.Stkomleks.Staff Staff{
    get { return _Staff; }
    set { _Staff = value; }
}
public virtual long? GetStaffId(){
    var objectOrProxy = _Staff;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Начало
/// </summary>
[BarsUp.Utils.Display("Начало")]
[BarsUp.Utils.Attributes.Uid("970a73c8-7aa2-4627-aa61-f63efe1b404a")]
public virtual System.DateTime? Start{ get; set; }
/// <summary>
/// Завершение
/// </summary>
[BarsUp.Utils.Display("Завершение")]
[BarsUp.Utils.Attributes.Uid("38dc8ddd-3d66-42aa-a5b8-bf02e173b825")]
public virtual System.DateTime? Finish{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("7c4f9660-2d1a-45ef-92a6-23eba0557973")]
public virtual System.String Comment{ get; set; }
        
            }

    }

