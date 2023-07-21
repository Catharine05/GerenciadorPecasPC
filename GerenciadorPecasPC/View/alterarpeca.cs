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
    public partial class alterarpeca : Form
    {
        public alterarpeca()
        {
            InitializeComponent();
        }

        private void btn_AlterarDados_Click(object sender, EventArgs e)
        {
            Pecas.Codigo =Convert.ToInt32(txtBox_Codigo.Text);
            Pecas.Peca = textBox_Peca.Text;
            Pecas.Marca = textBox_Marca.Text;
            Pecas.Capacidade = textBox_Capacidade.Text;

            ManipulaPecas alt = new ManipulaPecas();

            alt.AlterarPecas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtBox_Codigo.Text);

            ManipulaPecas manipulaPecas = new ManipulaPecas();
            manipulaPecas.BuscaPecasCod();

            textBoxcodigo.Text = Pecas.Codigo.ToString();
            textBox_Peca.Text = Pecas.Peca;
            textBox_Marca.Text = Pecas.Marca;
            textBox_Capacidade.Text = Pecas.Capacidade;

        }
    }
}
