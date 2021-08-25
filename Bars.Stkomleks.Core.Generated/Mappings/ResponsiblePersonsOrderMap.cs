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
    /// Мапинг сущности Ответственные лица заказа
    /// </summary>
    public class ResponsiblePersonsOrderMap : ClassMapping<Bars.Stkomleks.ResponsiblePersonsOrder>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ResponsiblePersonsOrderMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("RESPONSIBLEPERSONSORDER");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: ResponsiblePersonsOrder
ManyToOne(x => x.OrderOrganization, m => { m.Column("ORDERORGANIZATION");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Staff, m => { m.Column("STAFF");m.Cascade(Cascade.Persist);});
Property(x => x.Appointment, p => { p.Column(col => { col.Name("APPOINTMENT");});});
#endregion

#region Class: BaseEntity
Property(x => x.ObjectCreateDate, p => { p.Column(col => { col.Name("OBJECT_CREATE_DATE");});});
Property(x => x.ObjectEditDate, p => { p.Column(col => { col.Name("OBJECT_EDIT_DATE");});});
Property(x => x.ObjectVersion, p => { p.Column(col => { col.Name("OBJECT_VERSION");});});
#endregion
        }
    }

    }

