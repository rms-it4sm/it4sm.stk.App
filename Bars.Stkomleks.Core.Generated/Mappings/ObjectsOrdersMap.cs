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
    /// Мапинг сущности Заказы Объекты
    /// </summary>
    public class ObjectsOrdersMap : ClassMapping<Bars.Stkomleks.ObjectsOrders>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ObjectsOrdersMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("OBJECTSORDERS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: ObjectsOrders
ManyToOne(x => x.Zakaz, m => { m.Column("ZAKAZ");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Object, m => { m.Column("OBJECT");m.Cascade(Cascade.Persist);});
#endregion

#region Class: BaseEntity
Property(x => x.ObjectCreateDate, p => { p.Column(col => { col.Name("OBJECT_CREATE_DATE");});});
Property(x => x.ObjectEditDate, p => { p.Column(col => { col.Name("OBJECT_EDIT_DATE");});});
Property(x => x.ObjectVersion, p => { p.Column(col => { col.Name("OBJECT_VERSION");});});
#endregion
        }
    }

    }

