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
    public partial class CriarUtilizador : System.Web.UI.Page
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.Connection);
        protected void Page_Load(object sender, EventArgs e)         
        {         
                    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "UtilizadorInserir";
                Command.Parameters.AddWithValue("@Nome", txtNome.Text);
                Command.Parameters.AddWithValue("@UltimoNome", txtUltimoNome.Text);
                Command.Parameters.AddWithValue("@Email", txtEmail.Text);
                Command.Parameters.AddWithValue("@Username", txtUsername.Text);
                Command.Parameters.AddWithValue("@Password", txtPassword.Text);
                Connection.Open();
                Command.ExecuteNonQuery();
                lbSucesso.Visible = true; 
                Connection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error"+ ex.ToString());
            }
        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Connection.Open();
            string query = "SELECT Username FROM Utilizador";
            SqlCommand Command = new SqlCommand(query, Connection);
            SqlDataReader Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                if (Reader["Username"].ToString().ToUpper() == txtUsername.Text.ToUpper())
                {
                    lbUsernameExiste.Text = "Utilizador Já Existe!";
                }
                else
                    lbUsernameExiste.Text = "";
            }
        }
    }
}