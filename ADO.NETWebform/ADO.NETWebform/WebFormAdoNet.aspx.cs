using System;
using System.Data.SqlClient;

namespace ADO.NETWebform
{
    public partial class WebFormAdoNet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { 
        
        } 
        protected void ButtonId_Click(object sender, EventArgs r)
        {
            SqlConnection con = new SqlConnection();
        }
    }
}
