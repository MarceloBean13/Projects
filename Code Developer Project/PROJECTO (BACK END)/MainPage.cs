using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECTO__BACK_END_
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnInserirReceitas_Click(object sender, EventArgs e)
        {
            Receitas menu = new Receitas();
            menu.Show();
            this.Hide();
        }

        private void btnInserirCozinha_Click(object sender, EventArgs e)
        {
            TipoCozinha child = new TipoCozinha();
            child.Show();
            this.Hide();
        }

        private void btnNovoTipoPrato_Click(object sender, EventArgs e)
        {
            TipoPrato child = new TipoPrato();
            child.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            CriacaodeConta child = new CriacaodeConta();
            child.Show();
            this.Hide();
        }

        private void btnUtilizadores_Click(object sender, EventArgs e)
        {
            VerUtilizador child = new VerUtilizador();
            child.Show();
            this.Hide();
        }

        private void btnNovaUnidade_Click(object sender, EventArgs e)
        {
            UnidadedeMedida child = new UnidadedeMedida();
            child.Show();
            this.Hide();
        }
    }
}
