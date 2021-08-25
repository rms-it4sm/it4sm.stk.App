   
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
    /// Сервис для представления 'Единицы измерения'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Единицы измерения")]
	    public class UnitMeasureListService : ListViewService<Bars.Stkomleks.UnitMeasure, Bars.Stkomleks.UnitMeasureListModel>, IUnitMeasureListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public UnitMeasureListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.UnitMeasure> Filter(IQueryable<Bars.Stkomleks.UnitMeasure> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.UnitMeasureListModel> Map(IQueryable<Bars.Stkomleks.UnitMeasure> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.UnitMeasureListModel {
                 Id = x?.Id,
                    _TypeUid = "15100549-aaff-4972-981e-964ab1b0ecc6",
                    Nema = ((System.String)(x?.Nema)),
                    CutName = ((System.String)(x?.CutName)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.UnitMeasureListModel {
                Id = x.Id,
                    _TypeUid = "15100549-aaff-4972-981e-964ab1b0ecc6",
                    Nema = ((System.String)(x.Nema)),
                    CutName = ((System.String)(x.CutName)),
            });
        }

        /// <summary>
        /// Получение сущности по модели
        /// </summary>
        public override async Task<Bars.Stkomleks.UnitMeasure> UnmapEntityAsync(UnitMeasureListModel model, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var entity = model.Id.HasValue && model.Id.Value > 0 ? await DataStore.GetAsync<Bars.Stkomleks.UnitMeasure>(model.Id.Value, cancellationToken) : new Bars.Stkomleks.UnitMeasure();
            entity.Nema = model.Nema;
            entity.CutName = model.CutName;
            return entity;
        }

        /// <summary>
        /// Получение ссылочных сущностей по модели
        /// </summary>
        public override async Task<List<PersistentObject>> UnmapReferencedEntitiesAsync(UnitMeasureListModel model, Bars.Stkomleks.UnitMeasure entity, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var result = new List<PersistentObject>();
            return result;
        }

        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.UnitMeasureListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

                        
            await Task.CompletedTask;
        }

            }
}