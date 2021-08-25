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
    /// Мапинг сущности Специалисты объектов
    /// </summary>
    public class CompositionObjectSpecialistsMap : ClassMapping<Bars.Stkomleks.CompositionObjectSpecialists>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public CompositionObjectSpecialistsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("COMPOSITIONOBJECTSPECIALISTS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: CompositionObjectSpecialists
ManyToOne(x => x.Object, m => { m.Column("OBJECT");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Role, m => { m.Column("ROLE");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Staff, m => { m.Column("STAFF");m.Cascade(Cascade.Persist);});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
#endregion
        }
    }

    }

