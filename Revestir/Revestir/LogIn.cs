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
    public partial class LogIn : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.Connection);

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SELECT COUNT(*) FROM Admin WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'", conn);
            DataTable table = new DataTable();
            adp.Fill(table);

            if (table.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                PagPrincipal child = new PagPrincipal();
                child.Show();

            }
            else
            {
                MessageBox.Show("Username ou Password Errada!!", "Erro");
                txtPassword.Text = "";
            }

        }
    }
}
