using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            testEntities test = new testEntities();
            User user = test.Users.FirstOrDefault(u => u.Username == TextBox1.Text && u.Password == TextBox2.Text);
            if (user == null)
            {
                Label1.Visible = true;
            }
            else
            {
                Session["user"] = user;
                Response.Redirect("Home.aspx");
            }
        }
    }
}