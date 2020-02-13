using System.Web;
using System.Web.Mvc;

namespace Weekend_Task_20191005
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
