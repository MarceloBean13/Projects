using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECTO__BACK_END_
{
    public partial class TipoCozinha : Form
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.ReceitasConnectionString);
        
        public TipoCozinha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TipoCozinha_Load(object sender, EventArgs e)
        {
            SelectCozinha();
        }
        void ApagarResultados()
        {
            txtCozinha.Text = "";

        }

        void SelectCozinha()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TipoCozinhaSeleccionar";
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                Table.Load(Reader);
                gridCozinha.DataSource = Table;
                gridCozinha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridCozinha.Columns[0].Visible = false;
                gridCozinha.Columns[1].HeaderText = "Cozinha";
                gridCozinha.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro na base de dados");
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();

            }
        }

        private void gridCozinha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCozinha.Text = gridCozinha.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TipoCozinhaInserir";
            Command.Parameters.AddWithValue("@Cozinha", txtCozinha.Text);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            SelectCozinha();
            ApagarResultados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TipoCozinhaModificar";
            Command.Parameters.AddWithValue("@Cozinha", txtCozinha.Text);
            Command.Parameters.AddWithValue("@ID", gridCozinha.CurrentRow.Cells[0].Value);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            SelectCozinha();
            ApagarResultados();

        }

        private void gridCozinha_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TipoCozinhaRemover";
            Command.Parameters.AddWithValue("@ID", gridCozinha.CurrentRow.Cells[0].Value);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            SelectCozinha();
            ApagarResultados();
        }

        private void gridCozinha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCozinha.Text = gridCozinha.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainPage menu = new MainPage();
            menu.Show();
            this.Hide();
        }
    }
}
  