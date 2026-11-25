using System;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaPessoal
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            cmbStatus.SelectedIndex = -1;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtGenero.Clear();
            cmbStatus.SelectedIndex = -1;
            numNota.Value = 0;
            dtpDataLeitura.Value = DateTime.Now;
            txtCodigo.Focus();
        }

        // 1. BOTÃO BUSCAR (Preenche os campos se o código existir)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Digite um código numérico para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LivroLido livro = LivroLido.ListaLivros.FirstOrDefault(l => l.Codigo == codigo);

            if (livro != null)
            {
                txtTitulo.Text = livro.Titulo;
                txtAutor.Text = livro.Autor;
                txtGenero.Text = livro.Genero;
                cmbStatus.SelectedItem = livro.Status;
                numNota.Value = livro.Nota;
                dtpDataLeitura.Value = livro.DataLeitura;
            }
            else
            {
                MessageBox.Show("Nenhum livro encontrado com esse código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 2. BOTÃO SALVAR (Cadastra se for novo, ou Altera se o código já existir)
        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Digite um código numérico válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text) ||
                cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos antes de salvar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se já existe um livro com esse código
            LivroLido livro = LivroLido.ListaLivros.FirstOrDefault(l => l.Codigo == codigo);

            if (livro == null)
            {
                // Cria um novo livro
                livro = new LivroLido();
                livro.Codigo = codigo;
                LivroLido.ListaLivros.Add(livro);
            }

            // Atualiza os dados (serve tanto para novo quanto para alteração)
            livro.Titulo = txtTitulo.Text.Trim();
            livro.Autor = txtAutor.Text.Trim();
            livro.Genero = txtGenero.Text.Trim();
            livro.Status = cmbStatus.SelectedItem.ToString();
            livro.Nota = (int)numNota.Value;
            livro.DataLeitura = dtpDataLeitura.Value;

            MessageBox.Show("Livro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        // 3. BOTÃO EXCLUIR (Apaga o livro pelo código)
        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Digite o código do livro que deseja excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LivroLido livro = LivroLido.ListaLivros.FirstOrDefault(l => l.Codigo == codigo);

            if (livro != null)
            {
                LivroLido.ListaLivros.Remove(livro);
                MessageBox.Show("Livro excluído com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Nenhum livro encontrado com esse código.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Eventos vazios mantidos para não dar erro no Designer
        private void Cadastro_Load(object sender, EventArgs e) { }
        private void txtTitulo_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numNota_ValueChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void txtAutor_TextChanged(object sender, EventArgs e) { }
        private void txtGenero_TextChanged(object sender, EventArgs e) { }
        private void dptDataLeitura_ValueChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void txtCodigo_TextChanged(object sender, EventArgs e) { }
    }
}
