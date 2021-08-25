   
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
    /// Сервис для представления 'Оганизации.Программа финансирования'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Оганизации.Программа финансирования")]
	    public class OrganizationFundingProgramsList2Service : ListViewService<Bars.Stkomleks.OrganizationFundingPrograms, Bars.Stkomleks.OrganizationFundingProgramsList2Model>, IOrganizationFundingProgramsList2Service 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public OrganizationFundingProgramsList2Service(IWindsorContainer container) 
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
        public override IQueryable<Bars.Stkomleks.OrganizationFundingProgramsList2Model> Map(IQueryable<Bars.Stkomleks.OrganizationFundingPrograms> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.OrganizationFundingProgramsList2Model {
                 Id = x?.Id,
                    _TypeUid = "0de41a18-2d17-4f59-b60b-e39e0559c240",
                    FundingPrograms_Id = ((System.Int64?)(x?.FundingPrograms?.Id)),
                    Organization_Name = ((System.String)(x?.Organization?.Name)),
                    Organization_Comment = ((System.String)(x?.Organization?.Comment)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.OrganizationFundingProgramsList2Model {
                Id = x.Id,
                    _TypeUid = "0de41a18-2d17-4f59-b60b-e39e0559c240",
                    FundingPrograms_Id = ((System.Int64?)(x.FundingPrograms.Id)),
                    Organization_Name = ((System.String)(x.Organization.Name)),
                    Organization_Comment = ((System.String)(x.Organization.Comment)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrganizationFundingProgramsList2Model> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

                        
            await Task.CompletedTask;
        }

            }
}