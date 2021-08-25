
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Заказы Объекты
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Заказы Объекты")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("33d98787-d41a-4282-8f79-3b4f1046a7a1")]    
    [BarsUp.Utils.Attributes.Uid("33d98787-d41a-4282-8f79-3b4f1046a7a1")]
        public class ObjectsOrders : BarsUp.DataAccess.BaseEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ObjectsOrders() : base() {
                    }
        
        private Bars.Stkomleks.Zakaz _Zakaz;
/// <summary>
/// Заказ
/// </summary>
[BarsUp.Utils.Display("Заказ")]
[BarsUp.Utils.Attributes.Uid("30ef3bf7-35e0-4a5c-9945-9fa7db560dc7")]
public virtual Bars.Stkomleks.Zakaz Zakaz{
    get { return _Zakaz; }
    set { _Zakaz = value; }
}
public virtual long? GetZakazId(){
    var objectOrProxy = _Zakaz;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.OrdersObjects _Object;
/// <summary>
/// Объект
/// </summary>
[BarsUp.Utils.Display("Объект")]
[BarsUp.Utils.Attributes.Uid("f9b75007-4df7-4f66-8407-9646b73f634d")]
public virtual Bars.Stkomleks.OrdersObjects Object{
    get { return _Object; }
    set { _Object = value; }
}
public virtual long? GetObjectId(){
    var objectOrProxy = _Object;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
        
            }

    }

