   
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
    /// Сервис для представления 'Профили организаций'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Профили организаций")]
	    public class ProfilesOrganizationsListService : ListViewService<Bars.Stkomleks.ProfilesOrganizations, Bars.Stkomleks.ProfilesOrganizationsListModel>, IProfilesOrganizationsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public ProfilesOrganizationsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.ProfilesOrganizations> Filter(IQueryable<Bars.Stkomleks.ProfilesOrganizations> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.ProfilesOrganizationsListModel> Map(IQueryable<Bars.Stkomleks.ProfilesOrganizations> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.ProfilesOrganizationsListModel {
                 Id = x?.Id,
                    _TypeUid = "239223c0-de50-410c-8e79-bd1e57b91b4e",
                    Name = ((System.String)(x?.Name)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.ProfilesOrganizationsListModel {
                Id = x.Id,
                    _TypeUid = "239223c0-de50-410c-8e79-bd1e57b91b4e",
                    Name = ((System.String)(x.Name)),
            });
        }

        /// <summary>
        /// Получение сущности по модели
        /// </summary>
        public override async Task<Bars.Stkomleks.ProfilesOrganizations> UnmapEntityAsync(ProfilesOrganizationsListModel model, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var entity = model.Id.HasValue && model.Id.Value > 0 ? await DataStore.GetAsync<Bars.Stkomleks.ProfilesOrganizations>(model.Id.Value, cancellationToken) : new Bars.Stkomleks.ProfilesOrganizations();
            entity.Name = model.Name;
            return entity;
        }

        /// <summary>
        /// Получение ссылочных сущностей по модели
        /// </summary>
        public override async Task<List<PersistentObject>> UnmapReferencedEntitiesAsync(ProfilesOrganizationsListModel model, Bars.Stkomleks.ProfilesOrganizations entity, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var result = new List<PersistentObject>();
            return result;
        }

        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.ProfilesOrganizationsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

                        
            await Task.CompletedTask;
        }

            }
}