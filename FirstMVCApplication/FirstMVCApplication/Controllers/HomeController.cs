using System.Diagnostics;
using FirstMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index(int id)
        {
            EmployeeBusinessLayer employeBL=new EmployeeBusinessLayer();
            Employee employee = employeBL.GetEmployeeDetails(0);
            ViewBag.Header = "Employee Details";

            return View(employee);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}