   
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
    /// Сервис для представления 'Виды должностей'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Виды должностей")]
	    public class PositionsTypesListService : ListViewService<Bars.Stkomleks.PositionsTypes, Bars.Stkomleks.PositionsTypesListModel>, IPositionsTypesListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public PositionsTypesListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.PositionsTypes> Filter(IQueryable<Bars.Stkomleks.PositionsTypes> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.PositionsTypesListModel> Map(IQueryable<Bars.Stkomleks.PositionsTypes> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.PositionsTypesListModel {
                 Id = x?.Id,
                    _TypeUid = "c3cd4337-81c8-466a-98ca-872e581dcf97",
                    Name = ((System.String)(x?.Name)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.PositionsTypesListModel {
                Id = x.Id,
                    _TypeUid = "c3cd4337-81c8-466a-98ca-872e581dcf97",
                    Name = ((System.String)(x.Name)),
            });
        }

        /// <summary>
        /// Получение сущности по модели
        /// </summary>
        public override async Task<Bars.Stkomleks.PositionsTypes> UnmapEntityAsync(PositionsTypesListModel model, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var entity = model.Id.HasValue && model.Id.Value > 0 ? await DataStore.GetAsync<Bars.Stkomleks.PositionsTypes>(model.Id.Value, cancellationToken) : new Bars.Stkomleks.PositionsTypes();
            entity.Name = model.Name;
            return entity;
        }

        /// <summary>
        /// Получение ссылочных сущностей по модели
        /// </summary>
        public override async Task<List<PersistentObject>> UnmapReferencedEntitiesAsync(PositionsTypesListModel model, Bars.Stkomleks.PositionsTypes entity, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var result = new List<PersistentObject>();
            return result;
        }

        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.PositionsTypesListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

                        
            await Task.CompletedTask;
        }

            }
}