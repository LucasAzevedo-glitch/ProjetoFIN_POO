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
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
            AtualizarTabela("Todos"); // Já carrega todos os livros assim que a janela abre
        }

        private void AtualizarTabela(string filtroStatus = "Todos")
        {
            dataGridView1.DataSource = null;

            if (filtroStatus == "Todos")
            {
                dataGridView1.DataSource = LivroLido.ListaLivros.ToList();
            }
            else
            {
                // Filtra a mesma lista na exibição sem criar listas separadas
                dataGridView1.DataSource = LivroLido.ListaLivros
                    .Where(l => l.Status == filtroStatus)
                    .ToList();
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            AtualizarTabela("Todos");
        }

        private void btnQueroLer_Click(object sender, EventArgs e)
        {
            AtualizarTabela("Quero Ler");
        }

        private void btnLendo_Click(object sender, EventArgs e)
        {
            AtualizarTabela("Lendo");
        }

        private void btnConcluídos_Click(object sender, EventArgs e)
        {
            AtualizarTabela("Concluído");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluirSelecionado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                LivroLido livroSelecionado = (LivroLido)dataGridView1.CurrentRow.DataBoundItem;
                LivroLido.ListaLivros.Remove(livroSelecionado);
                AtualizarTabela("Todos");
                MessageBox.Show("Livro excluído com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione um livro na tabela para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}