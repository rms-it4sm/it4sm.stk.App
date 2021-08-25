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
    /// Мапинг сущности Работы объектов
    /// </summary>
    public class CompositionWorksObjectsMap : ClassMapping<Bars.Stkomleks.CompositionWorksObjects>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public CompositionWorksObjectsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("COMPOSITIONWORKSOBJECTS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: CompositionWorksObjects
ManyToOne(x => x.ObjectWork, m => { m.Column("OBJECTWORK");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Type, m => { m.Column("TYPE");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.WorkType, m => { m.Column("WORKTYPE");m.Cascade(Cascade.Persist);});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
ManyToOne(x => x.ObjectElement, m => { m.Column("OBJECTELEMENT");m.Cascade(Cascade.Persist);});
Property(x => x.Scope, p => { p.Column(col => { col.Name("SCOPE");});});
ManyToOne(x => x.UnutMeasure, m => { m.Column("UNUTMEASURE");m.Cascade(Cascade.Persist);});
Property(x => x.MethodWork, p => { p.Column(cm=>{cm.Name("METHODWORK"); cm.Default(1); });});
ManyToOne(x => x.ContractorWork, m => { m.Column("CONTRACTORWORK");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Brigade, m => { m.Column("BRIGADE");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.State, m => { m.Column("STATE");m.Cascade(Cascade.Persist);});
Property(x => x.PlanStart, p => { p.Column(col => { col.Name("PLANSTART");});});
Property(x => x.PlanFinish, p => { p.Column(col => { col.Name("PLANFINISH");});});
Property(x => x.Executor, p => { p.Column(col => { col.Name("EXECUTOR");});});
#endregion
        }
    }

    }

