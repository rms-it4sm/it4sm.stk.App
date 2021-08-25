
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Организации
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Организации")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("242b06d2-b239-47ad-b75a-cbf88a4b987b")]    
    [BarsUp.Utils.Attributes.Uid("242b06d2-b239-47ad-b75a-cbf88a4b987b")]
        public class Organization : BarsUp.DataAccess.PersistentObject,BarsUp.Modules.States.IStatefulEntity
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public Organization() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("291234e7-3e4e-49ad-9652-9e47bcf814f4")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual System.String Name{ get; set; }
/// <summary>
/// Полное наименование
/// </summary>
[BarsUp.Utils.Display("Полное наименование")]
[BarsUp.Utils.Attributes.Uid("597802ac-f55b-40ee-98da-f63d361ae48c")]
public virtual System.String FullName{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("344fe108-25f3-42b4-a688-72a4f911da37")]
public virtual System.String Comment{ get; set; }
private BarsUp.Modules.States.State _State;
/// <summary>
/// Статус
/// </summary>
[BarsUp.Utils.Display("Статус")]
[BarsUp.Utils.Attributes.Uid("e4e972d9-7d07-4948-800b-58ca8794b4ad")]
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
        
            }

    }

