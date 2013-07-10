using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.IO;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using MVC4Sample1.Models.FedEx;

namespace MVC4Sample1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        private const string DbFile = "Database1.mdf";
        private const string DbFile2 = "MySQLite.db";

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            populateDb();
        }

        private static void populateDb()
        {
            var sessionFactory = CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                // populate the database
                using (var transaction = session.BeginTransaction())
                {
                    var sched1 = new Schedule { IntervalInMinutes = 30, NextRunTime = DateTime.Now.AddDays(1) };
                    var sched2 = new Schedule { IntervalInMinutes = 60, NextRunTime = DateTime.Now.AddDays(2) };

                    session.SaveOrUpdate(sched1);
                    session.SaveOrUpdate(sched2);

                    transaction.Commit();
                }
            }
        }

        private static ISessionFactory CreateSessionFactory()
        {

            /*return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard
                    .UsingFile(DbFile))
                .Mappings(m =>
                    m.FluentMappings.AddFromAssemblyOf<MvcApplication>())
                .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();*/

            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                .ConnectionString(c => c.FromConnectionStringWithKey("Fedex")).ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Schedule>())
                .BuildSessionFactory();
        }

        private static void BuildSchema(Configuration config)
        {
            if (!File.Exists(DbFile))
                new SchemaExport(config).Create(false, true);
        }
    }
}