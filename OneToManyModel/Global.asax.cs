using System.Data.Entity;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using CATS_Interview.App_Start;
using CATS_Interview.Model;
using System.Web.Optimization;

namespace CATS_Interview
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Database.SetInitializer<DatabaseContext>(new DatabaseContextInitialiser());
            Database.SetInitializer<DatabaseContext>(null);
            
            StartupConfig.CreateAutoMapperMaps();
        }
    }
}