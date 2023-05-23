using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Myproject
{
    public partial class ViewProduct : System.Web.UI.Page
    {
        ConnectionClass ob = new ConnectionClass();
        SqlConnection con = new SqlConnection(@"server=LAPTOP-67061SDE\SQLEXPRESS;database=Shopping;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
           if(e.CommandName=="viewdetails")
            {
                Response.Redirect("ViewProductDetails.aspx?id=" + e.CommandArgument.ToString());
            }
        }
    }
}