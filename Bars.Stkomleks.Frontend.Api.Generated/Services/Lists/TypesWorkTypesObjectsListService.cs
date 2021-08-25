   
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
    /// Сервис для представления 'Виды работ.Тип объекта'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Виды работ.Тип объекта")]
	    public class TypesWorkTypesObjectsListService : ListViewService<Bars.Stkomleks.TypesWorkTypesObjects, Bars.Stkomleks.TypesWorkTypesObjectsListModel>, ITypesWorkTypesObjectsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public TypesWorkTypesObjectsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.TypesWorkTypesObjects> Filter(IQueryable<Bars.Stkomleks.TypesWorkTypesObjects> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.TypesWorkTypesObjectsListModel> Map(IQueryable<Bars.Stkomleks.TypesWorkTypesObjects> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.TypesWorkTypesObjectsListModel {
                 Id = x?.Id,
                    _TypeUid = "ceb87fbf-759c-4e7f-bc92-3a605d913ad5",
                    WorkType_Name = ((System.String)(x?.WorkType?.Name)),
                    ObjectType_Id = ((System.Int64?)(x?.ObjectType?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.TypesWorkTypesObjectsListModel {
                Id = x.Id,
                    _TypeUid = "ceb87fbf-759c-4e7f-bc92-3a605d913ad5",
                    WorkType_Name = ((System.String)(x.WorkType.Name)),
                    ObjectType_Id = ((System.Int64?)(x.ObjectType.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.TypesWorkTypesObjectsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "ceb87fbf-759c-4e7f-bc92-3a605d913ad5":
            itm._EditorName = "TypesWorkTypesObjectsListMultiAddByObjectTypeEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}