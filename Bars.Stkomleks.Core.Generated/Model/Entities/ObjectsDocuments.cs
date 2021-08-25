
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Документы объекта
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Документы объекта")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("f83926a7-db81-4655-acb3-9a95778fe130")]    
    [BarsUp.Utils.Attributes.Uid("f83926a7-db81-4655-acb3-9a95778fe130")]
        public class ObjectsDocuments : BarsUp.DataAccess.BaseEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ObjectsDocuments() : base() {
                    }
        
        private Bars.Stkomleks.OrdersObjects _ObjectWork;
/// <summary>
/// Объект
/// </summary>
[BarsUp.Utils.Display("Объект")]
[BarsUp.Utils.Attributes.Uid("58f67435-6a62-4318-9ff7-af5953ffa9a6")]
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
/// <summary>
/// Файл
/// </summary>
[BarsUp.Utils.Display("Файл")]
[BarsUp.Utils.Attributes.Uid("76347bed-514a-4aef-861c-7cc3a41c8750")]
public virtual BarsUp.Modules.FileStorage.FileInfo File{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("21f62c7f-c180-4905-be66-eecf1438515e")]
public virtual System.String Comment{ get; set; }
        
            }

    }

