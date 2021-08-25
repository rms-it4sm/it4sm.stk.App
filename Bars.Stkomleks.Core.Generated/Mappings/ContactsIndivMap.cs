namespace Bars.Stkomleks.Mappings
{
    using NHibernate;
    using NHibernate.Type;
    using NHibernate.Mapping.ByCode;    
    using NHibernate.Mapping.ByCode.Conformist;    
    using BarsUp.DataAccess;
    
    using BarsUp.DataAccess.ByCode;
    using BarsUp.DataAccess.UserTypes; 
    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Designer.Core;
    using BarsUp.Designer.Core.TypeSystem;
    using BarsUp.Modules.PostgreSql.DataAccess.UserTypes;
    using BarsUp.Modules.Versioning.Map;

    /// <summary>
    /// Мапинг сущности Контакты физ лиц
    /// </summary>
    public class ContactsIndivMap : ClassMapping<Bars.Stkomleks.ContactsIndiv>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ContactsIndivMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("CONTACTSINDIV");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: ContactsIndiv
ManyToOne(x => x.Individual, m => { m.Column("INDIVIDUAL");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Type, m => { m.Column("TYPE");m.Cascade(Cascade.Persist);});
Property(x => x.Contact, p => { p.Column(col => { col.Name("CONTACT");});});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
#endregion
        }
    }

    }

