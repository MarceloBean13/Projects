using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace FRONT_END
{
    public partial class Receitas : System.Web.UI.Page
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.Connection);

        string ID_receita = null, IDIngrediente = null;
       
        void PreencherUnidade()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "UnidadeMedidaSeleccionar";
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            ddlUnidade.DataSource = Table;
            ddlUnidade.DataValueField = "ID";
            ddlUnidade.DataTextField = "Sigla";
            ddlUnidade.DataBind();
         
            
        }
        void SeleccionarTipoCozinha()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TipoCozinhaSeleccionar";
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            ddlTipoCozinha.DataSource = Table;
            ddlTipoCozinha.DataValueField = "ID";
            ddlTipoCozinha.DataTextField = "Cozinha";
            ddlTipoCozinha.DataBind();
        }

        void SeleccionarTipoPrato()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TipoPratoSeleccionar";
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            ddlTipoPrato.DataSource = Table;
            ddlTipoPrato.DataValueField = "ID";
            ddlTipoPrato.DataTextField = "Prato";
            ddlTipoPrato.DataBind();
        }

        void SeleccionarTempoExecucao()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TempoExecucaoSeleccionar";
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            ddlTempo.DataSource = Table;
            ddlTempo.DataValueField = "ID";
            ddlTempo.DataTextField = "Tempo";
            ddlTempo.DataBind();
        }

        void SeleccionarNivelDificuldade()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "NivelDificuldadeSeleccionar";
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            ddlNivel.DataSource = Table;
            ddlNivel.DataValueField = "ID";
            ddlNivel.DataTextField = "Nome";
            ddlNivel.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            SeleccionarTipoCozinha();
            SeleccionarNivelDificuldade();
            SeleccionarTempoExecucao();
            SeleccionarTipoPrato();
            PreencherUnidade();
            LimparDados(this);
        }

        protected void dgvReceitas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;
            e.Row.Cells[6].Visible = false;
            e.Row.Cells[7].Visible = false;
            e.Row.Cells[8].Visible = false;
            e.Row.Cells[9].Visible = false;
            e.Row.Cells[10].Visible = false;
            e.Row.Cells[11].Visible = false;

            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[2].Text = "Nome da Receita";
                e.Row.Cells[2].Width = 250;
            }
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[2].Text = Server.HtmlDecode(e.Row.Cells[2].Text);
            }
        }

        void LimparDados(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is DropDownList)
                    ((DropDownList)item).Text = "";
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            HttpPostedFile ficheiro = fuImagem.PostedFile;
            string ficheironome = Path.GetFileName(ficheiro.FileName);
            string ficheiroextensao = Path.GetExtension(ficheironome);
            int ficheirotamanho = ficheiro.ContentLength;
            
            if(ficheiroextensao.ToLower() == ".jpg" || ficheiroextensao.ToLower() == ".gif" || ficheiroextensao.ToLower() == ".png" || ficheiroextensao.ToLower() == ".bmp")
            {
                Stream stream = ficheiro.InputStream;
                BinaryReader reader = new BinaryReader(stream);
                byte[] bytes = reader.ReadBytes((int)stream.Length);
                string cs = ConfigurationManager.ConnectionStrings["FRONT_END.Properties.Settings.Connection"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    SqlCommand Command = new SqlCommand();
                    Command.Connection = conn;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "ReceitaInserir";
                    Command.Parameters.AddWithValue("@Nome", txtNomeReceita.Text);
                    Command.Parameters.AddWithValue("@TipoCozinha", ddlTipoCozinha.SelectedValue);
                    Command.Parameters.AddWithValue("@TipoPrato", ddlTipoPrato.SelectedValue);
                    Command.Parameters.AddWithValue("@Doses", nuDoses.Value);
                    Command.Parameters.AddWithValue("@TempoExecucao", ddlTempo.SelectedValue);
                    Command.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                    Command.Parameters.AddWithValue("@NivelDificuldade", ddlNivel.SelectedValue);
                    Command.Parameters.AddWithValue("@Imagem", bytes);
                    conn.Open();
                    Command.ExecuteNonQuery();
                    conn.Close();
                }
                AbrirImagem();
            }

        }

        public void AbrirImagem()
        {
            string imagem = ConfigurationManager.ConnectionStrings["FRONT_END.Properties.Settings.Connection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(imagem))
            {
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "ReceitaSeleccionarUltima";
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                DataTable Table = new DataTable();
                Table.Load(Reader);
                dgvReceitas.DataSource = Table;
                dgvReceitas.DataBind();
                Connection.Close();
            }
        }

        protected void dgvReceitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_receita = dgvReceitas.SelectedRow.Cells[2].Text.ToString();
            PreencherIngrediente();
            btnEliminarIngrediente.Visible = true;
            btnGuardarIngrediente.Visible = true;
            btnModificarIngrediente.Visible = true;
        }

        void PreencherIngrediente()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "IngredienteSeleccionar";
            Command.Parameters.AddWithValue("@ID_Receita", dgvReceitas.SelectedRow.Cells[2].Text);
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            gvIngredientes.DataSource = Table;
            gvIngredientes.DataBind();
        }

        protected void btnGuardarIngrediente_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "InserirIngrediente";
            Command.Parameters.AddWithValue("@Nome", txtNomeIngrediente.Text);
            Command.Parameters.AddWithValue("@UnidadeMedida", ddlUnidade.SelectedValue);
            Command.Parameters.AddWithValue("@Quantidade", nuDoses.Value);
            Command.Parameters.AddWithValue("@ID_Receita", dgvReceitas.SelectedRow.Cells[2].Text);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            PreencherIngrediente();
            txtNomeIngrediente.Text = "";
        }

        protected void btnModificarIngrediente_Click(object sender, EventArgs e)
        {
            if (IDIngrediente != null)
            {
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "IngredienteModificar";
                Command.Parameters.AddWithValue("@Nome", txtNomeIngrediente.Text);
                Command.Parameters.AddWithValue("@UnidadeMedida", ddlUnidade.SelectedValue);
                Command.Parameters.AddWithValue("@Quantidade", nuQuantidade.Value);
                Command.Parameters.AddWithValue("@ID_Ingrediente", gvIngredientes.SelectedRow.Cells[1].Text);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
                PreencherIngrediente();
            }
            else
                Response.Write("<script>alert('Seleccine um Ingrediente');</script>");
        }

        protected void gvIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void gvIngredientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                IDIngrediente = e.Row.Cells[1].Text;
            }
        }

        protected void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {
            if (IDIngrediente != null)
            {
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "IngredienteRemover";
                Command.Parameters.AddWithValue("@ID_Ingrediente", gvIngredientes.SelectedRow.Cells[1].Text);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
                PreencherIngrediente();
            }
            else
                Response.Write("<script>alert('Seleccine um Ingrediente');</script>");
                
        }
    }
    


}