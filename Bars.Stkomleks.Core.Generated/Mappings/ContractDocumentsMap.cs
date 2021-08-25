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
    /// Мапинг сущности Документы договоров
    /// </summary>
    public class ContractDocumentsMap : ClassMapping<Bars.Stkomleks.ContractDocuments>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ContractDocumentsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("CONTRACTDOCUMENTS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: ContractDocuments
ManyToOne(x => x.Side1, m => { m.Column("SIDE1");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.Side2, m => { m.Column("SIDE2");m.Cascade(Cascade.Persist);});
#endregion

#region Class: BaseEntity
Property(x => x.ObjectCreateDate, p => { p.Column(col => { col.Name("OBJECT_CREATE_DATE");});});
Property(x => x.ObjectEditDate, p => { p.Column(col => { col.Name("OBJECT_EDIT_DATE");});});
Property(x => x.ObjectVersion, p => { p.Column(col => { col.Name("OBJECT_VERSION");});});
#endregion

#region Class: Documents
ManyToOne(x => x.Type, m => { m.Column("TYPE");m.Cascade(Cascade.Persist);});
Property(x => x.ContractNumber, p => { p.Column(col => { col.Name("CONTRACTNUMBER");});});
Property(x => x.ContractDate, p => { p.Column(col => { col.Name("CONTRACTDATE");});});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
#endregion
        }
    }

    }

