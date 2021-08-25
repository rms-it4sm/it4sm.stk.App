
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// УДЛ_Этапы объектов
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"УДЛ_Этапы объектов")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("d71cd12d-9425-4e85-8603-74fd080629e1")]    
    [BarsUp.Utils.Attributes.Uid("d71cd12d-9425-4e85-8603-74fd080629e1")]
        public class ObjectsStages : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ObjectsStages() : base() {
                    }
        
        private Bars.Stkomleks.OrdersObjects _ObjectWork;
/// <summary>
/// Объект
/// </summary>
[BarsUp.Utils.Display("Объект")]
[BarsUp.Utils.Attributes.Uid("b886a2cc-6948-49b5-92e3-4ea9e58b51e7")]
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
private Bars.Stkomleks.ObjectsStages _IncludidIn;
/// <summary>
/// Входит в
/// </summary>
[BarsUp.Utils.Display("Входит в")]
[BarsUp.Utils.Attributes.Uid("c056bdb4-5e72-4031-aba3-7d428423e7d7")]
public virtual Bars.Stkomleks.ObjectsStages IncludidIn{
    get { return _IncludidIn; }
    set { _IncludidIn = value; }
}
public virtual long? GetIncludidInId(){
    var objectOrProxy = _IncludidIn;
    if (objectOrProxy == null) return null;
    if (objectOrProxy is NHibernate.Proxy.INHibernateProxy proxy)
        return (long?)proxy.HibernateLazyInitializer.Identifier;
    return objectOrProxy.Id;
}
/// <summary>
/// Этап
/// </summary>
[BarsUp.Utils.Display("Этап")]
[BarsUp.Utils.Attributes.Uid("2f27e4f4-5633-4f4f-b1ab-373edf49e180")]
public virtual System.String Stage{ get; set; }
/// <summary>
/// Начало
/// </summary>
[BarsUp.Utils.Display("Начало")]
[BarsUp.Utils.Attributes.Uid("93a43e12-2648-4d91-be61-ca84517f6627")]
public virtual System.DateTime? Start{ get; set; }
/// <summary>
/// Завершение
/// </summary>
[BarsUp.Utils.Display("Завершение")]
[BarsUp.Utils.Attributes.Uid("746701ae-0dae-4bd7-afa4-37e1e44c2589")]
public virtual System.DateTime? Finish{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("2150b4ec-aff8-4940-955c-4205f624d395")]
public virtual System.String Comment{ get; set; }
        
            }

    }

