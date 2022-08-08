using FirstMVCApplication.Models;
using FirstMVCApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public ViewResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Dillip",
                Gender = "Male",
                Department = "IT",
                Salary = 10000,
                AddressId = 1001
            };

            Address address = new Address()
            {
                AddressId = 1001,
                City = "Bhubaneswar",
                State = "Odisha",
                Country = "India",
                Pin = "755019"
            };

            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details"
            };

            return View(employeeDetailsViewModel);
        }

        public ViewResult ErrorPage()
        {
            return View(ErrorPage);
        }
    }
}
