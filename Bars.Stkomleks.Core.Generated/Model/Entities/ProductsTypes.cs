
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Типы продуктов
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Типы продуктов")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("c8da2215-8f85-4af6-bffa-8d66d53fd0cd")]    
    [BarsUp.Utils.Attributes.Uid("c8da2215-8f85-4af6-bffa-8d66d53fd0cd")]
        public class ProductsTypes : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ProductsTypes() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("b90e9798-469f-4de2-a64a-577dbe42640d")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual System.String Name{ get; set; }
        
            }

    }

