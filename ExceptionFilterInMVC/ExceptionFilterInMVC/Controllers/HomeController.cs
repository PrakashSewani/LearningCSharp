using ExceptionFilterInMVC.Models;
using System;
using System.Web.Mvc;

namespace ExceptionFilterInMVC.Controllers
{
        //[LogCustomExceptionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        //[HandleError(ExceptionType =typeof(DivideByZeroException),View ="DivideByZero")]
        //[HandleError(ExceptionType =typeof(NullReferenceException),View ="NullReferenceException")]
        //[HandleError]
        public ActionResult Index()
        {
            throw new Exception("Something went Wrong");
        }
        public ActionResult About()
        {
            throw new NullReferenceException();
        }
        public ActionResult Contact()
        {
            throw new DivideByZeroException();
        }
    }
}