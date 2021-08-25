   
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
    /// Сервис для представления 'Связанные организации.Организация'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Связанные организации.Организация")]
	    public class RelatedOrganizationsListService : ListViewService<Bars.Stkomleks.RelatedOrganizations, Bars.Stkomleks.RelatedOrganizationsListModel>, IRelatedOrganizationsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public RelatedOrganizationsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.RelatedOrganizations> Filter(IQueryable<Bars.Stkomleks.RelatedOrganizations> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.RelatedOrganizationsListModel> Map(IQueryable<Bars.Stkomleks.RelatedOrganizations> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.RelatedOrganizationsListModel {
                 Id = x?.Id,
                    _TypeUid = "ba084c30-4998-4494-a718-d6eca64c6140",
                    Organization_Id = ((System.Int64?)(x?.Organization?.Id)),
                    RelatedOrg_Name = ((System.String)(x?.RelatedOrg?.Name)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.RelatedOrganizationsListModel {
                Id = x.Id,
                    _TypeUid = "ba084c30-4998-4494-a718-d6eca64c6140",
                    Organization_Id = ((System.Int64?)(x.Organization.Id)),
                    RelatedOrg_Name = ((System.String)(x.RelatedOrg.Name)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.RelatedOrganizationsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "ba084c30-4998-4494-a718-d6eca64c6140":
            itm._EditorName = "RelatedOrganizationsListMultiAddByOrganizationEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}