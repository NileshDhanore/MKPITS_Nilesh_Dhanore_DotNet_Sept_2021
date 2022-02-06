using System.Web;
using System.Web.Mvc;

namespace MVC_Form_Ccllection_Study
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
