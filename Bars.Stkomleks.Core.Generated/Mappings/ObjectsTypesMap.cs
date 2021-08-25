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
    /// Мапинг сущности Типы объектов
    /// </summary>
    public class ObjectsTypesMap : ClassMapping<Bars.Stkomleks.ObjectsTypes>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ObjectsTypesMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("OBJECTSTYPES");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: ObjectsTypes
Property(x => x.Name, p => { p.Column(col => { col.Name("NAME");});});
Property(x => x.IconObjectType, p => { p.Column(col => { col.Name("ICONOBJECTTYPE");});});
Property(x => x.ColorIconObjectType, p => { p.Column(col => { col.Name("COLORICONOBJECTTYPE");});});
#endregion
        }
    }

    }

