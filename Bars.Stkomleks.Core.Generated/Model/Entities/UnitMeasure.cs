
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Единицы измерения
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Единицы измерения")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("15100549-aaff-4972-981e-964ab1b0ecc6")]    
    [BarsUp.Utils.Attributes.Uid("15100549-aaff-4972-981e-964ab1b0ecc6")]
        public class UnitMeasure : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public UnitMeasure() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("7e86e43d-0dab-4626-958f-c5f0b73c13e0")]
public virtual System.String Nema{ get; set; }
/// <summary>
/// Сокращенное наименование
/// </summary>
[BarsUp.Utils.Display("Сокращенное наименование")]
[BarsUp.Utils.Attributes.Uid("ec1108d2-98bb-48b7-ad5a-6185dc2ccf2a")]
[BarsUp.Core.Attributes.UsedAsDisplayInSelectfield]
public virtual System.String CutName{ get; set; }
        
            }

    }

