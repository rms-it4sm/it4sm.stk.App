
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Типы документов
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Типы документов")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("99acad7b-98b7-44d0-8116-ae5e6a2f4dd5")]    
    [BarsUp.Utils.Attributes.Uid("99acad7b-98b7-44d0-8116-ae5e6a2f4dd5")]
        public class DocumentsType : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public DocumentsType() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("916dab28-f962-427c-b442-8dd1a43355b8")]
public virtual System.String Name{ get; set; }
        
            }

    }

