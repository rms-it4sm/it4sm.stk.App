   
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
    /// Сервис для представления 'Типы контактов'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Типы контактов")]
	    public class ContactsTypeListService : ListViewService<Bars.Stkomleks.ContactsType, Bars.Stkomleks.ContactsTypeListModel>, IContactsTypeListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public ContactsTypeListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.ContactsType> Filter(IQueryable<Bars.Stkomleks.ContactsType> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.ContactsTypeListModel> Map(IQueryable<Bars.Stkomleks.ContactsType> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.ContactsTypeListModel {
                 Id = x?.Id,
                    _TypeUid = "a94c08c3-bfc2-4c72-ae81-c082487d5588",
                    Name = ((System.String)(x?.Name)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.ContactsTypeListModel {
                Id = x.Id,
                    _TypeUid = "a94c08c3-bfc2-4c72-ae81-c082487d5588",
                    Name = ((System.String)(x.Name)),
            });
        }

        /// <summary>
        /// Получение сущности по модели
        /// </summary>
        public override async Task<Bars.Stkomleks.ContactsType> UnmapEntityAsync(ContactsTypeListModel model, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var entity = model.Id.HasValue && model.Id.Value > 0 ? await DataStore.GetAsync<Bars.Stkomleks.ContactsType>(model.Id.Value, cancellationToken) : new Bars.Stkomleks.ContactsType();
            entity.Name = model.Name;
            return entity;
        }

        /// <summary>
        /// Получение ссылочных сущностей по модели
        /// </summary>
        public override async Task<List<PersistentObject>> UnmapReferencedEntitiesAsync(ContactsTypeListModel model, Bars.Stkomleks.ContactsType entity, BaseParams @params, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            var result = new List<PersistentObject>();
            return result;
        }

        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.ContactsTypeListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

                        
            await Task.CompletedTask;
        }

            }
}