   
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
    /// Сервис для представления 'Подразделения.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Подразделения.Организация")]
	    public class DepartmentsListService : ListViewService<Bars.Stkomleks.Departments, Bars.Stkomleks.DepartmentsListModel>, IDepartmentsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public DepartmentsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.Departments> Filter(IQueryable<Bars.Stkomleks.Departments> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.DepartmentsListModel> Map(IQueryable<Bars.Stkomleks.Departments> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.DepartmentsListModel {
                 Id = x?.Id,
                    _TypeUid = "493d5e72-6f08-4da0-9fa7-bfd88e202a82",
                    Name = ((System.String)(x?.Name)),
                    Type_Name = ((System.String)(x?.Type?.Name)),
                    Comment = ((System.String)(x?.Comment)),
                    Organization_Id = ((System.Int64?)(x?.Organization?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.DepartmentsListModel {
                Id = x.Id,
                    _TypeUid = "493d5e72-6f08-4da0-9fa7-bfd88e202a82",
                    Name = ((System.String)(x.Name)),
                    Type_Name = ((System.String)(x.Type.Name)),
                    Comment = ((System.String)(x.Comment)),
                    Organization_Id = ((System.Int64?)(x.Organization.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.DepartmentsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "493d5e72-6f08-4da0-9fa7-bfd88e202a82":
            itm._EditorName = "DepartmentsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}