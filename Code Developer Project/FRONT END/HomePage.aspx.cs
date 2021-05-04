using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FRONT_END
{
    public partial class _Default : Page
    {
      
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.Connection);

        private void AbrirImagem()
        {
            string imagem = ConfigurationManager.ConnectionStrings["FRONT_END.Properties.Settings.Connection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(imagem))
            {
                SqlCommand Command = new SqlCommand("SELECT * FROM Receita WHERE Aprovado = 1", Connection);
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                DataTable Table = new DataTable();
                Table.Load(Reader);
                gvReceitas.DataSource = Table;
                gvReceitas.DataBind();
                Connection.Close();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AbrirImagem();
            }
        }

        protected void gvReceitas_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void btnProcurar_Click(object sender, EventArgs e)
        {
            string Conn = ConfigurationManager.ConnectionStrings["FRONT_END.Properties.Settings.Connection"].ConnectionString;
            SqlConnection Connection = new SqlConnection(Conn);
            Connection.Open();
            SqlCommand Command = new SqlCommand();
            string query = "SELECT * FROM Receita WHERE Nome LIKE '%'+@Nome+ %";
            Command.CommandText = query;
            Command.Connection = Connection;
            Command.Parameters.AddWithValue("Nome", txtProcurar.Text);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(Command);
            adapter.Fill(table);
            gvReceitas.DataSource = table;
            gvReceitas.DataBind();
        }

        protected void txtProcurar_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}