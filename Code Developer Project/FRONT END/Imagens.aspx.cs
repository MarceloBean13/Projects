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
    public partial class Imagens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(Properties.Settings.Default.Connection);
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.Text;
            Command.CommandText = "INSERT Receita VALUES (@Nome, @Imagem)";
            Command.Parameters.AddWithValue("@Nome", txtTítulo.Text);

            if (fuImagem.HasFile)
            {
                fuImagem.SaveAs(Server.MapPath("Imagens/" + fuImagem.FileName));
                Command.Parameters.AddWithValue("@Imagem", "Imagens/" + fuImagem.FileName);
            }
            else
                Command.Parameters.AddWithValue("@Imagem", "");
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
        }
    }
}