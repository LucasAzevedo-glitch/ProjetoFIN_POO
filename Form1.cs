using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaPessoal
{
    public partial class BibliotecaPessoal : Form
    {
        public BibliotecaPessoal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listagem telaListagem = new Listagem();
            telaListagem.MdiParent = this;
            telaListagem.Show();
        }

        private void BibliotecaPessoal_Load(object sender, EventArgs e)
        {

        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro telaCadastro = new Cadastro();
            telaCadastro.MdiParent = this;
            telaCadastro.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
