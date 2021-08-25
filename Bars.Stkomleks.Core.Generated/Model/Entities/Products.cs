
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Комплектация элементов объектов
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Комплектация элементов объектов")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("59c0f660-c442-4e9a-8772-a97243000d48")]    
    [BarsUp.Utils.Attributes.Uid("59c0f660-c442-4e9a-8772-a97243000d48")]
        public class Products : BarsUp.DataAccess.BaseEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public Products() : base() {
                    }
        
        private Bars.Stkomleks.ObjectProducts _ObjectSpecification;
/// <summary>
/// Спецификация объекта
/// </summary>
[BarsUp.Utils.Display("Спецификация объекта")]
[BarsUp.Utils.Attributes.Uid("3dcb8175-9311-4543-9aed-da77478ece62")]
public virtual Bars.Stkomleks.ObjectProducts ObjectSpecification{
    get { return _ObjectSpecification; }
    set { _ObjectSpecification = value; }
}
public virtual long? GetObjectSpecificationId(){
    var objectOrProxy = _ObjectSpecification;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
private Bars.Stkomleks.OrganizationProfiles _Supplier;
/// <summary>
/// Поставщик
/// </summary>
[BarsUp.Utils.Display("Поставщик")]
[BarsUp.Utils.Attributes.Uid("45a5ab39-ea3e-4bf8-bb76-4e063c9b11e4")]
public virtual Bars.Stkomleks.OrganizationProfiles Supplier{
    get { return _Supplier; }
    set { _Supplier = value; }
}
public virtual long? GetSupplierId(){
    var objectOrProxy = _Supplier;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Артикул
/// </summary>
[BarsUp.Utils.Display("Артикул")]
[BarsUp.Utils.Attributes.Uid("456f9a5a-a1e3-4657-8c32-0998de5c8ef0")]
public virtual System.String Code{ get; set; }
/// <summary>
/// Товар
/// </summary>
[BarsUp.Utils.Display("Товар")]
[BarsUp.Utils.Attributes.Uid("73f245ed-c7e5-4328-a973-ba959aba22f9")]
public virtual System.String Product{ get; set; }
/// <summary>
/// Количество
/// </summary>
[BarsUp.Utils.Display("Количество")]
[BarsUp.Utils.Attributes.Uid("fb54ae14-ffe8-4bda-9f02-635d225baa9a")]
public virtual System.Double? Quantity{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("c195a5ca-a120-48b0-b8e3-cb89ab12a514")]
public virtual System.String Comment{ get; set; }
        
            }

    }

