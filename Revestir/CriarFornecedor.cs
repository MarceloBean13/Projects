using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Revestir
{
    public partial class CriarFornecedor : Form
    {
        //Variables
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public CriarFornecedor()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainPage menu = new MainPage();
            menu.Show();
            this.Close();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPNome.Text) || string.IsNullOrWhiteSpace(txtUNome.Text) || string.IsNullOrWhiteSpace(txtTele.Text))
                MessageBox.Show("Primeiro Nome, Último Nome e Telefone têm que se preenchidos!", "Atenção");
            else
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddForn";
                command.Parameters.AddWithValue("@PrimeiroNome", txtPNome.Text.Trim());
                command.Parameters.AddWithValue("@UltimoNome", txtUNome.Text.Trim());
                command.Parameters.AddWithValue("@Telefone", txtTele.Text.Trim());
                command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Fornecedor Criado com Sucesso!", "Criado!");
                CleanSpaces();
            }
        }

        private void CleanSpaces()
        {
            txtPNome.Text = txtUNome.Text = txtTele.Text = txtEmail.Text = "";
        }

        private void txtTele_Click(object sender, EventArgs e)
        {
            lbReferencia.Text = txtPNome.Text.Substring(0, 1) + txtUNome.Text.Substring(0,1); 
        }
    }
}
