
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Виды работ.Типы объектов
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Виды работ.Типы объектов")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("ceb87fbf-759c-4e7f-bc92-3a605d913ad5")]    
    [BarsUp.Utils.Attributes.Uid("ceb87fbf-759c-4e7f-bc92-3a605d913ad5")]
        public class TypesWorkTypesObjects : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public TypesWorkTypesObjects() : base() {
                    }
        
        private Bars.Stkomleks.WorksTypes _WorkType;
/// <summary>
/// Вид работы
/// </summary>
[BarsUp.Utils.Display("Вид работы")]
[BarsUp.Utils.Attributes.Uid("a027f406-10c4-4310-9fc3-d6f6fe0739de")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual Bars.Stkomleks.WorksTypes WorkType{
    get { return _WorkType; }
    set { _WorkType = value; }
}
public virtual long? GetWorkTypeId(){
    var objectOrProxy = _WorkType;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.ObjectsTypes _ObjectType;
/// <summary>
/// Тип объекта
/// </summary>
[BarsUp.Utils.Display("Тип объекта")]
[BarsUp.Utils.Attributes.Uid("851be698-95e0-465e-b419-95da45ec8f8b")]
public virtual Bars.Stkomleks.ObjectsTypes ObjectType{
    get { return _ObjectType; }
    set { _ObjectType = value; }
}
public virtual long? GetObjectTypeId(){
    var objectOrProxy = _ObjectType;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
        
            }

    }

