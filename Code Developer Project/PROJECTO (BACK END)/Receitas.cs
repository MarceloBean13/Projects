using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PROJECTO__BACK_END_
{
    public partial class Receitas : Form
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.ReceitasConnectionString);
        
        string IDReceita = null, imglock = "", IDIngrediente = null;

        DataTable TableReceita;

        void PreencherReceitas()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "ReceitaSeleccionar";
            SqlDataReader Reader;
            TableReceita = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            TableReceita.Load(Reader);
            Connection.Close();
            dgvReceitas.DataSource = TableReceita;
            dgvReceitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceitas.Columns[0].Visible = false;
            dgvReceitas.Columns[1].HeaderText = "Receita";
            dgvReceitas.Columns[1].Width = 250;
            dgvReceitas.Columns[2].Visible = false;
            dgvReceitas.Columns[3].Visible = false;
            dgvReceitas.Columns[4].Visible = false;
            dgvReceitas.Columns[5].Visible = false;
            dgvReceitas.Columns[6].Visible = false;
            dgvReceitas.Columns[7].Visible = false;
            dgvReceitas.Columns[8].HeaderText = "Aprovado";
            dgvReceitas.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReceitas.Columns[9].Visible = false;
        }
        public Receitas()
        {
            InitializeComponent();
        }


        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainPage menu = new MainPage();
            menu.Show();
            this.Hide();
        }

        private void Receitas_Load(object sender, EventArgs e)
        {           
            MessageBox.Show("Insira primeiro a Receita e depois os Ingredientes!", "Atenção");
            this.Height = 730;
            PreencherReceitas();
            SeleccionarTipoCozinha();
            SeleccionarTipoPrato();
            SeleccionarUnidade();
            SeleccionarNivel();
            SeleccionarTempo();
            ApagarDados(this);
        }

        private void btnInserirIngrediente_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNomeIngrediente.Text))
            {
                MessageBox.Show("Nome do Ingrediente é obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(nudQuantidade.Value.ToString()))
            {
                MessageBox.Show("Quantidade é obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(cbUnidade.Text))
            {
                MessageBox.Show("Unidade de Medida é obrigatório", "Erro");
            }
            else
            {
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "InserirIngrediente";
                Command.Parameters.AddWithValue("@Nome", txtNomeIngrediente.Text);
                Command.Parameters.AddWithValue("@UnidadeMedida", cbUnidade.SelectedValue);
                Command.Parameters.AddWithValue("@Quantidade", nudQuantidade.Value);
                Command.Parameters.AddWithValue("@ID_Receita", dgvReceitas.CurrentRow.Cells[0].Value);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
                PreencherIngrediente();
                txtNomeIngrediente.Text = "";
                cbUnidade.Text = "";

                nudQuantidade.Value = 0;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var img = (Byte[])(dgvReceitas.CurrentRow.Cells[9].Value);
            var via = new MemoryStream(img);
            this.Height = 800;
            IDReceita = dgvReceitas.CurrentRow.Cells[0].Value.ToString();
            txtNomeReceita.Text = dgvReceitas.CurrentRow.Cells[1].Value.ToString();
            cbNivel.Text = dgvReceitas.CurrentRow.Cells[4].Value.ToString();
            cbTipoCozinha.Text = dgvReceitas.CurrentRow.Cells[2].Value.ToString();
            cbTipoPrato.Text = dgvReceitas.CurrentRow.Cells[3].Value.ToString();
            nudDoses.Value = Convert.ToDecimal(dgvReceitas.CurrentRow.Cells[5].Value);
            cbTempo.Text = dgvReceitas.CurrentRow.Cells[6].Value.ToString();
            txtDescricao.Text = dgvReceitas.CurrentRow.Cells[7].Value.ToString();
            cbAprovar.Text = dgvReceitas.CurrentRow.Cells[8].Value.ToString();
            pbImagem.Image = Image.FromStream(via);

            PreencherIngrediente();
            this.Location = new Point(230, 30);
        }

        void ApagarDados(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";
                if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
                if (item is DataGridView)
                    ((DataGridView)item).ClearSelection();
                pbImagem.Image = Properties.Resources.Imagem;
                if (item.HasChildren)
                    ApagarDados(item);
                
                dgvIngrediente.DataSource = "";
            }
        }

        void PreencherIngrediente()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "IngredienteSeleccionar";
            Command.Parameters.AddWithValue("@ID_Receita", IDReceita);
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            dgvIngrediente.DataSource = Table;
            dgvIngrediente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngrediente.Columns[0].Visible = false;
            dgvIngrediente.Columns[1].HeaderText = "Ingrediente";
            dgvIngrediente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            dgvIngrediente.Columns[2].HeaderText = "Quant.";
            dgvIngrediente.Columns[2].Width = 45;
            dgvIngrediente.Columns[3].HeaderText = "Uni. de Medida";
            dgvIngrediente.Columns[3].Width = 80;
            
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
            cbTipoCozinha.DataSource = Table;
            cbTipoCozinha.DisplayMember = "Cozinha";
            cbTipoCozinha.ValueMember = "ID";
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
            cbTipoPrato.DataSource = Table;
            cbTipoPrato.DisplayMember = "Prato";
            cbTipoPrato.ValueMember = "ID";
        }

        void SeleccionarUnidade()
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
            cbUnidade.DataSource = Table;
            cbUnidade.DisplayMember = "Sigla";
            cbUnidade.ValueMember = "ID";
        }

        void SeleccionarNivel()
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
            cbNivel.DataSource = Table;
            cbNivel.DisplayMember = "Nome";
            cbNivel.ValueMember = "ID";
        }

        void SeleccionarTempo()
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
            cbTempo.DataSource = Table;
            cbTempo.DisplayMember = "Tempo";
            cbTempo.ValueMember = "ID";
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Height = 730;
            ApagarDados(this);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeReceita.Text))
            {
                txtNomeReceita.Focus();
                MessageBox.Show("Nome da Receita é obrigatório", "Erro");
            }
            else if(string.IsNullOrWhiteSpace(cbNivel.Text))
            {
                cbNivel.Focus();
                MessageBox.Show("Nível de Dificuldade é Obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(cbTipoCozinha.Text))
            {
                cbTipoCozinha.Focus();
                MessageBox.Show("Tipo de Cozinha é Obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(cbTipoPrato.Text))
            {
                cbTipoPrato.Focus();
                MessageBox.Show("Tipo de Prato é Obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(nudDoses.Text))
            {
                nudDoses.Focus();
                MessageBox.Show("Número de Doses são Obrigatórias", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(cbTempo.Text))
            {
                cbTempo.Focus();
                MessageBox.Show("Tempo de Execução é Obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                txtDescricao.Focus();
                MessageBox.Show("Descrição é Obrigatória", "Erro");
            }
            else if(string.IsNullOrWhiteSpace(imglock))
            {
                MessageBox.Show("É necessário colocar uma imagem");
            }
            //else if(string.IsNullOrWhiteSpace(cbAprovar.Text))
            //{
            //    cbAprovar.Focus();
            //    MessageBox.Show("Aprovado é Obrigatório", "Erro");
            //}
            else {

                byte[] img = null;
                FileStream fs = new FileStream(imglock, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "ReceitaInserir";
                Command.Parameters.AddWithValue("@Nome", txtNomeReceita.Text);
                Command.Parameters.AddWithValue("@TipoCozinha", cbTipoCozinha.SelectedValue);
                Command.Parameters.AddWithValue("@TipoPrato", cbTipoPrato.SelectedValue);
                Command.Parameters.AddWithValue("@Doses", nudDoses.Value);
                Command.Parameters.AddWithValue("@TempoExecucao", cbTempo.SelectedValue);
                Command.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                Command.Parameters.AddWithValue("@NivelDificuldade", cbNivel.SelectedValue);
                Command.Parameters.AddWithValue("@Imagem", img);
                //Command.Parameters.AddWithValue("@Aprovado", cbAprovar.SelectedValue);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Receita Criada com Sucesso!", "Sucesso");
                PreencherReceitas();
                ApagarDados(this);
            }
                    
        }
        private void btnModificarReceita_Click(object sender, EventArgs e)
        {
            if (dgvReceitas.CurrentRow == null)
            {
                MessageBox.Show("Escolha uma receita para Modificar", "Receita");
            }
            else if (string.IsNullOrWhiteSpace(txtNomeReceita.Text))
            {
                txtNomeReceita.Focus();
                MessageBox.Show("Nome da Receita é obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(cbNivel.Text))
            {
                cbNivel.Focus();
                MessageBox.Show("Nível de Dificuldade é Obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(cbTipoCozinha.Text))
            {
                cbTipoCozinha.Focus();
                MessageBox.Show("Tipo de Cozinha é Obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(cbTipoPrato.Text))
            {
                cbTipoPrato.Focus();
                MessageBox.Show("Tipo de Prato é Obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(nudDoses.Text))
            {
                nudDoses.Focus();
                MessageBox.Show("Número de Doses são Obrigatórias", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(cbTempo.Text))
            {
                cbTempo.Focus();
                MessageBox.Show("Tempo de Execução é Obrigatório", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                txtDescricao.Focus();
                MessageBox.Show("Descrição é Obrigatória", "Erro");
            }
            else if (string.IsNullOrWhiteSpace(imglock))
            {
                MessageBox.Show("É necessário colocar uma imagem");
            }
            else
            {

                byte[] img = null;
                FileStream fs = new FileStream(imglock, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "ReceitaModificar";
                Command.Parameters.AddWithValue("@ID_Receita", IDReceita);
                Command.Parameters.AddWithValue("@Nome", txtNomeReceita.Text);
                Command.Parameters.AddWithValue("@TipoCozinha", cbTipoCozinha.SelectedValue);
                Command.Parameters.AddWithValue("@TipoPrato", cbTipoPrato.SelectedValue);
                Command.Parameters.AddWithValue("@Doses", nudDoses.Value);
                Command.Parameters.AddWithValue("@TempoExecucao", cbTempo.SelectedValue);
                Command.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                Command.Parameters.AddWithValue("@NivelDificuldade", cbNivel.SelectedValue);
                Command.Parameters.AddWithValue("@Imagem", img);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Receita Modificada com Sucesso", "Sucesso");
                PreencherReceitas();
                ApagarDados(this);
            }
        }

        private void btnRemoverReceita_Click(object sender, EventArgs e)
        {
            if (IDReceita != null)
            {
                if (dgvIngrediente.Rows.Count != 0)
                    MessageBox.Show("Elimine os Ingredientes Primeiro", "Atenção");

                else if (MessageBox.Show("Eliminar esta Receita", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand Command = new SqlCommand();
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "ReceitaRemover";
                    Command.Parameters.AddWithValue("ID_Receita", IDReceita);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                    PreencherReceitas();
                    ApagarDados(this);
                }

            }
            else
                MessageBox.Show("Escolha uma Receita para Eliminar", "Receita");
        }

        private void btnRemoverIngrediente_Click(object sender, EventArgs e)
        {
            if (IDIngrediente != null )
            {
                if (MessageBox.Show("Eliminar esta Ingrediente", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand Command = new SqlCommand();
                    Command.Connection = Connection;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = "IngredienteRemover";
                    Command.Parameters.AddWithValue("@ID_Ingrediente", dgvIngrediente.CurrentRow.Cells[0].Value);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                    PreencherIngrediente();

                }
            }
            else
                MessageBox.Show("Escolha um Ingrediente para Eliminar", "Receita");
         
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView View = new DataView(TableReceita);
            View.RowFilter = string.Format("Nome LIKE '%{0}%'", txtSearch.Text);
            dgvReceitas.DataSource = View;

        }

        private void dgvIngrediente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDIngrediente = dgvIngrediente.CurrentRow.Cells[0].Value.ToString();

        }

        private void dgvReceitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarIngrediente_Click(object sender, EventArgs e)
        {
            if (IDIngrediente != null)
            {
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "IngredienteModificar";
                Command.Parameters.AddWithValue("@Nome", txtNomeIngrediente.Text);
                Command.Parameters.AddWithValue("@UnidadeMedida", cbUnidade.SelectedValue);
                Command.Parameters.AddWithValue("@Quantidade", nudQuantidade.Value);
                Command.Parameters.AddWithValue("@ID_Ingrediente", dgvIngrediente.CurrentRow.Cells[0].Value);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
                PreencherIngrediente();
            }
            else
                MessageBox.Show("Escolha um Ingrediente", "Erro");
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|GIF FIles (*.gif)|*.gif|All Files (*.*)|*.*";
            ofd.Title = "Selecionar a Imagem";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imglock = ofd.FileName.ToString();
                 pbImagem.ImageLocation = imglock;
            }
        }
    }
}
