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
    /// Мапинг сущности Виды работ
    /// </summary>
    public class WorksTypesMap : ClassMapping<Bars.Stkomleks.WorksTypes>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public WorksTypesMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("WORKSTYPES");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: WorksTypes
Property(x => x.Name, p => { p.Column(col => { col.Name("NAME");});});
#endregion
        }
    }

    }

