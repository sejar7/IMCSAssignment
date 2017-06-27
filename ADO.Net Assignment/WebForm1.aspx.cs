using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO.Net.Assignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // SqlConnection conn = new SqlConnection("connectionString = testconnection;Data Source = DESKTOP - MSB2V76\SQLEXPRESS; Initial Catalog = TestDB; Integrated Security = True");
            //            SqlConnection conn = new SqlConnection("TestDBConnectionString");

            string constring = System.Configuration.ConfigurationManager.ConnectionStrings["TestDBConnectionString"].ConnectionString;
           
            string queryString = "SELECT * FROM dbo.Employees";
            int i = 0;

            using (SqlConnection connection = new SqlConnection(constring))
            using (SqlCommand command = new SqlCommand(queryString, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    // Call Read before accessing data.
                    while (reader.Read())
                    {
                        Response.Write("<br />User --> " + i);
                        i++;
                        
                        Response.Write("\nFirst Name : "+ reader[1]);
                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}