   
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
    /// Сервис для представления 'Типы документов'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Типы документов")]
	    public class DocumentsTypeListService : ListViewService<Bars.Stkomleks.DocumentsType, Bars.Stkomleks.DocumentsTypeListModel>, IDocumentsTypeListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public DocumentsTypeListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.DocumentsType> Filter(IQueryable<Bars.Stkomleks.DocumentsType> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.DocumentsTypeListModel> Map(IQueryable<Bars.Stkomleks.DocumentsType> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.DocumentsTypeListModel {
                 Id = x?.Id,
                    _TypeUid = "99acad7b-98b7-44d0-8116-ae5e6a2f4dd5",
                    Name = ((System.String)(x?.Name)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.DocumentsTypeListModel {
                Id = x.Id,
                    _TypeUid = "99acad7b-98b7-44d0-8116-ae5e6a2f4dd5",
                    Name = ((System.String)(x.Name)),
            });
        }

        /// <summary>
        /// Получение сущности по модели
        /// </summary>
        public override async Task<Bars.Stkomleks.DocumentsType> UnmapEntityAsync(DocumentsTypeListModel model, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var entity = model.Id.HasValue && model.Id.Value > 0 ? await DataStore.GetAsync<Bars.Stkomleks.DocumentsType>(model.Id.Value, cancellationToken) : new Bars.Stkomleks.DocumentsType();
            entity.Name = model.Name;
            return entity;
        }

        /// <summary>
        /// Получение ссылочных сущностей по модели
        /// </summary>
        public override async Task<List<PersistentObject>> UnmapReferencedEntitiesAsync(DocumentsTypeListModel model, Bars.Stkomleks.DocumentsType entity, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var result = new List<PersistentObject>();
            return result;
        }

        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.DocumentsTypeListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

                        
            await Task.CompletedTask;
        }

            }
}