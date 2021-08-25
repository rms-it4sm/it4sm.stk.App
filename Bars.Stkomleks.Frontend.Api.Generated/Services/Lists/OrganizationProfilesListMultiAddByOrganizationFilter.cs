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
    /// Фильтр реестра 'Профили организаций' для операции множественного добавления
    /// </summary>
    public class OrganizationProfilesListMultiAddByOrganizationFilter : ListViewServiceMultiAdditionFilter<Bars.Stkomleks.ProfilesOrganizations, ProfilesOrganizationsListModel, Bars.Stkomleks.Organization>, IProfilesOrganizationsListServiceFilter
    {        
        /// <inheritdoc />
        protected override string FilterJson => "";

        /// <inheritdoc />
        protected override string PropertyName => "Organization";

        /// <inheritdoc />
        public override string MultiAddUid => "a472d882-baaf-4085-90e0-7c7dffa14f80";

        /// <summary>
        /// Создание нового экземпляра
        /// </summary>
        /// <param name="dataStore"></param>
        public OrganizationProfilesListMultiAddByOrganizationFilter(IInterceptedDataStore dataStore)
            :base(dataStore)
        {            
        }

        /// <inheritdoc />
        protected override IQueryable<Bars.Stkomleks.ProfilesOrganizations> FilterByRelation(IQueryable<Bars.Stkomleks.ProfilesOrganizations> entityQuery, Bars.Stkomleks.Organization entity)
        {
            var existentQuery = DataStore.GetAll<Bars.Stkomleks.OrganizationProfiles>()
                                    .Where(x => x.Organization != null && entity != null 
                                        && x.Organization.Id == entity.Id)
                                    .Select(x => x.Profile.Id);

            return existentQuery.IsMaterialized()
                ? entityQuery.WhereNotContains(x=>x.Id, existentQuery)
                : entityQuery.Where(x => existentQuery.All(f => f != x.Id));
        }
    }
}