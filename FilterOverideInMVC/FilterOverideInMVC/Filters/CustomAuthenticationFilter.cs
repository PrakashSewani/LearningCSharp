using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
namespace FilterOverrideinMVC.Filters
{
    public class CustomAuthenticationFilter : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["UserID"])))
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "Error"
                };
            }
        }
        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
        }
    }
}