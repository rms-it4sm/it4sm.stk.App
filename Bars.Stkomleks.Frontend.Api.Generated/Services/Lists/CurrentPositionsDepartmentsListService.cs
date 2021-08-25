   
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
    /// Сервис для представления 'Занимаемые должности.Подразделение'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Занимаемые должности.Подразделение")]
	    public class CurrentPositionsDepartmentsListService : ListViewService<Bars.Stkomleks.CurrentPositionsDepartments, Bars.Stkomleks.CurrentPositionsDepartmentsListModel>, ICurrentPositionsDepartmentsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public CurrentPositionsDepartmentsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.CurrentPositionsDepartments> Filter(IQueryable<Bars.Stkomleks.CurrentPositionsDepartments> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.CurrentPositionsDepartmentsListModel> Map(IQueryable<Bars.Stkomleks.CurrentPositionsDepartments> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.CurrentPositionsDepartmentsListModel {
                 Id = x?.Id,
                    _TypeUid = "788a15f1-40ba-4144-b7a9-45ce08fb1ffc",
                    Start = ((System.DateTime?)(x?.Start)),
                    Finish = ((System.DateTime?)(x?.Finish)),
                    Staff_Individual_FIO = ((System.String)(x?.Staff?.Individual?.FIO)),
                    Comment = ((System.String)(x?.Comment)),
                    DepartmentPosition_Id = ((System.Int64?)(x?.DepartmentPosition?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.CurrentPositionsDepartmentsListModel {
                Id = x.Id,
                    _TypeUid = "788a15f1-40ba-4144-b7a9-45ce08fb1ffc",
                    Start = ((System.DateTime?)(x.Start)),
                    Finish = ((System.DateTime?)(x.Finish)),
                    Staff_Individual_FIO = ((System.String)(x.Staff.Individual.FIO)),
                    Comment = ((System.String)(x.Comment)),
                    DepartmentPosition_Id = ((System.Int64?)(x.DepartmentPosition.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.CurrentPositionsDepartmentsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "788a15f1-40ba-4144-b7a9-45ce08fb1ffc":
            itm._EditorName = "CurrentPositionsDepartmentsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}