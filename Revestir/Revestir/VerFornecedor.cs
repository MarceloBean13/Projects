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

namespace Revestir
{
    public partial class VerFornecedor : Form
    {
        DataTable tableFornecedor;
        string idFornecedor = null;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.Connection);

        void ApagarDados(Control controls)
        {
            foreach (Control item in controls.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
                if (item.HasChildren)
                    ApagarDados(item);
                dgvProdutos.Visible = false;
                if (item is DataGridView)
                    ((DataGridView)item).ClearSelection();
            }
            this.Location = new Point(430, 50);
            this.Width = 750;
        }
            
        void PreencherFornecedores()
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "PreencherFornecedor";
            SqlDataReader reader;
            tableFornecedor = new DataTable();
            conn.Open();
            reader = comm.ExecuteReader();
            tableFornecedor.Load(reader);
            conn.Close();
            dgvFornecedor.DataSource = tableFornecedor;
            dgvFornecedor.Columns[0].Visible = false;
            dgvFornecedor.Columns[1].HeaderText = "Nome Fornecedor";
            dgvFornecedor.Columns[1].Width = 210;
            dgvFornecedor.Columns[2].HeaderText = "Guia";
            dgvFornecedor.Columns[2].Width = 80;
            dgvFornecedor.Columns[3].HeaderText = "Referência";
            dgvFornecedor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFornecedor.Columns[4].Visible = false;
            dgvFornecedor.Columns[5].Visible = false;
            dgvFornecedor.Columns[6].Visible = false;
        }
        public VerFornecedor()
        {
            InitializeComponent();
        }

        private void VerFornecedor_Load(object sender, EventArgs e)
        {
            this.Location = new Point(430, 50);
            this.Width = 750;
            PreencherFornecedores();
            ApagarDados(this);
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Location = new Point(50, 50);
            this.Width = 1445;
            idFornecedor = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "SeleccionarProdutoFornecedor";
            comm.Parameters.AddWithValue("@ID_Fornecedor", idFornecedor);
            SqlDataReader reader;
            DataTable table = new DataTable();
            conn.Open();
            reader = comm.ExecuteReader();
            table.Load(reader);
            conn.Close();
            dgvProdutos.DataSource = table;
            dgvProdutos.Columns[0].Width = 80;
            dgvProdutos.Columns[1].HeaderText = "Produtos";
            dgvProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProdutos.Columns[2].Visible = false;
            dgvProdutos.Columns[3].Width = 80;
            dgvProdutos.Columns[4].HeaderText = "Data Venda";
            dgvProdutos.Columns[5].HeaderText = "Preço Fornecedor(€)";
            dgvProdutos.Columns[5].Width = 100;
            dgvProdutos.Columns[5].DefaultCellStyle.Format = "N2";
            dgvProdutos.Columns[6].HeaderText = "Preço Final(€)";
            dgvProdutos.Columns[6].Width = 100;
            dgvProdutos.Columns[6].DefaultCellStyle.Format = "N2";

            txtNomeFornecedor.Text = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
            nudGuia.Value = Convert.ToDecimal(dgvFornecedor.CurrentRow.Cells[2].Value);
            lbReferencia.Text = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtTelemovel.Text = dgvFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgvFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtLocal.Text = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
            dgvProdutos.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PagPrincipal parent = new PagPrincipal();
            parent.Show();
            this.Hide();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarDados(this);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            DataView view = new DataView(tableFornecedor);
            view.RowFilter = string.Format("Nome LIKE '%{0}%'", txtPesquisa.Text);
            dgvFornecedor.DataSource = view;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idFornecedor == null)
                MessageBox.Show("Nenhum Fornecedor está Seleccionado!", "Atenção");

            else if (MessageBox.Show("Eliminar este Fornecedor?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "EliminarFornecedor";
                comm.Parameters.AddWithValue("@ID_Fornecedor", idFornecedor);
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                PreencherFornecedores();
                ApagarDados(this);
                MessageBox.Show("Eliminado com Sucesso");
            }
            else
                MessageBox.Show("Escolha um Fornecedor para Eliminar", "Atenção");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idFornecedor == null)
                MessageBox.Show("Nenhum Fornecedor está Seleccionado!", "Atenção");

            else if (MessageBox.Show("Modificar este Fornecedor?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "ModificarFornecedor";
                comm.Parameters.AddWithValue("@ID_Fornecedor", idFornecedor);
                comm.Parameters.AddWithValue("@Nome", txtNomeFornecedor.Text);
                comm.Parameters.AddWithValue("@NGuia", nudGuia.Value);
                comm.Parameters.AddWithValue("@Telemovel", txtTelemovel.Text);
                comm.Parameters.AddWithValue("@Email", txtEmail.Text);
                comm.Parameters.AddWithValue("@Local", txtLocal.Text);
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                PreencherFornecedores();
                ApagarDados(this);
                MessageBox.Show("Modificado com sucesso!");
            }
            else
                MessageBox.Show("Seleccionar um Fornecedor para Modificar", "Atenção");
        }
    }
}
