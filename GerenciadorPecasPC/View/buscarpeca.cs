using GerenciadorPecasPC.Controller;
using GerenciadorPecasPC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorPecasPC.View
{
    public partial class buscarpeca : Form
    {
        public buscarpeca()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtBoxCodigoPeca.Text);

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.BuscaPecasCod();

            txtBoxCodigoPeca.Text = Pecas.Codigo.ToString();
            txtBoxPeca.Text = Pecas.Peca;
            txtBoxMarca.Text = Pecas.Marca;
            txtBoxCapacidade.Text = Pecas.Capacidade;
        }
    }
}
