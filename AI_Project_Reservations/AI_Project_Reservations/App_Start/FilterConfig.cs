﻿using System.Web;
using System.Web.Mvc;

namespace AI_Project_Reservations
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}