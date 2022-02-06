using System.Web;
using System.Web.Mvc;

namespace Dynamic_Partial_View_Example2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
