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
    /// Фильтр реестра 'Организации' для операции множественного добавления
    /// </summary>
    public class RelatedOrganizationsListMultiAddByOrganizationFilter : ListViewServiceMultiAdditionFilter<Bars.Stkomleks.Organization, OrganizationListModel, Bars.Stkomleks.Organization>, IOrganizationListServiceFilter
    {        
        /// <inheritdoc />
        protected override string FilterJson => "";

        /// <inheritdoc />
        protected override string PropertyName => "Organization";

        /// <inheritdoc />
        public override string MultiAddUid => "1bcf57c5-52d3-402a-923f-46a6681796e1";

        /// <summary>
        /// Создание нового экземпляра
        /// </summary>
        /// <param name="dataStore"></param>
        public RelatedOrganizationsListMultiAddByOrganizationFilter(IInterceptedDataStore dataStore)
            :base(dataStore)
        {            
        }

        /// <inheritdoc />
        protected override IQueryable<Bars.Stkomleks.Organization> FilterByRelation(IQueryable<Bars.Stkomleks.Organization> entityQuery, Bars.Stkomleks.Organization entity)
        {
            var existentQuery = DataStore.GetAll<Bars.Stkomleks.RelatedOrganizations>()
                                    .Where(x => x.Organization != null && entity != null 
                                        && x.Organization.Id == entity.Id)
                                    .Select(x => x.RelatedOrg.Id);

            return existentQuery.IsMaterialized()
                ? entityQuery.WhereNotContains(x=>x.Id, existentQuery)
                : entityQuery.Where(x => existentQuery.All(f => f != x.Id));
        }
    }
}