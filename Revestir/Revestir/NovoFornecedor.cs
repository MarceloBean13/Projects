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
    public partial class NovoFornecedor : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.Connection);

        public NovoFornecedor()
        {
            InitializeComponent();
        }
        
        void ApagarDados(Control control)
        {
            foreach(Control item in control.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
                lbNovaReferencia.Text = "";
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                MessageBox.Show("O Campo Nome tem de ser preenchido", "Atenção!");

            else if (nudNumeroReferencia.Value == 0)
                MessageBox.Show("O Fornecedor não tem Número de Guia", "Atenção!");

            else if (string.IsNullOrWhiteSpace(lbNovaReferencia.Text))
                MessageBox.Show("Crie uma Referência para o Fornecedor", "Atenção!");
         
            //else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            //    MessageBox.Show("O Campo Email tem de ser preenchido", "Atenção!");

            else if (string.IsNullOrWhiteSpace(txtTelemovel.Text))
                MessageBox.Show("O Campo Telemóvel tem de ser preenchido", "Atenção!");

            else if (string.IsNullOrWhiteSpace(txtLocal.Text))
                MessageBox.Show("O Campo Local tem de ser preenchido", "Atenção!");

            else
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "InserirFornecedor";
                comm.Parameters.AddWithValue("@Nome", txtNome.Text);
                comm.Parameters.AddWithValue("@Sigla", lbNovaReferencia.Text);
                comm.Parameters.AddWithValue("@Nguia", nudNumeroReferencia.Value);
                comm.Parameters.AddWithValue("@Local", txtLocal.Text);
                comm.Parameters.AddWithValue("@Email", txtEmail.Text);
                comm.Parameters.AddWithValue("@Telefone", txtTelemovel.Text);
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Fornecedor criado com Sucesso!! =)");
                ApagarDados(this);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PagPrincipal parent = new PagPrincipal();
            parent.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                MessageBox.Show("Coloque o Nome do Fornecedor primeiro", "Atenção!!");

            else
            {
                string nome;
                nome = txtNome.Text;
                lbNovaReferencia.Text = nome.Substring(0, 1) + nome.Substring(nome.LastIndexOf(" "), 2).Trim();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarDados(this);
        }
    }
}
