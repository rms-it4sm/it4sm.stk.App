
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Виды подразделений
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Виды подразделений")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("abec8327-350c-42a6-bbce-32cb76103d00")]    
    [BarsUp.Utils.Attributes.Uid("abec8327-350c-42a6-bbce-32cb76103d00")]
        public class DepartmentsType : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public DepartmentsType() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("565ee7fe-e001-406e-b048-35966b4b3f67")]
public virtual System.String Name{ get; set; }
        
            }

    }

