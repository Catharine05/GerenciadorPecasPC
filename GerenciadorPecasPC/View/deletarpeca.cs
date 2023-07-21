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
    public partial class deletarpeca : Form
    {
        public deletarpeca()
        {
            InitializeComponent();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtBox_Codigo.Text);

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.DeletarPecas();
        }

        public void AbrirDeletar()
        {
            this.ShowDialog();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtBox_Digitar.Text);

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.BuscaPecasCod();

            txtBox_Codigo.Text = Pecas.Codigo.ToString();
            txtBox_Peca.Text = Pecas.Peca;
            txtBox_Marca.Text = Pecas.Marca;
            txtBox_Capacidade.Text = Pecas.Capacidade;
        }
    }
}
