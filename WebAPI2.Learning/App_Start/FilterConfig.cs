using System.Web;
using System.Web.Mvc;
using WebAPI2.Learning.Filters;

namespace WebAPI2.Learning
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            
            filters.Add(new HandleErrorAttribute());
        }
    }
}
