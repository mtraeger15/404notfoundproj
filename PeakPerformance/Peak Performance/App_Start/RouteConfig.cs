﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Peak_Performance
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Athlete Profile page",
            //    url: "Home/AthleteProfile",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "Coach Profile page",
            //    url: "Home/CoachProfile",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "index", id = UrlParameter.Optional },
                new string[] { "Peak_Performance.Controllers" }
                );
        }
    }
}