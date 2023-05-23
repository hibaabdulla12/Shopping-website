using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Myproject
{
    public partial class adminreg : System.Web.UI.Page
    {
        ConnectionClass ob = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int admin_id = 1;
            string ins = "insert into  admintab  values("+admin_id+",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text +"')";
            int i = ob.Fun_Nonquery(ins);
            Session["uid"] = i;
            Response.Redirect("Addprod.aspx");
        }
    }
}