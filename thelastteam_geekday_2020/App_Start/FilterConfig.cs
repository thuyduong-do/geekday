﻿using System.Web;
using System.Web.Mvc;

namespace thelastteam_geekday_2020
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
