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
    /// Мапинг сущности Программы финансирования организации
    /// </summary>
    public class OrganizationFundingProgramsMap : ClassMapping<Bars.Stkomleks.OrganizationFundingPrograms>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public OrganizationFundingProgramsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("ORGANIZATIONFUNDINGPROGRAMS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: OrganizationFundingPrograms
ManyToOne(x => x.Organization, m => { m.Column("ORGANIZATION");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.FundingPrograms, m => { m.Column("FUNDINGPROGRAMS");m.Cascade(Cascade.Persist);});
#endregion
        }
    }

    }

