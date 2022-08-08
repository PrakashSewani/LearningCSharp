using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkBasics
{
    public class DbContext
    {
    }

    public class Student
    {
        public int StuID { get; set; }
        public string StuName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }

    }
    public class Grade
    {
        public int Grdld { get; set; }
        public string GrdName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
