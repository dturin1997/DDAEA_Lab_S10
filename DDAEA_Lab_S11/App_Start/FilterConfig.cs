using System.Web;
using System.Web.Mvc;

namespace DDAEA_Lab_S11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
