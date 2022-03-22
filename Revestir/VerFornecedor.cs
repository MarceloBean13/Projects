using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Revestir
{
    public partial class VerFornecedor : Form
    {
        //VARIABLES
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        DataTable fornTable;
        string fornID = null;

        public VerFornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage menu = new MainPage();
            menu.Show();
            this.Close();
        }

        private void VerFornecedor_Load(object sender, EventArgs e)
        {
            PreencherFornecedores();

        }

        private void PreencherFornecedores()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MostrarForn";
            SqlDataReader reader;
            fornTable = new DataTable();
            connection.Open();
            reader = command.ExecuteReader();
            fornTable.Load(reader);
            connection.Close();
            dgvForn.DataSource = fornTable;
            dgvForn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvForn.Columns[0].Width = 30;
            dgvForn.Columns[0].HeaderText = "Nº";
            dgvForn.Columns[1].HeaderText = "Primeiro Nome";
            dgvForn.Columns[2].HeaderText = "Último Nome";
            dgvForn.Columns[3].Width = 60;
            dgvForn.Columns[3].HeaderText = "Nº Guia";
            dgvForn.Columns[4].HeaderText = "Telefone";
            dgvForn.Columns[4].Width = 100;
            dgvForn.Columns[5].HeaderText = "E-Mail";
            dgvForn.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvForn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fornID = dgvForn.CurrentRow.Cells[0].Value.ToString();
            txtPNome.Text = dgvForn.CurrentRow.Cells[1].Value.ToString();
            txtUNome.Text = dgvForn.CurrentRow.Cells[2].Value.ToString();
            lbReferencia.Text = dgvForn.CurrentRow.Cells[0].Value.ToString() 
                + dgvForn.CurrentRow.Cells[1].Value.ToString().Substring(0, 1) 
                + dgvForn.CurrentRow.Cells[2].Value.ToString().Substring(0, 1);
            txtTele.Text = dgvForn.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvForn.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (fornID != null)
            {
                if (MessageBox.Show("Modificar este fornecedor?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "UpdateForn";
                    command.Parameters.AddWithValue("@PrimeiroNome", txtPNome.Text.Trim());
                    command.Parameters.AddWithValue("@UltimoNome", txtUNome.Text.Trim());
                    command.Parameters.AddWithValue("@Referencia",
                        txtPNome.Text.Substring(0,1) 
                        + txtUNome.Text.Substring(0,1));
                    command.Parameters.AddWithValue("@Telefone", txtTele.Text.Trim());
                    command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    command.Parameters.AddWithValue("@ID_Forn", fornID);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Modificado com Sucesso", "Sucesso");
                    ApagarDados();
                    PreencherFornecedores();
                }
            }
            else
                MessageBox.Show("Escolhe um Fornecedor primeiro", "Atenção");
        }

        private void ApagarDados()
        {
            txtPNome.Text = txtUNome.Text = lbReferencia.Text = txtTele.Text = txtEmail.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (fornID != null)
            {
                if (MessageBox.Show("Eliminar este fornecedor?","Atenção",MessageBoxButtons.YesNo) == DialogResult.Yes)
              { 
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DeleteForn";
                    command.Parameters.AddWithValue("@IDForn", fornID);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Eliminado com Sucesso!", "Sucesso");
                    ApagarDados();
                    PreencherFornecedores();
                }
            }
            else
                MessageBox.Show("Selecciona um fornecedor primeiro!", "Atenção");
        }
    }
}
