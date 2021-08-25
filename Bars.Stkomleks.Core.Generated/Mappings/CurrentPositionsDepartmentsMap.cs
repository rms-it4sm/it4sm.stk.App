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
    /// Мапинг сущности Занимаемые должности подразделений
    /// </summary>
    public class CurrentPositionsDepartmentsMap : ClassMapping<Bars.Stkomleks.CurrentPositionsDepartments>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public CurrentPositionsDepartmentsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("CURRENTPOSITIONSDEPARTMENTS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: CurrentPositionsDepartments
ManyToOne(x => x.DepartmentPosition, m => { m.Column("DEPARTMENTPOSITION");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Staff, m => { m.Column("STAFF");m.Cascade(Cascade.Persist);});
Property(x => x.Start, p => { p.Column(col => { col.Name("START");});});
Property(x => x.Finish, p => { p.Column(col => { col.Name("FINISH");});});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
#endregion
        }
    }

    }

