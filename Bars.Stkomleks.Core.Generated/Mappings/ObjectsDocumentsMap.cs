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
    /// Мапинг сущности Документы объекта
    /// </summary>
    public class ObjectsDocumentsMap : ClassMapping<Bars.Stkomleks.ObjectsDocuments>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ObjectsDocumentsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("OBJECTSDOCUMENTS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: ObjectsDocuments
ManyToOne(x => x.ObjectWork, m => { m.Column("OBJECTWORK");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.File, m => { m.Column("FILE");});
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

