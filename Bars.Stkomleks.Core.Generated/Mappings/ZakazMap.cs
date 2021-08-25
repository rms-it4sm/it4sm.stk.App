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
    /// Мапинг сущности Заказы
    /// </summary>
    public class ZakazMap : ClassMapping<Bars.Stkomleks.Zakaz>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ZakazMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("ORDERS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: Zakaz
Property(x => x.Number, p => { p.Column(col => { col.Name("NUMBER");});});
Property(x => x.Date, p => { p.Column(col => { col.Name("DATE");});});
ManyToOne(x => x.Client, m => { m.Column("CLIENT");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.State, m => { m.Column("STATE");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Manager, m => { m.Column("MANAGER");m.Cascade(Cascade.Persist);});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
#endregion

#region Class: BaseEntity
Property(x => x.ObjectCreateDate, p => { p.Column(col => { col.Name("OBJECT_CREATE_DATE");});});
Property(x => x.ObjectEditDate, p => { p.Column(col => { col.Name("OBJECT_EDIT_DATE");});});
Property(x => x.ObjectVersion, p => { p.Column(col => { col.Name("OBJECT_VERSION");});});
#endregion
        }
    }

    }

