using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    public class deleterecord
    {
        static void Main(string[] args)
        {
            new deleterecord().CreateTable();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-S7GOFP1\\SQLEXPRESS;database=Student;integrated security=SSPI");
                SqlCommand cmd = new SqlCommand("delete from student where id='101'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Succesfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs an error has occured!", ex);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
