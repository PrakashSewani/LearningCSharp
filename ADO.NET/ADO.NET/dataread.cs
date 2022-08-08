using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NET
{
    public class dataread
    {
        static void Main(string[] args)
        {
            new dataread().CreateTable();
        }

        private void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-S7GOFP1\\SQLEXPRESS;database=Student;integrated security=SSPI");
                SqlCommand cm = new SqlCommand("Select * from student", con);
                con.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["id"] + " " + dr["name"] + " " + dr["email"]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("OOps an error has occured!/n", e);
            }
            finally
            {
                con.Close();
            }
        }  
    }
}
