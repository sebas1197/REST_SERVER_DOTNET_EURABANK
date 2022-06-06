using System.Web;
using System.Web.Mvc;

namespace Servidor_Rest_Eureka_Dotnet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
