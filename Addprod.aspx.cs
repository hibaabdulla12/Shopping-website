using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Myproject
{
    public partial class Addprod : System.Web.UI.Page
    {
        ConnectionClass ob = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strpath = "~/image/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(strpath));

            string ins = "insert into categorytab values('" + TextBox1.Text + "','" + TextBox2.Text + "','"+strpath+"', 'available')";
            int i = ob.Fun_Nonquery(ins);
            if(i==1)
            {
                Label5.Text = "Category Added";
            }
        }
    }
}