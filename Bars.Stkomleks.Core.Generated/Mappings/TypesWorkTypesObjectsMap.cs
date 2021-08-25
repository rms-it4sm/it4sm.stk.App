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
    /// Мапинг сущности Виды работ.Типы объектов
    /// </summary>
    public class TypesWorkTypesObjectsMap : ClassMapping<Bars.Stkomleks.TypesWorkTypesObjects>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public TypesWorkTypesObjectsMap()         {
			Polymorphism(PolymorphismType.Explicit);
            Table("TYPESWORKTYPESOBJECTS");
            
            Id(x => x.Id, map => { 
    map.Column("id");
    map.Type(new Int64Type());
    map.Generator(new BarsUp.Modules.NH.IdGenerators.BulkSeq.BulkSequenceIdGeneratorDef());
 });
            
#region Class: TypesWorkTypesObjects
ManyToOne(x => x.WorkType, m => { m.Column("WORKTYPE");m.Cascade(Cascade.Persist);});
ManyToOne(x => x.ObjectType, m => { m.Column("OBJECTTYPE");m.Cascade(Cascade.Persist);});
#endregion
        }
    }

    }

