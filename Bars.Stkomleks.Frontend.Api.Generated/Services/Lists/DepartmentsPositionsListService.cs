   
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
    /// Сервис для представления 'Должности.Подразделение'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Должности.Подразделение")]
	    public class DepartmentsPositionsListService : ListViewService<Bars.Stkomleks.DepartmentsPositions, Bars.Stkomleks.DepartmentsPositionsListModel>, IDepartmentsPositionsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public DepartmentsPositionsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.DepartmentsPositions> Filter(IQueryable<Bars.Stkomleks.DepartmentsPositions> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.DepartmentsPositionsListModel> Map(IQueryable<Bars.Stkomleks.DepartmentsPositions> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.DepartmentsPositionsListModel {
                 Id = x?.Id,
                    _TypeUid = "1cbc241a-85e4-47db-964b-6bec69dec86c",
                    Type_Name = ((System.String)(x?.Type?.Name)),
                    Position = ((System.String)(x?.Position)),
                    Department_Id = ((System.Int64?)(x?.Department?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.DepartmentsPositionsListModel {
                Id = x.Id,
                    _TypeUid = "1cbc241a-85e4-47db-964b-6bec69dec86c",
                    Type_Name = ((System.String)(x.Type.Name)),
                    Position = ((System.String)(x.Position)),
                    Department_Id = ((System.Int64?)(x.Department.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.DepartmentsPositionsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "1cbc241a-85e4-47db-964b-6bec69dec86c":
            itm._EditorName = "DepartmentsPositionsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}