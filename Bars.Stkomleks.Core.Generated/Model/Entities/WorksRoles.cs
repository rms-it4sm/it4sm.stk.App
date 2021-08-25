
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Роли
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Роли")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("d8f32d3f-e219-467b-8b32-c0f3311a5e05")]    
    [BarsUp.Utils.Attributes.Uid("d8f32d3f-e219-467b-8b32-c0f3311a5e05")]
        public class WorksRoles : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public WorksRoles() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("aa7fe838-9d6b-4fdf-b29c-e212b72b8f30")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual System.String Name{ get; set; }
        
            }

    }

