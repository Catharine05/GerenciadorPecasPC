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
    public partial class menupeca : Form
    {
        public menupeca()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewpecas viewpecas = new viewpecas();
            viewpecas.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarpeca buscarpeca = new buscarpeca();
            buscarpeca.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterarpeca alterarpeca = new alterarpeca();
            alterarpeca.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletarpeca deletarpeca = new deletarpeca();
            deletarpeca.Show();
        }
    }
}
