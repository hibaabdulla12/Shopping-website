using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Myproject
{
    public partial class Addcategory : System.Web.UI.Page
    {
        ConnectionClass ob = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strpath = "~/image/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(strpath));
            
            string ins = "insert into productab values("+TextBox1.Text+",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + strpath + "',"+TextBox4.Text+",'yes','"+TextBox5.Text+"')";
            int i = ob.Fun_Nonquery(ins);
        }
    }
}