using ProductSearch.Migrations;
using ProductSearch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ProductSearch
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer(
        new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>()
    );

            // optional: force initialization now so errors surface early
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Database.Initialize(false);
            }
        }
    }
}
