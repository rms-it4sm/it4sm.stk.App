   
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
    /// Сервис для представления 'Специалисты.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Специалисты.Объект")]
	    public class CompositionObjectSpecialistsListService : ListViewService<Bars.Stkomleks.CompositionObjectSpecialists, Bars.Stkomleks.CompositionObjectSpecialistsListModel>, ICompositionObjectSpecialistsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public CompositionObjectSpecialistsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.CompositionObjectSpecialists> Filter(IQueryable<Bars.Stkomleks.CompositionObjectSpecialists> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.CompositionObjectSpecialistsListModel> Map(IQueryable<Bars.Stkomleks.CompositionObjectSpecialists> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.CompositionObjectSpecialistsListModel {
                 Id = x?.Id,
                    _TypeUid = "e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2",
                    Object_Id = ((System.Int64?)(x?.Object?.Id)),
                    Role_Name = ((System.String)(x?.Role?.Name)),
                    Staff_DepartmentPosition_Position = ((System.String)(x?.Staff?.DepartmentPosition?.Position)),
                    Staff_Staff_Individual_FIO = ((System.String)(x?.Staff?.Staff?.Individual?.FIO)),
                    Comment = ((System.String)(x?.Comment)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.CompositionObjectSpecialistsListModel {
                Id = x.Id,
                    _TypeUid = "e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2",
                    Object_Id = ((System.Int64?)(x.Object.Id)),
                    Role_Name = ((System.String)(x.Role.Name)),
                    Staff_DepartmentPosition_Position = ((System.String)(x.Staff.DepartmentPosition.Position)),
                    Staff_Staff_Individual_FIO = ((System.String)(x.Staff.Staff.Individual.FIO)),
                    Comment = ((System.String)(x.Comment)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.CompositionObjectSpecialistsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "e5a2ed8e-4fc1-48a4-a766-c53ce1f2a7e2":
            itm._EditorName = "CompositionObjectSpecialistsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}