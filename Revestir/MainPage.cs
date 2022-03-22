using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revestir
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnForn_Click(object sender, EventArgs e)
        {
            VerFornecedor form = new VerFornecedor();
            form.Show();
            this.Hide();
        }

        private void btnCriarForn_Click(object sender, EventArgs e)
        {
            CriarFornecedor form = new CriarFornecedor();
            form.Show();
            this.Hide();
        }

        private void btnArtigos_Click(object sender, EventArgs e)
        {
            VerArtigos form = new VerArtigos();
            form.Show();
            this.Hide();
        }
    }
}
