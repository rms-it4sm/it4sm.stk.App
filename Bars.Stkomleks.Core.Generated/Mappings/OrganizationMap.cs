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
    /// Мапинг сущности Организации
    /// </summary>
    public class OrganizationMap : ClassMapping<Bars.Stkomleks.Organization>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public OrganizationMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("ORGANIZATION");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: Organization
Property(x => x.Name, p => { p.Column(col => { col.Name("NAME");});});
Property(x => x.FullName, p => { p.Column(col => { col.Name("FULLNAME");});});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
ManyToOne(x => x.State, m => { m.Column("STATE");m.Cascade(Cascade.Persist);});
#endregion
        }
    }

    }

