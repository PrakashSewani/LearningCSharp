namespace FirstMVCApplication.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeID)
        {
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeID,
                Name = "Pranya",
                Gender = "Male",
                City = "Mumbai",
                Salary = 1000,
                AddressId = 1454
            };
            return employee;
        }


    }
}
