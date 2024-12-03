using LibraryInventory.API.App_Start;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;

namespace LibraryInventory.API
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            //we need to register webapi config
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
