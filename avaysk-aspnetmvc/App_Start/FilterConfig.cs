﻿using System.Web;
using System.Web.Mvc;

namespace avaysk_aspnetmvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}