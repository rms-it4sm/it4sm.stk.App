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
    /// Мапинг сущности Объекты
    /// </summary>
    public class OrdersObjectsMap : ClassMapping<Bars.Stkomleks.OrdersObjects>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public OrdersObjectsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("ORDERSOBJECTS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: OrdersObjects
ManyToOne(x => x.Zakaz, m => { m.Column("ZAKAZ");m.Cascade(Cascade.Persist);});
Property(x => x.Name, p => { p.Column(col => { col.Name("NAME");});});
ManyToOne(x => x.Type, m => { m.Column("TYPE");m.Cascade(Cascade.Persist);});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
ManyToOne(x => x.State, m => { m.Column("STATE");m.Cascade(Cascade.Persist);});
Property(x => x.Lat, p => { p.Column(col => { col.Name("LAT");});});
Property(x => x.Lon, p => { p.Column(col => { col.Name("LON");});});
#endregion

#region Class: BaseEntity
Property(x => x.ObjectCreateDate, p => { p.Column(col => { col.Name("OBJECT_CREATE_DATE");});});
Property(x => x.ObjectEditDate, p => { p.Column(col => { col.Name("OBJECT_EDIT_DATE");});});
Property(x => x.ObjectVersion, p => { p.Column(col => { col.Name("OBJECT_VERSION");});});
#endregion
        }
    }

    }

