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
    /// Мапинг сущности Подразделения
    /// </summary>
    public class DepartmentsMap : ClassMapping<Bars.Stkomleks.Departments>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public DepartmentsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("DEPARTMENTS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: Departments
ManyToOne(x => x.Organization, m => { m.Column("ORGANIZATION");m.Cascade(Cascade.Persist);});
Property(x => x.Name, p => { p.Column(col => { col.Name("NAME");});});
ManyToOne(x => x.Type, m => { m.Column("TYPE");m.Cascade(Cascade.Persist);});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
#endregion
        }
    }

    }

