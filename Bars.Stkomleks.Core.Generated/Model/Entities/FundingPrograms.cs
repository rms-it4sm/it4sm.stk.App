
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Программы финансирования
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Программы финансирования")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("60a5fdca-979f-4332-9a9e-9a1fbd66665a")]    
    [BarsUp.Utils.Attributes.Uid("60a5fdca-979f-4332-9a9e-9a1fbd66665a")]
        public class FundingPrograms : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public FundingPrograms() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("5b06b53c-a325-441c-862c-df36a87d0ea8")]
public virtual System.String Name{ get; set; }
/// <summary>
/// Описание
/// </summary>
[BarsUp.Utils.Display("Описание")]
[BarsUp.Utils.Attributes.Uid("362312bc-a43c-4cd7-8545-9e944431d1cb")]
public virtual System.String Comment{ get; set; }
        
            }

    }

