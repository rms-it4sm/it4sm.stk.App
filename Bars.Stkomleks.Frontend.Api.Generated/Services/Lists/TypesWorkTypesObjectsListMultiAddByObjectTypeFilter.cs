namespace Bars.Stkomleks
{
using Bars.Stkomleks.Frontend.Abstractions.Generated;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using BarsUp;
    using BarsUp.DataAccess; 
    using System.Collections.Generic;
    
    using System.Diagnostics;
    using BarsUp.Windsor;
    using BarsUp.IoC;
    using BarsUp.Utils;

    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Designer.GeneratedApp.Commons;
    using BarsUp.Designer.GeneratedApp.Lists;
    using BarsUp.Designer.GeneratedApp.Queries;
    using BarsUp.Designer.Core;
    using BarsUp.Designer.Core.TypeSystem;
	using BarsUp.DataAccess.Extentions;

	using NHibernate.Linq;

	/// <summary>
    /// Фильтр реестра 'Виды работ' для операции множественного добавления
    /// </summary>
    public class TypesWorkTypesObjectsListMultiAddByObjectTypeFilter : ListViewServiceMultiAdditionFilter<Bars.Stkomleks.WorksTypes, WorksTypesListModel, Bars.Stkomleks.ObjectsTypes>, IWorksTypesListServiceFilter
    {        
        /// <inheritdoc />
        protected override string FilterJson => "";

        /// <inheritdoc />
        protected override string PropertyName => "ObjectType";

        /// <inheritdoc />
        public override string MultiAddUid => "9ec9a8b2-fbc7-42e1-9afa-fc49346bd080";

        /// <summary>
        /// Создание нового экземпляра
        /// </summary>
        /// <param name="dataStore"></param>
        public TypesWorkTypesObjectsListMultiAddByObjectTypeFilter(IInterceptedDataStore dataStore)
            :base(dataStore)
        {            
        }

        /// <inheritdoc />
        protected override IQueryable<Bars.Stkomleks.WorksTypes> FilterByRelation(IQueryable<Bars.Stkomleks.WorksTypes> entityQuery, Bars.Stkomleks.ObjectsTypes entity)
        {
            var existentQuery = DataStore.GetAll<Bars.Stkomleks.TypesWorkTypesObjects>()
                                    .Where(x => x.ObjectType != null && entity != null 
                                        && x.ObjectType.Id == entity.Id)
                                    .Select(x => x.WorkType.Id);

            return existentQuery.IsMaterialized()
                ? entityQuery.WhereNotContains(x=>x.Id, existentQuery)
                : entityQuery.Where(x => existentQuery.All(f => f != x.Id));
        }
    }
}