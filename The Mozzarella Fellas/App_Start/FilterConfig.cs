﻿using System.Web;
using System.Web.Mvc;

namespace The_Mozzarella_Fellas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
