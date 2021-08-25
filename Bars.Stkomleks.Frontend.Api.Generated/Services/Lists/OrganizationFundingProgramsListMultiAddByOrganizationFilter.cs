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
    /// Фильтр реестра 'Программы финансирования' для операции множественного добавления
    /// </summary>
    public class OrganizationFundingProgramsListMultiAddByOrganizationFilter : ListViewServiceMultiAdditionFilter<Bars.Stkomleks.FundingPrograms, FundingProgramsListModel, Bars.Stkomleks.Organization>, IFundingProgramsListServiceFilter
    {        
        /// <inheritdoc />
        protected override string FilterJson => "";

        /// <inheritdoc />
        protected override string PropertyName => "Organization";

        /// <inheritdoc />
        public override string MultiAddUid => "6da929c6-59b4-437b-8fc6-ad6cec6b69d5";

        /// <summary>
        /// Создание нового экземпляра
        /// </summary>
        /// <param name="dataStore"></param>
        public OrganizationFundingProgramsListMultiAddByOrganizationFilter(IInterceptedDataStore dataStore)
            :base(dataStore)
        {            
        }

        /// <inheritdoc />
        protected override IQueryable<Bars.Stkomleks.FundingPrograms> FilterByRelation(IQueryable<Bars.Stkomleks.FundingPrograms> entityQuery, Bars.Stkomleks.Organization entity)
        {
            var existentQuery = DataStore.GetAll<Bars.Stkomleks.OrganizationFundingPrograms>()
                                    .Where(x => x.Organization != null && entity != null 
                                        && x.Organization.Id == entity.Id)
                                    .Select(x => x.FundingPrograms.Id);

            return existentQuery.IsMaterialized()
                ? entityQuery.WhereNotContains(x=>x.Id, existentQuery)
                : entityQuery.Where(x => existentQuery.All(f => f != x.Id));
        }
    }
}