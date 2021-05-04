using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace FRONT_END
{
    public partial class LogIn : System.Web.UI.Page
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.Connection);
        protected void Page_Load(object sender, EventArgs e)
        {
            lbErro.Visible = false;

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "UtilizadorEntrar";
            Command.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
            Command.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
            int count = Convert.ToInt32(Command.ExecuteScalar());
            if(count == 1)
            {
                Session["Username"] = txtUserName.Text.Trim();
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                lbErro.Visible = true;
            }
        }
    }
}