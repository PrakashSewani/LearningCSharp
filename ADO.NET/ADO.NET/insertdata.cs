using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NET
{
   public class insertdata
    {
        static void Main(string[] args)
        {
            new insertdata().CreateTable();
        }

        private void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-S7GOFP1\\SQLEXPRESS;database=Student;integrated security=SSPI");
                con.Open();
                string a, b, c,d;
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine("Enter Details");
                    a = $"10{i}";
                    b = Console.ReadLine();
                    c = Console.ReadLine();
                    d = Console.ReadLine();
                    DateTime odate = Convert.ToDateTime(d);
                    SqlCommand cm = new SqlCommand($"insert into student(id, name, email, join_date)values('{a}', '{b}', '{c}', '{odate}')", con);
                    cm.ExecuteNonQuery();
                }
                Console.WriteLine("InsertSuccessful");
            }
            catch(Exception e)
            {
                Console.WriteLine("OOPs an error occurred " + e);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
