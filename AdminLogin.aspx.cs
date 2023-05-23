using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Myproject
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(reg_id) from logtab";
            string regid = obj.Fun_scalar(sel);
            int RegID = 0;
            if (regid == "")
            {
                RegID = 1;
            }
            else
            {
                int new_regid = Convert.ToInt32(regid);
                RegID = new_regid + 1;
            }

            string ins = "insert into logtab values(" + RegID + ",'" + TextBox1.Text + "'," + TextBox2.Text + ",'admin','active')";
            int i = obj.Fun_Nonquery(ins);

            Session["uid"] = i;
            Response.Redirect("AdminHome.aspx");
        }
    }
}