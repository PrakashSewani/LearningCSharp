using ExceptionFilterInMVC.Models;
using System.Web.Mvc;
namespace ExceptionFilterInMVC.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogCustomExceptionFilter());
        }
    }
}