namespace BibliotecaPessoal
{
    partial class Listagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listagem));
            this.btnTodos = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnQueroLer = new System.Windows.Forms.Button();
            this.btnLendo = new System.Windows.Forms.Button();
            this.btnConcluídos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluirSelecionado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(63, 46);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 0;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnQueroLer
            // 
            this.btnQueroLer.Location = new System.Drawing.Point(157, 46);
            this.btnQueroLer.Name = "btnQueroLer";
            this.btnQueroLer.Size = new System.Drawing.Size(75, 23);
            this.btnQueroLer.TabIndex = 1;
            this.btnQueroLer.Text = "Quero Ler";
            this.btnQueroLer.UseVisualStyleBackColor = true;
            this.btnQueroLer.Click += new System.EventHandler(this.btnQueroLer_Click);
            // 
            // btnLendo
            // 
            this.btnLendo.Location = new System.Drawing.Point(251, 46);
            this.btnLendo.Name = "btnLendo";
            this.btnLendo.Size = new System.Drawing.Size(75, 23);
            this.btnLendo.TabIndex = 2;
            this.btnLendo.Text = "Lendo";
            this.btnLendo.UseVisualStyleBackColor = true;
            this.btnLendo.Click += new System.EventHandler(this.btnLendo_Click);
            // 
            // btnConcluídos
            // 
            this.btnConcluídos.Location = new System.Drawing.Point(343, 46);
            this.btnConcluídos.Name = "btnConcluídos";
            this.btnConcluídos.Size = new System.Drawing.Size(75, 23);
            this.btnConcluídos.TabIndex = 3;
            this.btnConcluídos.Text = "Concluídos";
            this.btnConcluídos.UseVisualStyleBackColor = true;
            this.btnConcluídos.Click += new System.EventHandler(this.btnConcluídos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(747, 328);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnExcluirSelecionado
            // 
            this.btnExcluirSelecionado.Location = new System.Drawing.Point(577, 431);
            this.btnExcluirSelecionado.Name = "btnExcluirSelecionado";
            this.btnExcluirSelecionado.Size = new System.Drawing.Size(126, 23);
            this.btnExcluirSelecionado.TabIndex = 5;
            this.btnExcluirSelecionado.Text = "Excluir Selecionado\r\n";
            this.btnExcluirSelecionado.UseVisualStyleBackColor = true;
            this.btnExcluirSelecionado.Click += new System.EventHandler(this.btnExcluirSelecionado_Click);
            // 
            // Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluirSelecionado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConcluídos);
            this.Controls.Add(this.btnLendo);
            this.Controls.Add(this.btnQueroLer);
            this.Controls.Add(this.btnTodos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listagem";
            this.Text = "Listagem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnQueroLer;
        private System.Windows.Forms.Button btnLendo;
        private System.Windows.Forms.Button btnConcluídos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluirSelecionado;
    }
}