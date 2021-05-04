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
    public partial class UnidadedeMedida : Form
    {
        string ID_Unidade = null;
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.ReceitasConnectionString);

        void PreencherUnidade()
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "UnidadeSeleccionarTudo";
            SqlDataReader Reader;
            DataTable Table = new DataTable();
            Connection.Open();
            Reader = Command.ExecuteReader();
            Table.Load(Reader);
            Connection.Close();
            dgvUnidade.DataSource= Table;
            dgvUnidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnidade.Columns[0].Visible = false;
            dgvUnidade.Columns[1].HeaderText = "Unidade de Medida";
            dgvUnidade.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUnidade.Columns[2].HeaderText = "Sigla";
            dgvUnidade.Columns[2].Width = 80;

        }
        public UnidadedeMedida()
        {
            InitializeComponent();
        }

        private void UnidadedeMedida_Load(object sender, EventArgs e)
        {
            PreencherUnidade();
            ApagarDados(this);
        }

        void ApagarDados(Control control)
        {
            foreach(Control item in control.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "UnidadeMedidaInserir";
            Command.Parameters.AddWithValue("@Nome", txtUnidade.Text);
            Command.Parameters.AddWithValue("@Sigla", txtSigla.Text);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            PreencherUnidade();
            ApagarDados(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ID_Unidade == null)
            {
                MessageBox.Show("Escolha uma Unidade para Modificar", "Atenção");
                
            }
            else
            {
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "UnidadeModificar";
                Command.Parameters.AddWithValue("@Nome", txtUnidade.Text);
                Command.Parameters.AddWithValue("@Sigla", txtSigla.Text);
                Command.Parameters.AddWithValue("@ID_Unidade", ID_Unidade);
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
                PreencherUnidade();
                ApagarDados(this);
            }
        }

        private void dgvUnidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Unidade = dgvUnidade.CurrentRow.Cells[0].Value.ToString();
            txtUnidade.Text = dgvUnidade.CurrentRow.Cells[1].Value.ToString();
            txtSigla.Text = dgvUnidade.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarDados(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Unidade != null)
            {
                if (MessageBox.Show("Quer mesmo eliminar esta Unidade de Medida?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand Command = new SqlCommand();
                        Command.Connection = Connection;
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.CommandText = "UnidadeRemover";
                        Command.Parameters.AddWithValue("@ID_Unidade", ID_Unidade);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        Connection.Close();
                        PreencherUnidade();
                        ApagarDados(this);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
                MessageBox.Show("Escolha uma Unidade de Medida para Eliminar", "Atenção");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainPage parent = new MainPage();
            parent.Show();
            this.Hide();
        }
    }
}
