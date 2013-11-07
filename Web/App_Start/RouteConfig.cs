using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default", "", new { controller = "Home", action = "Index" });
            routes.MapRoute("Join", "{key}", new { controller = "Event", action = "Join" });
            routes.MapRoute("Host", "{key}/host", new { controller = "Event", action = "Host" });

            routes.MapRoute(
                "Fallback",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
