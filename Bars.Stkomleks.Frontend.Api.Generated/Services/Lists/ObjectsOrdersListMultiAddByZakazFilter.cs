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
    /// Фильтр реестра 'Объекты' для операции множественного добавления
    /// </summary>
    public class ObjectsOrdersListMultiAddByZakazFilter : ListViewServiceMultiAdditionFilter<Bars.Stkomleks.OrdersObjects, OrdersObjectsList2Model, Bars.Stkomleks.Zakaz>, IOrdersObjectsList2ServiceFilter
    {        
        /// <inheritdoc />
        protected override string FilterJson => "";

        /// <inheritdoc />
        protected override string PropertyName => "Zakaz";

        /// <inheritdoc />
        public override string MultiAddUid => "36888e22-6eb1-466a-956c-78abc60d0544";

        /// <summary>
        /// Создание нового экземпляра
        /// </summary>
        /// <param name="dataStore"></param>
        public ObjectsOrdersListMultiAddByZakazFilter(IInterceptedDataStore dataStore)
            :base(dataStore)
        {            
        }

        /// <inheritdoc />
        protected override IQueryable<Bars.Stkomleks.OrdersObjects> FilterByRelation(IQueryable<Bars.Stkomleks.OrdersObjects> entityQuery, Bars.Stkomleks.Zakaz entity)
        {
            var existentQuery = DataStore.GetAll<Bars.Stkomleks.ObjectsOrders>()
                                    .Where(x => x.Zakaz != null && entity != null 
                                        && x.Zakaz.Id == entity.Id)
                                    .Select(x => x.Object.Id);

            return existentQuery.IsMaterialized()
                ? entityQuery.WhereNotContains(x=>x.Id, existentQuery)
                : entityQuery.Where(x => existentQuery.All(f => f != x.Id));
        }
    }
}