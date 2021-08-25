
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Виды работ
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Виды работ")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("7a874dff-d4b4-49ed-8be9-977056ad8fc9")]    
    [BarsUp.Utils.Attributes.Uid("7a874dff-d4b4-49ed-8be9-977056ad8fc9")]
        public class WorksTypes : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public WorksTypes() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("a9294408-1e36-4617-9972-07c45c83ce2d")]
public virtual System.String Name{ get; set; }
        
            }

    }

