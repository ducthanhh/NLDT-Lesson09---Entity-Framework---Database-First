﻿using System.Web;
using System.Web.Mvc;

namespace NLDT_lession09_Entity_Framework___Database_First
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
