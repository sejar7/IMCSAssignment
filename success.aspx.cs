using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAssignment
{
    public partial class success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = Request.QueryString["FirstName"];
            lblLastName.Text = Request.QueryString["LastName"];
            if (!String.IsNullOrEmpty(Session["Batch"].ToString()))
            {

                //Read values from session
                lblBatch.Text = Session["Batch"].ToString();

            }
            else
            {
                Response.Write(Session["Batch"].ToString());
            }
            

        }
    }
}