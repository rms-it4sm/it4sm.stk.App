
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Профили организаций
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Профили организаций")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("239223c0-de50-410c-8e79-bd1e57b91b4e")]    
    [BarsUp.Utils.Attributes.Uid("239223c0-de50-410c-8e79-bd1e57b91b4e")]
        public class ProfilesOrganizations : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ProfilesOrganizations() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("f44c4209-af60-444a-a056-671a5255de8d")]
public virtual System.String Name{ get; set; }
        
            }

    }

