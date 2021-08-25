namespace Bars.Stkomleks
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using BarsUp.DataAccess;
    using BarsUp.Extensions.Expressions;
    using BarsUp.Modules.PostgreSql.DataAccess;
    using BarsUp.Modules.PostgreSql.DataAccess.Npgsql;
    using BarsUp.Designer.GeneratedApp;
    using BarsUp.Application;

    using NHibernate.Cfg;
    using NHibernate.Hql.Ast;
    using NHibernate.Linq;
    using NHibernate.Linq.Functions;
    using NHibernate.Linq.Visitors;
    using NHibernate.Util;

    /// <summary>
    /// Конфигуратор NHibernate
    /// </summary>
    internal class NHibernateConfigurator : INhibernateConfigModifier
    {
        public void Apply(Configuration configuration)
        {
                        
        }

        internal static void RegisterAll()
        {
            
            ExpressionParser.GlobalConfigurators.Add(x => x.Using(typeof(SqlFunctions)));
                                }
    }

    /// <summary>
    /// Статические методы для вызова sql-функций в linq-запросах
    /// </summary>
    public static class SqlFunctions
    {        
            }

    /// <summary>
    /// Статические методы расширения сущностей для вызова sql-функций в linq-запросах
    /// </summary>
    public static class SqlFunctionsEntitiesExtensions 
    {
            }
        
    }

