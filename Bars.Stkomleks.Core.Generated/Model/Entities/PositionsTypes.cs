
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Виды должностей
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Виды должностей")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("c3cd4337-81c8-466a-98ca-872e581dcf97")]    
    [BarsUp.Utils.Attributes.Uid("c3cd4337-81c8-466a-98ca-872e581dcf97")]
        public class PositionsTypes : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public PositionsTypes() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("a4db7755-81d6-415e-83ff-dc5e999fc018")]
public virtual System.String Name{ get; set; }
        
            }

    }

