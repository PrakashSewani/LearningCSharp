using System;
using System.Data.SqlClient;
namespace ADO.NET
{
    class program
    {
        static void Main(string[] args)
        {
            new program().CreateTable();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                //con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Student;Data Source=DESKTOP-S7GOFP1\\SQLEXPRESS");
                con = new SqlConnection("Data Source=DESKTOP-S7GOFP1\\SQLEXPRESS;database=Student;integrated security=SSPI");
                SqlCommand cmd = new SqlCommand("create table student_info(id int not null, Name varchar(100), Email varchar(50), Join_Date date)", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Succesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs something went wrong. "+e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}