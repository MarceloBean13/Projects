using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Revestir
{
    public partial class Produtos : Form
    {
        string imglock = "";
        DataTable tableproduto;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.Connection);
        string idProduto;



        void PreencherCategoria()
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "PreencherCategoria";
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            conn.Close();
            cbCategoria.DataSource = table;
            cbCategoria.DisplayMember = "Categoria";
            cbCategoria.ValueMember = "ID";
        }

        void PreencherDevolvido()
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "PreencherDevolvido";
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            conn.Close();
            cbDevolvido.DataSource = table;
            cbDevolvido.DisplayMember = "Devolvido";
            cbDevolvido.ValueMember = "ID";
        }

        void PreencherProduto()
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "SeleccionarProduto";
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            tableproduto = new DataTable();
            tableproduto.Load(reader);
            conn.Close();
            dgvProdutos.DataSource = tableproduto;
            dgvProdutos.Columns[0].Visible = false;
            dgvProdutos.Columns[1].HeaderText = "Produto";
            dgvProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProdutos.Columns[2].Visible = false;
            dgvProdutos.Columns[3].Visible = false;
            dgvProdutos.Columns[4].Visible = false;
            dgvProdutos.Columns[5].Visible = false;
            dgvProdutos.Columns[6].HeaderText = "Referência";
            dgvProdutos.Columns[6].Width = 80;
            dgvProdutos.Columns[7].HeaderText = "Fornecedor";
            dgvProdutos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProdutos.Columns[8].Visible = false;
            dgvProdutos.Columns[9].Visible = false;
            dgvProdutos.Columns[10].Visible = false;
        }

        void PreencherFornecedor()
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "PreencherFornecedor";
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            conn.Close();
            cbFornecedor.DataSource = table;
            cbFornecedor.DisplayMember = "Nome";
            cbFornecedor.ValueMember = "ID";
        }

        void ApagarDados(Control controls)
        {
            foreach (Control item in controls.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";
                if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
                if (item is DataGridView)
                    ((DataGridView)item).ClearSelection();
                pcImagem.Image = Properties.Resources.Inserir;
                if (item.HasChildren)
                    ApagarDados(item);

            }
        }
        public Produtos()
        {
            InitializeComponent();
        }

        private void nudReferência_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            pcImagem.Image = Properties.Resources.Inserir;
            PreencherCategoria();
            PreencherDevolvido();
            PreencherProduto();
            PreencherFornecedor();
            ApagarDados(this);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                MessageBox.Show("Nome do produto é necessário!", "Atenção");
                txtNomeProduto.Focus();
            }

            else if (string.IsNullOrWhiteSpace(cbFornecedor.Text))
            {
                MessageBox.Show("É necessário introduzir um Fornecedor", "Atenção");
                cbFornecedor.Focus();
            }

            else if (string.IsNullOrWhiteSpace(nudReferência.Text))
            {
                MessageBox.Show("A referência do produto é necessária", "Atenção");
                nudReferência.Focus();
            }

            else if (string.IsNullOrWhiteSpace(nudPreçoFornecedor.Text))
            {
                MessageBox.Show("Preço do Fornecedor é necessário!", "Atenção");
                nudPreçoFornecedor.Focus();
            }

            else if (string.IsNullOrWhiteSpace(nudPreçoFinal.Text))
            {
                MessageBox.Show("Preço Final é necessário!", "Atenção");
                nudPreçoFinal.Focus();
            }

            else if (string.IsNullOrWhiteSpace(cbCategoria.Text))
            {
                MessageBox.Show("Categoria é necessária", "Atenção");
                cbCategoria.Focus();
            }

            else if (string.IsNullOrWhiteSpace(imglock))
            {
                MessageBox.Show("Por favor introduza uma imagem!", "Atenção");
                btnAbrirImagem.PerformClick();
            }
            else
            {
                byte[] img = null;
                FileStream fs = new FileStream(imglock, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "InserirProduto";
                comm.Parameters.AddWithValue("@NomeProduto", txtNomeProduto.Text);
                comm.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                comm.Parameters.AddWithValue("@Tipo", cbCategoria.SelectedValue);
                comm.Parameters.AddWithValue("@Tamanho", txtTamanho.Text);
                comm.Parameters.AddWithValue("@Cor", txtCor.Text);
                comm.Parameters.AddWithValue("@Devolvido", cbDevolvido.SelectedValue);
                comm.Parameters.AddWithValue("@Fornecedor", cbFornecedor.SelectedValue);
                comm.Parameters.AddWithValue("@Referencia", nudReferência.Value);
                comm.Parameters.AddWithValue("@PrecoFornecedor", nudPreçoFornecedor.Value);
                comm.Parameters.AddWithValue("@PrecoFinal", nudPreçoFinal.Value);
                comm.Parameters.AddWithValue("@Imagem", img);
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                PreencherProduto();
            }

        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {
        }


        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProduto = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            txtNomeProduto.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
            txtTamanho.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
            txtCor.Text = dgvProdutos.CurrentRow.Cells[4].Value.ToString();
            cbFornecedor.Text = dgvProdutos.CurrentRow.Cells[8].Value.ToString();
            cbDevolvido.Text = dgvProdutos.CurrentRow.Cells[9].Value.ToString();
            nudReferência.Value = Convert.ToDecimal(dgvProdutos.CurrentRow.Cells[6].Value);
            nudPreçoFornecedor.Value = Convert.ToDecimal(dgvProdutos.CurrentRow.Cells[10].Value);
            nudPreçoFinal.Value = Convert.ToDecimal(dgvProdutos.CurrentRow.Cells[10].Value);
            //if (dgvProdutos.CurrentRow.Cells[6].Value != null)
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            DataView view = new DataView(tableproduto);
            view.RowFilter = string.Format("Nome LIKE '%{0}%'", txtProcurar.Text);
            dgvProdutos.DataSource = view;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarDados(this);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            PagPrincipal parent = new PagPrincipal();
            parent.Show();
            this.Hide();
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*";
            ofd.Title = "Seleccionar uma Imagem";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imglock = ofd.FileName.ToString();
                pcImagem.ImageLocation = imglock;
            }
        }

        private void btnInstrucoes_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarProduto";
            cmd.Parameters.AddWithValue("@NomeProduto", txtNomeProduto.Text);
            cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@Tipo", cbCategoria.SelectedValue);
            cmd.Parameters.AddWithValue("@Tamanho", txtTamanho.Text);
            cmd.Parameters.AddWithValue("@Cor", txtCor.Text);
            cmd.Parameters.AddWithValue("@Devolvido", cbDevolvido.SelectedValue);
            cmd.Parameters.AddWithValue("@Fornecedor", cbFornecedor.SelectedValue);
            cmd.Parameters.AddWithValue("@Referencia", nudReferência.Value);
            cmd.Parameters.AddWithValue("@PrecoFornecedor", nudPreçoFornecedor.Value);
            cmd.Parameters.AddWithValue("@PrecoFinal", nudPreçoFinal.Value);
            cmd.Parameters.AddWithValue("@Imagem", pcImagem.Image);
            cmd.Parameters.AddWithValue("@ID_Produto", idProduto);
        }
    }
}
