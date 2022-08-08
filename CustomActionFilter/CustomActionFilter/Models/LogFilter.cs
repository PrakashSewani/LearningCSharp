using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomActionFilter.Models
{
    public class LogFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExcuted",filterContext.RouteData);
        }
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);
        }

        private void Log(string methodName,RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["actions"];

            string message = methodName + " Controller:" + controllerName + " Action:" + actionName + " Date: "
                            + DateTime.Now.ToString() + Environment.NewLine;

            File.AppendAllText(HttpContext.Current.Server.MapPath("~/Log/Log.txt"), message);
        }

    }
}