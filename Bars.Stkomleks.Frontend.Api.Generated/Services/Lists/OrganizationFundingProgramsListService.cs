   
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
    /// Сервис для представления 'Программы.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Программы.Организация")]
	    public class OrganizationFundingProgramsListService : ListViewService<Bars.Stkomleks.OrganizationFundingPrograms, Bars.Stkomleks.OrganizationFundingProgramsListModel>, IOrganizationFundingProgramsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public OrganizationFundingProgramsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.OrganizationFundingPrograms> Filter(IQueryable<Bars.Stkomleks.OrganizationFundingPrograms> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.OrganizationFundingProgramsListModel> Map(IQueryable<Bars.Stkomleks.OrganizationFundingPrograms> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.OrganizationFundingProgramsListModel {
                 Id = x?.Id,
                    _TypeUid = "0de41a18-2d17-4f59-b60b-e39e0559c240",
                    FundingPrograms_Name = ((System.String)(x?.FundingPrograms?.Name)),
                    FundingPrograms_Comment = ((System.String)(x?.FundingPrograms?.Comment)),
                    Organization_Id = ((System.Int64?)(x?.Organization?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.OrganizationFundingProgramsListModel {
                Id = x.Id,
                    _TypeUid = "0de41a18-2d17-4f59-b60b-e39e0559c240",
                    FundingPrograms_Name = ((System.String)(x.FundingPrograms.Name)),
                    FundingPrograms_Comment = ((System.String)(x.FundingPrograms.Comment)),
                    Organization_Id = ((System.Int64?)(x.Organization.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrganizationFundingProgramsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "0de41a18-2d17-4f59-b60b-e39e0559c240":
            itm._EditorName = "OrganizationFundingProgramsListMultiAddByOrganizationEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}