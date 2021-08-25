namespace Bars.Stkomleks
{
    using System;
    using BarsUp.Utils;
    using System.Collections.Generic;

    /// <summary>
    /// Типы исполнителей работ
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Типы исполнителей работ")]
    [BarsUp.Utils.Description(@"")]   
    [System.Runtime.InteropServices.GuidAttribute("cbca5d3e-8487-448e-8a5d-6d54caf25efe")]
    [BarsUp.Utils.Attributes.Uid("cbca5d3e-8487-448e-8a5d-6d54caf25efe")]
        public enum TypesWorkPerformers
    {
                        /// <summary>
        /// Хоз. способ		
        /// </summary>
        [BarsUp.Utils.Display(@"Хоз. способ")]
        [BarsUp.Utils.Description(@"")]        
        EconomicMethod = 1,
        
            /// <summary>
        /// Подрядчик		
        /// </summary>
        [BarsUp.Utils.Display(@"Подрядчик")]
        [BarsUp.Utils.Description(@"")]        
        ContractingMethod = 2
    
    }
}

