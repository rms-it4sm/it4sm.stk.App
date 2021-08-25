
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Типы объектов
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Типы объектов")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("0140e24b-1df6-4672-8302-a2a0cada0e53")]    
    [BarsUp.Utils.Attributes.Uid("0140e24b-1df6-4672-8302-a2a0cada0e53")]
        public class ObjectsTypes : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ObjectsTypes() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("dfde2099-4a59-4d2f-8d32-43143b4ec043")]
public virtual System.String Name{ get; set; }
/// <summary>
/// Иконка
/// </summary>
[BarsUp.Utils.Display("Иконка")]
[BarsUp.Utils.Attributes.Uid("378de02a-7f1a-4c7b-95b3-50300ef739fc")]
public virtual System.String IconObjectType{ get; set; }
/// <summary>
/// Цвет
/// </summary>
[BarsUp.Utils.Display("Цвет")]
[BarsUp.Utils.Attributes.Uid("636a1f06-c235-4cd7-b3e3-3bdbf248e0cf")]
public virtual System.String ColorIconObjectType{ get; set; }
        
            }

    }

