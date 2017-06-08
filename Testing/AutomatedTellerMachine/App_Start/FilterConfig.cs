using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new MyErrorHandlerAttribute());
            filters.Add(new MyLoggingFilterAttribute());
        }

    }
}
