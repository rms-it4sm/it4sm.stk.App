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
    /// Мапинг сущности Физические лица
    /// </summary>
    public class IndividualsMap : ClassMapping<Bars.Stkomleks.Individuals>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public IndividualsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("INDIVIDUALS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: Individuals
Property(x => x.Surname, p => { p.Column(col => { col.Name("SURNAME");});});
Property(x => x.Name, p => { p.Column(col => { col.Name("NAME");});});
Property(x => x.Patronymic, p => { p.Column(col => { col.Name("PATRONYMIC");});});
Property(x => x.FIO, p => { p.Column(col => { col.Name("FIO");});});
Property(x => x.Comment, p => { p.Column(col => { col.Name("COMMENT");});});
#endregion
        }
    }

    }

