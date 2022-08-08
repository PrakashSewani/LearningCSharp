using FilterOverrideinMVC.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterOverideInMVC.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuthenticationFilter]
        public ActionResult Index()
        {
            return View();
        }

        [OverrideAuthentication]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}