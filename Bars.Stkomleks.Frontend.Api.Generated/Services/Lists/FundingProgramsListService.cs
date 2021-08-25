   
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
    /// Сервис для представления 'Программы финансирования'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Программы финансирования")]
	    public class FundingProgramsListService : ListViewService<Bars.Stkomleks.FundingPrograms, Bars.Stkomleks.FundingProgramsListModel>, IFundingProgramsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public FundingProgramsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.FundingPrograms> Filter(IQueryable<Bars.Stkomleks.FundingPrograms> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.FundingProgramsListModel> Map(IQueryable<Bars.Stkomleks.FundingPrograms> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.FundingProgramsListModel {
                 Id = x?.Id,
                    _TypeUid = "60a5fdca-979f-4332-9a9e-9a1fbd66665a",
                    Name = ((System.String)(x?.Name)),
                    Comment = ((System.String)(x?.Comment)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.FundingProgramsListModel {
                Id = x.Id,
                    _TypeUid = "60a5fdca-979f-4332-9a9e-9a1fbd66665a",
                    Name = ((System.String)(x.Name)),
                    Comment = ((System.String)(x.Comment)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.FundingProgramsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "60a5fdca-979f-4332-9a9e-9a1fbd66665a":
            itm._EditorName = "FundingProgramsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}