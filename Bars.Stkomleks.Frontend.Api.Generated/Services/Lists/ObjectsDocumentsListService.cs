   
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
    /// Сервис для представления 'Документы.Объект'
    /// </summary>
	[BarsUp.Utils.DisplayAttribute("Документы.Объект")]
	    public class ObjectsDocumentsListService : ListViewService<Bars.Stkomleks.ObjectsDocuments, Bars.Stkomleks.ObjectsDocumentsListModel>, IObjectsDocumentsListService 
    {        
		/// <summary>
        /// Сериализованные в json системные фильтры
        /// </summary>
        protected override string FiltersJson
		{
			get { return @"[]
"; }
		}
                                  
        public ObjectsDocumentsListService(IWindsorContainer container) 
            : base(container) { }

		/// <summary>
        /// Фильтрация исходного запроса
        /// </summary>
        /// <param name="entityQuery">Запрос сущностей</param>
        /// <param name="params">Параметры операции</param>
        /// <returns></returns>
        protected override IQueryable<Bars.Stkomleks.ObjectsDocuments> Filter(IQueryable<Bars.Stkomleks.ObjectsDocuments> entityQuery, BaseParams @params)
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
        public override IQueryable<Bars.Stkomleks.ObjectsDocumentsListModel> Map(IQueryable<Bars.Stkomleks.ObjectsDocuments> entityQuery)
        {			
            // формирование селектора			
            return entityQuery.IsMaterialized()
                ? entityQuery.AsEnumerable().Select(x => new Bars.Stkomleks.ObjectsDocumentsListModel {
                 Id = x?.Id,
                    _TypeUid = "f83926a7-db81-4655-acb3-9a95778fe130",
                    Comment = ((System.String)(x?.Comment)),
                    File = ((BarsUp.Modules.FileStorage.FileInfo)(x?.File)),
                    ObjectWork_Id = ((System.Int64?)(x?.ObjectWork?.Id)),
                }).AsQueryable()
                : entityQuery.Select(x => new Bars.Stkomleks.ObjectsDocumentsListModel {
                Id = x.Id,
                    _TypeUid = "f83926a7-db81-4655-acb3-9a95778fe130",
                    Comment = ((System.String)(x.Comment)),
                    File = ((BarsUp.Modules.FileStorage.FileInfo)(x.File)),
                    ObjectWork_Id = ((System.Int64?)(x.ObjectWork.Id)),
            });
        }

        
        
        protected override async Task ProcessResultAsync(IList<Bars.Stkomleks.ObjectsDocumentsListModel> elements, BaseParams @params, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // устанавливаем контроллер редактора для каждой из сущностей
foreach (var itm in elements)
{
    switch (itm._TypeUid)
    {
        case "f83926a7-db81-4655-acb3-9a95778fe130":
            itm._EditorName = "ObjectsDocumentsEditor";
            break;
    }
}
            
            await Task.CompletedTask;
        }

            }
}