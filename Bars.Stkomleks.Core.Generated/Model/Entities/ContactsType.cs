
namespace Bars.Stkomleks
{
    using System;
    using BarsUp.DataAccess;
    using System.Linq;
    using NHibernate;

    
    /// <summary>
    /// Типы контактов
    /// 
    /// </summary>
    [BarsUp.Utils.Display(@"Типы контактов")]
    [BarsUp.Utils.Description(@"")]  
    [System.Runtime.InteropServices.GuidAttribute("a94c08c3-bfc2-4c72-ae81-c082487d5588")]    
    [BarsUp.Utils.Attributes.Uid("a94c08c3-bfc2-4c72-ae81-c082487d5588")]
        public class ContactsType : BarsUp.DataAccess.PersistentObject
    {
        /// <summary>
        /// Конструктор сущности
        /// </summary>
        public ContactsType() : base() {
                    }
        
        /// <summary>
/// Наименование
/// </summary>
[BarsUp.Utils.Display("Наименование")]
[BarsUp.Utils.Attributes.Uid("baf7c554-f6dd-4fa0-911e-22d7d5c06cb4")]
public virtual System.String Name{ get; set; }
        
            }

    }

