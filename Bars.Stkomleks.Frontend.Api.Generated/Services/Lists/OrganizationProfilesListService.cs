   
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
    
    using Castle.Windsor;
	using NHibernate.Linq;

    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Designer.GeneratedApp.Attributes;
    using BarsUp.Designer.GeneratedApp.Queries;
    using BarsUp.Designer.Core;
    using BarsUp.Designer.Core.TypeSystem;
    using BarsUp.Modules.PostgreSql.DataAccess;
    using BarsUp.Extensions.Json;
    using BarsUp.Designer.GeneratedApp.Commons;
    using BarsUp.Designer.GeneratedApp.Lists;
	using BarsUp.DataAccess.Extentions;    
    
    using System.Threading;
    using System.Threading.Tasks;

    using BarsUp.DataAccess.HqlGenerators;

    /// <summary>
    /// Сервис для представления 'Профили.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Профили.Организация")]
	    public class OrganizationProfilesListService : ListViewService<Bars.Stkomleks.OrganizationProfiles, Bars.Stkomleks.OrganizationProfilesListModel>, IOrganizationProfilesListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public OrganizationProfilesListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.OrganizationProfiles> Filter(IQueryable<Bars.Stkomleks.OrganizationProfiles> entityQuery, BaseParams @params)
		{
            var query = base.Filter(entityQuery, @params);
            
            if (@params.IsNotNull())
            {                
				
                
                            }
            
            return query;
		}
  
        
        /// <summary>
        /// Формирование запроса на получение моделей
        /// </summary>
        public override IQueryable<Bars.Stkomleks.OrganizationProfilesListModel> Map(IQueryable<Bars.Stkomleks.OrganizationProfiles> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.OrganizationProfilesListModel {
                 Id = x?.Id,
                    _TypeUid = "2f3cc7da-d8a3-4c53-b83f-ec26f028202e",
                    Organization_Id = ((System.Int64?)(x?.Organization?.Id)),
                    Profile_Name = ((System.String)(x?.Profile?.Name)),
                    Organization_Name = ((System.String)(x?.Organization?.Name)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.OrganizationProfilesListModel {
                Id = x.Id,
                    _TypeUid = "2f3cc7da-d8a3-4c53-b83f-ec26f028202e",
                    Organization_Id = ((System.Int64?)(x.Organization.Id)),
                    Profile_Name = ((System.String)(x.Profile.Name)),
                    Organization_Name = ((System.String)(x.Organization.Name)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrganizationProfilesListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "2f3cc7da-d8a3-4c53-b83f-ec26f028202e":
            itm._EditorName = "OrganizationProfilesListMultiAddByOrganizationEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}