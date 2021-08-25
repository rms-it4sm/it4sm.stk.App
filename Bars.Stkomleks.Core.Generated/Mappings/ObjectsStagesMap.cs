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
    /// Мапинг сущности УДЛ_Этапы объектов
    /// </summary>
    public class ObjectsStagesMap : ClassMapping<Bars.Stkomleks.ObjectsStages>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ObjectsStagesMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("OBJECTSSTAGES");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: ObjectsStages
ManyToOne(x => x.ObjectWork, m => { m.Column("OBJECTWORK");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.IncludidIn, m => { m.Column("INCLUDIDIN");m.Cascade(Cascade.Persist);});
Property(x => x.Stage, p => { p.Column(col => { col.Name("STAGE");});});
Property(x => x.Start, p => { p.Column(col => { col.Name("START");});});
Property(x => x.Finish, p => { p.Column(col => { col.Name("FINISH");});});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
#endregion
        }
    }

    }

