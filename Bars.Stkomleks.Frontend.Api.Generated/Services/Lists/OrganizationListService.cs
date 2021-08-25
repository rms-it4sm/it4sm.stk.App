   
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
    /// Сервис для представления 'Организации'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Организации")]
	    public class OrganizationListService : ListViewService<Bars.Stkomleks.Organization, Bars.Stkomleks.OrganizationListModel>, IOrganizationListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public OrganizationListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.Organization> Filter(IQueryable<Bars.Stkomleks.Organization> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.OrganizationListModel> Map(IQueryable<Bars.Stkomleks.Organization> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.OrganizationListModel {
                 Id = x?.Id,
                    _TypeUid = "242b06d2-b239-47ad-b75a-cbf88a4b987b",
                    Name = ((System.String)(x?.Name)),
                    FullName = ((System.String)(x?.FullName)),
                    Comment = ((System.String)(x?.Comment)),
                    _State = x?.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = x.State.Id, Name = x.State.Name, TypeId = x.State.TypeId },
                    _StateName = x?.State?.Name,
                    _StateId = x?.State?.Id,
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.OrganizationListModel {
                Id = x.Id,
                    _TypeUid = "242b06d2-b239-47ad-b75a-cbf88a4b987b",
                    Name = ((System.String)(x.Name)),
                    FullName = ((System.String)(x.FullName)),
                    Comment = ((System.String)(x.Comment)),
                    _State = x.State == null ? null : new BarsUp.Modules.States.StateDTO(){ Id = x.State.Id, Name = x.State.Name, TypeId = x.State.TypeId },
                    _StateName = x.State.Name,
                    _StateId = x.State.Id,
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrganizationListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "242b06d2-b239-47ad-b75a-cbf88a4b987b":
            itm._EditorName = "OrganizationEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}