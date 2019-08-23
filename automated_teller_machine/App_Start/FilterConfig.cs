using System.Web;
using System.Web.Mvc;

namespace automated_teller_machine
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyLoggingFilterAttribute());
        }
    }
}
