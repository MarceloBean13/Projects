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
    public partial class LogIn : Form
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.ReceitasConnectionString);
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT COUNT(*) FROM Administrador WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'", Connection);
            DataTable Table = new DataTable();
            Adapter.Fill(Table);

            if (Table.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainPage mp = new MainPage();
                mp.Show();
            }
            else
                MessageBox.Show("Username ou Password Incorrectos", "Falha a Entrar");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
          
            
            this.Close();
        }
    }
}
