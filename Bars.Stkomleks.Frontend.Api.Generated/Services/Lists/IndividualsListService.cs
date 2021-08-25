   
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
    /// Сервис для представления 'Физические лица'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Физические лица")]
	    public class IndividualsListService : ListViewService<Bars.Stkomleks.Individuals, Bars.Stkomleks.IndividualsListModel>, IIndividualsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public IndividualsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.Individuals> Filter(IQueryable<Bars.Stkomleks.Individuals> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.IndividualsListModel> Map(IQueryable<Bars.Stkomleks.Individuals> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.IndividualsListModel {
                 Id = x?.Id,
                    _TypeUid = "49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d",
                    FIO = ((System.String)(x?.FIO)),
                    Comment = ((System.String)(x?.Comment)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.IndividualsListModel {
                Id = x.Id,
                    _TypeUid = "49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d",
                    FIO = ((System.String)(x.FIO)),
                    Comment = ((System.String)(x.Comment)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.IndividualsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "49ff94ac-ba6c-41dc-bd0c-4d0ffc9fbd3d":
            itm._EditorName = "IndividualsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}