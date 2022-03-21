using System.Web;
using System.Web.Mvc;

namespace Resistration_Form_byHelper_Method
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
