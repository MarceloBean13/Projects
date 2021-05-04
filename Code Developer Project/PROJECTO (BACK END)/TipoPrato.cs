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
    public partial class TipoPrato : Form
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.ReceitasConnectionString);
        
        public TipoPrato()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainPage menu = new MainPage();
            menu.Show();
            this.Hide();
        }

        void Limpar()
        {
            txtPrato.Text = "";

        }
        void SelectTipoPrato()
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
            dgvTipoPrato.DataSource = Table;
            dgvTipoPrato.Columns[0].Visible = false;
            dgvTipoPrato.Columns[1].HeaderText = "Prato";
            dgvTipoPrato.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTipoPrato.Columns[1].Width = 75;
           
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TipoPratoInserir";
            Command.Parameters.AddWithValue("@Prato", txtPrato.Text);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            SelectTipoPrato();
            Limpar();
        }

        private void TipoPrato_Load(object sender, EventArgs e)
        {
            SelectTipoPrato();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TipoPratoRemover";
            Command.Parameters.AddWithValue("@ID_Prato", dgvTipoPrato.CurrentRow.Cells[0].Value);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            SelectTipoPrato();
            Limpar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "TipoPratoModificar";
            Command.Parameters.AddWithValue("@Prato", txtPrato.Text);
            Command.Parameters.AddWithValue("@ID_Prato", dgvTipoPrato.CurrentRow.Cells[0].Value);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            SelectTipoPrato();
            Limpar();
        }

        private void dgvTipoPrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrato.Text = dgvTipoPrato.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
