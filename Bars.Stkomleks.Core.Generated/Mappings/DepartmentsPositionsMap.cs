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
    /// Мапинг сущности Должности подразделения
    /// </summary>
    public class DepartmentsPositionsMap : ClassMapping<Bars.Stkomleks.DepartmentsPositions>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public DepartmentsPositionsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("DEPARTMENTSPOSITIONS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: DepartmentsPositions
ManyToOne(x => x.Department, m => { m.Column("DEPARTMENT");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Type, m => { m.Column("TYPE");m.Cascade(Cascade.Persist);});
Property(x => x.Position, p => { p.Column(col => { col.Name("POSITION");});});
#endregion
        }
    }

    }

