using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Revestir
{
    public partial class VerArtigos : Form
    {
        //Variables
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        DataTable fornTable = new DataTable();
        DataTable artigosTable;
        string IDFornecedor = null;
        string IDArtigo = null;

        public VerArtigos()
        {
            InitializeComponent();
        }

        private void cbVendido_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVendido.Checked)
                txtVenda.Enabled = true;
            else
                txtVenda.Enabled = false;
        }

        private void cbPago_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPago.Checked)
                txtPago.Enabled = true;
            else
                txtPago.Enabled = false;
        }

        private void VerArtigos_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MostrarForn";
            SqlDataReader reader;
            connection.Open();
            reader = command.ExecuteReader();
            fornTable.Load(reader);
            connection.Close();
            dgvForn.DataSource = fornTable;
            dgvForn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvForn.Columns[0].Width = 30;
            dgvForn.Columns[0].HeaderText = "Nº";
            dgvForn.Columns[1].Width = 150;
            dgvForn.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvForn.Columns[3].Visible = false;
            dgvForn.Columns[4].Visible = false;
        }

        private void dgvForn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDFornecedor = dgvForn.CurrentRow.Cells[0].Value.ToString();
            PreencherArtigos();
        }

        private void PreencherArtigos()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MostrarArtigos";
            SqlDataReader reader;
            artigosTable = new DataTable();
            command.Parameters.AddWithValue("@ID_Forn", IDFornecedor);
            connection.Open();
            reader = command.ExecuteReader();
            artigosTable.Load(reader);
            connection.Close();
            dgvArtigos.DataSource = artigosTable;
            dgvArtigos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtigos.Columns[0].HeaderText = "Nº";
            dgvArtigos.Columns[0].Width = 30;
            dgvArtigos.Columns[1].HeaderText = "Descrição Peça";
            dgvArtigos.Columns[1].Width = 400;
            dgvArtigos.Columns[2].Width = 60;
            dgvArtigos.Columns[3].HeaderText = "Data de Venda";
            dgvArtigos.Columns[3].Width = 150;
            dgvArtigos.Columns[4].HeaderText = "Data de Pagamento";
            dgvArtigos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainPage menu = new MainPage();
            menu.Show();
            this.Close();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (IDFornecedor != null)
            {
                if (MessageBox.Show($"Criar artigo em {dgvForn.CurrentRow.Cells[1].Value}?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "AddArtigo";
                    command.Parameters.AddWithValue("@ID_Forn", IDFornecedor);
                    command.Parameters.AddWithValue("@Descricao", txtDescri.Text.Trim());
                    command.Parameters.AddWithValue("@Preco", nudPreço.Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Artigo criado com Sucesso!", "Sucesso");
                    ApagarDados();
                }
            }
        }

        private void ApagarDados()
        {
            txtDescri.Text = "";
            nudPreço.Value = 1;
            if (cbVendido.Checked)
                cbVendido.Checked = false;
            if (cbPago.Checked)
                cbPago.Checked = false;
        }

        private void dgvArtigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            lbNPeca.Text = dgvArtigos.CurrentRow.Cells[0].Value.ToString();
            txtDescri.Text = dgvArtigos.CurrentRow.Cells[1].Value.ToString();
            nudPreço.Value = Convert.ToDecimal(dgvArtigos.CurrentRow.Cells[2].Value);
            if (!String.IsNullOrEmpty(dgvArtigos.CurrentRow.Cells[3].Value.ToString()))
            {
                cbVendido.Checked = true;
                txtVenda.Text = dgvArtigos.CurrentRow.Cells[3].Value.ToString();
            }
            else
            { 
                cbVendido.Checked = false;
                txtVenda.Text = "";
            }
            if (!String.IsNullOrEmpty(dgvArtigos.CurrentRow.Cells[4].Value.ToString()))
            {
                cbPago.Checked = true;
                txtPago.Text = dgvArtigos.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                cbPago.Checked = false;
                txtPago.Text = "";
            }

        }
    }
}
