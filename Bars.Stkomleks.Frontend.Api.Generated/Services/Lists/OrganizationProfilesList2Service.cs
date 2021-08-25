   
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
    /// Сервис для представления 'Организации по профилю.Выбор'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Организации по профилю.Выбор")]
	    public class OrganizationProfilesList2Service : ListViewService<Bars.Stkomleks.OrganizationProfiles, Bars.Stkomleks.OrganizationProfilesList2Model>, IOrganizationProfilesList2Service 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public OrganizationProfilesList2Service(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.OrganizationProfiles> Filter(IQueryable<Bars.Stkomleks.OrganizationProfiles> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.OrganizationProfilesList2Model> Map(IQueryable<Bars.Stkomleks.OrganizationProfiles> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.OrganizationProfilesList2Model {
                 Id = x?.Id,
                    _TypeUid = "2f3cc7da-d8a3-4c53-b83f-ec26f028202e",
                    Organization_Name = ((System.String)(x?.Organization?.Name)),
                    Profile_Name = ((System.String)(x?.Profile?.Name)),
                    Organization_Id = ((System.Int64?)(x?.Organization?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.OrganizationProfilesList2Model {
                Id = x.Id,
                    _TypeUid = "2f3cc7da-d8a3-4c53-b83f-ec26f028202e",
                    Organization_Name = ((System.String)(x.Organization.Name)),
                    Profile_Name = ((System.String)(x.Profile.Name)),
                    Organization_Id = ((System.Int64?)(x.Organization.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.OrganizationProfilesList2Model> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

                        
            await Task.CompletedTask;
        }

            }
}