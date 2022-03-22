using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECTO__BACK_END_
{
    public partial class CriacaodeConta : Form
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.ReceitasConnectionString);
        public CriacaodeConta()
        {
            InitializeComponent();
        }

        private void CriacaodeConta_Load(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Preencher campos obrigatórios!", "Atenção");
            else if (txtPassword.Text != txtConfirm.Text)
                MessageBox.Show("As Passwords não são iguais!", "Passwords Diferentes");
            else
            {
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "CriarUtilizador";
                Command.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                Command.Parameters.AddWithValue("@UltimoNome", txtUltimo.Text.Trim());
                Command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                Command.Parameters.AddWithValue("@Username", txtUser.Text.Trim());
                Command.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Criado com sucesso!", "Sucesso");
                LimparEspaços();
            }

        }
        void LimparEspaços()
        {
            txtNome.Text = txtUltimo.Text = txtEmail.Text = txtUser.Text = txtPassword.Text = txtConfirm.Text = "";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainPage menu = new MainPage();
            menu.Show();
            this.Hide();
        }
    }
}
