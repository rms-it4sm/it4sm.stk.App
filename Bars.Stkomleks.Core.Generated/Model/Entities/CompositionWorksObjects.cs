
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Работы объектов
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Работы объектов")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("cd655c91-5a8f-427c-ab3a-d4c44234cb06")]    
    [BarsUp.Utils.Attributes.Uid("cd655c91-5a8f-427c-ab3a-d4c44234cb06")]
        public class CompositionWorksObjects : BarsUp.DataAccess.PersistentObject,BarsUp.Modules.States.IStatefulEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public CompositionWorksObjects() : base() {
                    }
        
        private Bars.Stkomleks.OrdersObjects _ObjectWork;
/// <summary>
/// Объект
/// </summary>
[BarsUp.Utils.Display("Объект")]
[BarsUp.Utils.Attributes.Uid("e5e6c0c3-2740-40ee-9e6b-c98d69124498")]
public virtual Bars.Stkomleks.OrdersObjects ObjectWork{
    get { return _ObjectWork; }
    set { _ObjectWork = value; }
}
public virtual long? GetObjectWorkId(){
    var objectOrProxy = _ObjectWork;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.WorksTypes _Type;
/// <summary>
/// УДЛ_Вид
/// </summary>
[BarsUp.Utils.Display("УДЛ_Вид")]
[BarsUp.Utils.Attributes.Uid("b59efb24-9b48-404a-98dc-a021166555c2")]
public virtual Bars.Stkomleks.WorksTypes Type{
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
private Bars.Stkomleks.TypesWorkTypesObjects _WorkType;
/// <summary>
/// Вид работы
/// </summary>
[BarsUp.Utils.Display("Вид работы")]
[BarsUp.Utils.Attributes.Uid("57b675f7-b7f9-4d88-b390-9185e48c5d6a")]
public virtual Bars.Stkomleks.TypesWorkTypesObjects WorkType{
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
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("10f45f46-c87b-4130-a5db-673007a24530")]
public virtual System.String Comment{ get; set; }
private Bars.Stkomleks.ObjectProducts _ObjectElement;
/// <summary>
/// Элемент объекта
/// </summary>
[BarsUp.Utils.Display("Элемент объекта")]
[BarsUp.Utils.Attributes.Uid("f6e6872c-d834-499f-b973-c3085925579a")]
public virtual Bars.Stkomleks.ObjectProducts ObjectElement{
    get { return _ObjectElement; }
    set { _ObjectElement = value; }
}
public virtual long? GetObjectElementId(){
    var objectOrProxy = _ObjectElement;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Объем
/// </summary>
[BarsUp.Utils.Display("Объем")]
[BarsUp.Utils.Attributes.Uid("ab2c72ea-8553-4906-874a-21739d7f69fa")]
public virtual System.Double? Scope{ get; set; }
private Bars.Stkomleks.UnitMeasure _UnutMeasure;
/// <summary>
/// Ед. изм
/// </summary>
[BarsUp.Utils.Display("Ед. изм")]
[BarsUp.Utils.Attributes.Uid("12b03338-f1ad-4000-b788-c630ecc4ad42")]
public virtual Bars.Stkomleks.UnitMeasure UnutMeasure{
    get { return _UnutMeasure; }
    set { _UnutMeasure = value; }
}
public virtual long? GetUnutMeasureId(){
    var objectOrProxy = _UnutMeasure;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Способ выполнения
/// </summary>
[BarsUp.Utils.Display("Способ выполнения")]
[BarsUp.Utils.Attributes.Uid("96ec58e2-95d0-45d4-a271-875601604621")]
public virtual Bars.Stkomleks.TypesWorkPerformers? MethodWork{ get; set; }
private Bars.Stkomleks.OrganizationProfiles _ContractorWork;
/// <summary>
/// Подрядчик
/// </summary>
[BarsUp.Utils.Display("Подрядчик")]
[BarsUp.Utils.Attributes.Uid("099d9765-3b40-4a3a-a495-856053b6a5b6")]
public virtual Bars.Stkomleks.OrganizationProfiles ContractorWork{
    get { return _ContractorWork; }
    set { _ContractorWork = value; }
}
public virtual long? GetContractorWorkId(){
    var objectOrProxy = _ContractorWork;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.Departments _Brigade;
/// <summary>
/// Бригада
/// </summary>
[BarsUp.Utils.Display("Бригада")]
[BarsUp.Utils.Attributes.Uid("fba91bbb-26f1-4766-9e96-88d0969c671e")]
public virtual Bars.Stkomleks.Departments Brigade{
    get { return _Brigade; }
    set { _Brigade = value; }
}
public virtual long? GetBrigadeId(){
    var objectOrProxy = _Brigade;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private BarsUp.Modules.States.State _State;
/// <summary>
/// Статус
/// </summary>
[BarsUp.Utils.Display("Статус")]
[BarsUp.Utils.Attributes.Uid("b8bdda97-46ef-4226-a0de-d71feda83cf3")]
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
/// <summary>
/// Начало (план)
/// </summary>
[BarsUp.Utils.Display("Начало (план)")]
[BarsUp.Utils.Attributes.Uid("d5cc7e14-1d82-4846-b79a-a4c19a61a2f5")]
public virtual System.DateTime? PlanStart{ get; set; }
/// <summary>
/// Завершение (план)
/// </summary>
[BarsUp.Utils.Display("Завершение (план)")]
[BarsUp.Utils.Attributes.Uid("3f80730d-eb09-48e7-a2cc-62cbc1533c16")]
public virtual System.DateTime? PlanFinish{ get; set; }
/// <summary>
/// Исполнитель
/// </summary>
[BarsUp.Utils.Display("Исполнитель")]
[BarsUp.Utils.Attributes.Uid("87250b9a-b480-488b-9aa3-eba693e483af")]
public virtual System.String Executor{ get; set; }
        
            }

    }

