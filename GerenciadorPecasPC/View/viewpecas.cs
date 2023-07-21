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
    public partial class viewpecas : Form
    {
        public viewpecas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarPecas_Click(object sender, EventArgs e)
        {
            Pecas.Peca = txtBoxPeca.Text;
            Pecas.Marca = txtBoxMarca.Text;
            Pecas.Capacidade = txtBoxCapacidade.Text;

            ManipulaPecas mPeca = new ManipulaPecas();
            mPeca.CadPecas();
        }

        public void AbrirCadastrado()
        {
            this.ShowDialog();
        }
    }
}
