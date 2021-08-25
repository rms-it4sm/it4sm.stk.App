   
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
    /// Сервис для представления 'Работы.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Работы.Объект")]
	    public class CompositionWorksObjectsListService : ListViewService<Bars.Stkomleks.CompositionWorksObjects, Bars.Stkomleks.CompositionWorksObjectsListModel>, ICompositionWorksObjectsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public CompositionWorksObjectsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.CompositionWorksObjects> Filter(IQueryable<Bars.Stkomleks.CompositionWorksObjects> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.CompositionWorksObjectsListModel> Map(IQueryable<Bars.Stkomleks.CompositionWorksObjects> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.CompositionWorksObjectsListModel {
                 Id = x?.Id,
                    _TypeUid = "cd655c91-5a8f-427c-ab3a-d4c44234cb06",
                    ObjectElement_TypeElement_Name = ((System.String)(x?.ObjectElement?.TypeElement?.Name)),
                    WorkType_WorkType_Name = ((System.String)(x?.WorkType?.WorkType?.Name)),
                    PlanStart = ((System.DateTime?)(x?.PlanStart)),
                    PlanFinish = ((System.DateTime?)(x?.PlanFinish)),
                    MethodWork = ((Bars.Stkomleks.TypesWorkPerformers?)(x?.MethodWork)),
                    Executor = ((System.String)(x?.Executor)),
                    Comment = ((System.String)(x?.Comment)),
                    ObjectWork_Id = ((System.Int64?)(x?.ObjectWork?.Id)),
                    _State = x?.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = x.State.Id, Name = x.State.Name, TypeId = x.State.TypeId },
                    _StateName = x?.State?.Name,
                    _StateId = x?.State?.Id,
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.CompositionWorksObjectsListModel {
                Id = x.Id,
                    _TypeUid = "cd655c91-5a8f-427c-ab3a-d4c44234cb06",
                    ObjectElement_TypeElement_Name = ((System.String)(x.ObjectElement.TypeElement.Name)),
                    WorkType_WorkType_Name = ((System.String)(x.WorkType.WorkType.Name)),
                    PlanStart = ((System.DateTime?)(x.PlanStart)),
                    PlanFinish = ((System.DateTime?)(x.PlanFinish)),
                    MethodWork = ((Bars.Stkomleks.TypesWorkPerformers?)(x.MethodWork)),
                    Executor = ((System.String)(x.Executor)),
                    Comment = ((System.String)(x.Comment)),
                    ObjectWork_Id = ((System.Int64?)(x.ObjectWork.Id)),
                    _State = x.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = x.State.Id, Name = x.State.Name, TypeId = x.State.TypeId },
                    _StateName = x.State.Name,
                    _StateId = x.State.Id,
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.CompositionWorksObjectsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "cd655c91-5a8f-427c-ab3a-d4c44234cb06":
            itm._EditorName = "CompositionWorksObjectsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}