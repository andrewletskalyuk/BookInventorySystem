using System.Web.Http;

namespace LibraryInventory.API.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "RootRedirect",
                routeTemplate: "",
                defaults: new { controller = "Books", action = "GetBooks" }
            );
        }
    }
}