﻿using System.Web;
using System.Web.Mvc;

namespace RestaurantJISH_phase21
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
