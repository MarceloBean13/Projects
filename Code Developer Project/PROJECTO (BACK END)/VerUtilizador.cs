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
using System.Configuration;

namespace PROJECTO__BACK_END_
{
    public partial class VerUtilizador : Form
    {
        string IDUser = null;
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.ReceitasConnectionString);
        DataTable TableUser;

        public VerUtilizador()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CriacaodeConta child = new CriacaodeConta();
            child.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainPage menu = new MainPage();
            menu.Show();
            this.Hide();
        }

        void SeleccionarUtilizadores()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "UtilizadorSeleccionar";
            SqlDataReader Reader;
            TableUser = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            TableUser.Load(Reader);
            Connection.Close();
            dgvUtilizadores.DataSource = TableUser;
            dgvUtilizadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtilizadores.Columns[0].HeaderText = "UserID";
            dgvUtilizadores.Columns[0].Width = 45;
            dgvUtilizadores.Columns[1].HeaderText = "Nome";
            dgvUtilizadores.Columns[1].Width = 80;
            dgvUtilizadores.Columns[2].HeaderText = "Ultimo Nome";
            dgvUtilizadores.Columns[2].Width = 80;
            dgvUtilizadores.Columns[3].Visible = false;
            dgvUtilizadores.Columns[4].HeaderText = "Username";
            dgvUtilizadores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUtilizadores.Columns[5].Visible = false;

        }

        private void VerUtilizador_Load(object sender, EventArgs e)
        {
            SeleccionarUtilizadores();
        }
        void LimparCampos(Control control)
        {
            foreach (Control item in control.Controls)
                if (item is TextBox)
                    item.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "UtilizadorModificar";
            Command.Parameters.AddWithValue("@Nome", txtNome.Text);
            Command.Parameters.AddWithValue("@Ultimo", txtUltimo.Text);
            Command.Parameters.AddWithValue("@Email", txtEmail.Text);
            Command.Parameters.AddWithValue("@Username", txtUsername.Text);
            Command.Parameters.AddWithValue("@Password", txtPassword.Text);
            Command.Parameters.AddWithValue("@ID_User", dgvUtilizadores.CurrentRow.Cells[0].Value);
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            SeleccionarUtilizadores();
            LimparCampos(this);

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (IDUser != null)
            {
                if (MessageBox.Show("Eliminar Utilizador?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand Command = new SqlCommand();
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "UtilizadorRemover";
                    Command.Parameters.AddWithValue("@ID_User", dgvUtilizadores.CurrentRow.Cells[0].Value);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                    MessageBox.Show("Removido com Sucesso");

                }
            }
            else
                MessageBox.Show("Escolha um Utilizador", "Atenção");
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparCampos(this);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            DataView View = new DataView(TableUser);
            View.RowFilter = string.Format("Nome LIKE '%{0}%'", txtSearch.Text);
            dgvUtilizadores.DataSource = View;
        }

        private void dgvUtilizadores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IDUser = dgvUtilizadores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvUtilizadores.CurrentRow.Cells[1].Value.ToString();
            txtUltimo.Text = dgvUtilizadores.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvUtilizadores.CurrentRow.Cells[3].Value.ToString();
            txtUsername.Text = dgvUtilizadores.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
