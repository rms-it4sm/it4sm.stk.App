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
    /// Мапинг сущности Сотрудники
    /// </summary>
    public class StaffMap : ClassMapping<Bars.Stkomleks.Staff>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public StaffMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("STAFF");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: Staff
ManyToOne(x => x.Organization, m => { m.Column("ORGANIZATION");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Individual, m => { m.Column("INDIVIDUAL");m.Cascade(Cascade.Persist);});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
ManyToOne(x => x.State, m => { m.Column("STATE");m.Cascade(Cascade.Persist);});
#endregion
        }
    }

    }

