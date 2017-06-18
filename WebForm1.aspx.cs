using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAssignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load" + "<br/>");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init" + "<br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_InitComplete" + "<br/>");
        }
        
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad" + "<br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        { Response.Write("Page_LoadComplete" + "<br/>"); }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender" + "<br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page_PreRenderComplete" + "<br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("Page_Unload" + "<br/>"); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            using (writer =
            new StreamWriter(@"C:\Users\Rajesh\Desktop\Desktop\WebAppData.txt"))
            {
                writer.WriteLine("Student Name is {0} {1}", txtFirstName.Text, txtLastName.Text);
                writer.Write("Batch Name" + txtBatch.Text);
            }
            if (writer != null)
            {
                //Server.Transfer("success.aspx", true);
                Session["Batch"] = txtBatch.Text;
                Response.Redirect("~/success.aspx?FirstName="+txtFirstName.Text+"&Lastname="+txtLastName.Text);
                
            }
        }
    }
}