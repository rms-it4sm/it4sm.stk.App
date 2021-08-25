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
    /// Мапинг сущности Связанные организации
    /// </summary>
    public class RelatedOrganizationsMap : ClassMapping<Bars.Stkomleks.RelatedOrganizations>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public RelatedOrganizationsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("RELATEDORGANIZATIONS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: RelatedOrganizations
ManyToOne(x => x.Organization, m => { m.Column("ORGANIZATION");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.RelatedOrg, m => { m.Column("RELATEDORG");m.Cascade(Cascade.Persist);});
#endregion
        }
    }

    }

