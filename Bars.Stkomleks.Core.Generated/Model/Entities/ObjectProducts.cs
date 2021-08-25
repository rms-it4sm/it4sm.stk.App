
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Спецификация объекта
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Спецификация объекта")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("c4895819-2171-42e1-bde2-d4fa83104bbd")]    
    [BarsUp.Utils.Attributes.Uid("c4895819-2171-42e1-bde2-d4fa83104bbd")]
        public class ObjectProducts : BarsUp.DataAccess.BaseEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ObjectProducts() : base() {
                    }
        
        private Bars.Stkomleks.OrdersObjects _ObjectOrder;
/// <summary>
/// Объект
/// </summary>
[BarsUp.Utils.Display("Объект")]
[BarsUp.Utils.Attributes.Uid("834b602a-f4f4-4943-be32-d82c58e50ce7")]
public virtual Bars.Stkomleks.OrdersObjects ObjectOrder{
    get { return _ObjectOrder; }
    set { _ObjectOrder = value; }
}
public virtual long? GetObjectOrderId(){
    var objectOrProxy = _ObjectOrder;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Код элемента
/// </summary>
[BarsUp.Utils.Display("Код элемента")]
[BarsUp.Utils.Attributes.Uid("3b80eac1-dd79-421e-a6ea-301b5a8fa395")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual System.String Code{ get; set; }
private Bars.Stkomleks.ProductsTypes _TypeElement;
/// <summary>
/// Тип элемента
/// </summary>
[BarsUp.Utils.Display("Тип элемента")]
[BarsUp.Utils.Attributes.Uid("6937d6ae-a06f-4475-a391-7b5aced09f7f")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual Bars.Stkomleks.ProductsTypes TypeElement{
    get { return _TypeElement; }
    set { _TypeElement = value; }
}
public virtual long? GetTypeElementId(){
    var objectOrProxy = _TypeElement;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Количество
/// </summary>
[BarsUp.Utils.Display("Количество")]
[BarsUp.Utils.Attributes.Uid("ba306dc3-b0fd-4722-b546-acec6b81d4bf")]
public virtual System.Double? Quantity{ get; set; }
private Bars.Stkomleks.UnitMeasure _UnitMeasure;
/// <summary>
/// Ед. изм.
/// </summary>
[BarsUp.Utils.Display("Ед. изм.")]
[BarsUp.Utils.Attributes.Uid("6f5c0ee8-5e92-42ad-8883-eba7cf11b2ab")]
public virtual Bars.Stkomleks.UnitMeasure UnitMeasure{
    get { return _UnitMeasure; }
    set { _UnitMeasure = value; }
}
public virtual long? GetUnitMeasureId(){
    var objectOrProxy = _UnitMeasure;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("593432ba-2fc0-4d71-9ed9-d67fd0a9970f")]
public virtual System.String Comment{ get; set; }
        
            }

    }

