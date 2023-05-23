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
    public partial class ViewCategory : System.Web.UI.Page
    {
        ConnectionClass ob = new ConnectionClass();
        SqlConnection con = new SqlConnection(@"server=LAPTOP-67061SDE\SQLEXPRESS;database=Shopping;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_ViewProducts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                Response.Redirect("ViewProduct.aspx");
            }
            con.Close();
        }
    }
}