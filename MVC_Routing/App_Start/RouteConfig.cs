using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Root", "", defaults: new { controller = "Home", action = "Index" });
            routes.MapRoute("AltRoot", "Home", defaults: new { controller = "Home", action = "Index" });
            routes.MapRoute("ContactUs", "Contact", defaults: new { controller = "Home", action = "Contact" });

            routes.MapRoute("ActionDefault", "{controller}", new { action = "Index" });

            routes.MapRoute("FilmResult", "films/{name}/reviews", defaults: new { controller = "Films", action = "Reviews" });

            routes.MapRoute("NoActionParams", "{controller}/{action}");

            routes.MapRoute("FilmPoster",
                "films/{name}/poster/{width}/{height}", defaults: new { controller = "Films", action = "Poster", width = UrlParameter.Optional, height = UrlParameter.Optional });


            routes.MapRoute("BookDownload", "books/{id}/download", defaults: new { controller = "Books", action = "Download" });

            routes.MapRoute("ReviewBooks", "books/{name}/reviews", defaults: new { controller = "Books", action = "Reviews" });

            routes.MapRoute("BookPoster",
                "books/{name}/poster/{width}/{height}", defaults: new { controller = "Books", action = "Poster", width = UrlParameter.Optional, height = UrlParameter.Optional });

            routes.MapRoute("InfoBooks", "books/{name}/info", defaults: new { controller = "Books", action = "info" });

            //Route actionIdParam = new Route("{controller}/{action}/{id}", new MvcRouteHandler());
            //routes.Add(actionIdParam);

            routes.MapRoute("ActionNameParam", "{controller}/{action}/{name}");

            routes.MapRoute("ActionIDNameParams", "{controller}/{action}/{id}/{name}");

            //перехват всех маршрутов
             routes.MapRoute("ActionMultiParams", "{controller}/{action}/{*catchall}");

            routes.MapRoute("ActionId", "{controller}/{action}/{id}", null, constraints: new { id = @"\d+" });

            routes.MapRoute("LocaleRoute", "{lang}/{controller}/{action}/{id}", defaults: new { lang = UrlParameter.Optional, id = UrlParameter.Optional });



            //перехват любых параметров
            routes.MapRoute("Catch All Routes", "{*url}", defaults: new { controller = "Error", action = "ShowError" });
        }
    }
}
