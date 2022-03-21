using System.Web;
using System.Web.Mvc;

namespace Strongly_Type_Helper_Method_Reg_Page
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
