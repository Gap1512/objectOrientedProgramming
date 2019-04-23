namespace WindowsFormsApp1
{
    partial class fAlunoMateria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabGuias = new System.Windows.Forms.TabControl();
            this.tpAluno = new System.Windows.Forms.TabPage();
            this.tbPeriodoAluno = new System.Windows.Forms.TextBox();
            this.tbMatriculaAluno = new System.Windows.Forms.TextBox();
            this.tbNomeAluno = new System.Windows.Forms.TextBox();
            this.btCadastrarAluno = new System.Windows.Forms.Button();
            this.lbPeriodo = new System.Windows.Forms.Label();
            this.lbMatriculaAluno = new System.Windows.Forms.Label();
            this.lbNomeAluno = new System.Windows.Forms.Label();
            this.tpMateria = new System.Windows.Forms.TabPage();
            this.tbCodigoMateria = new System.Windows.Forms.TextBox();
            this.tbNomeMateria = new System.Windows.Forms.TextBox();
            this.btCadastrarMateria = new System.Windows.Forms.Button();
            this.lbCodigoMateria = new System.Windows.Forms.Label();
            this.lbNomeMateria = new System.Windows.Forms.Label();
            this.tpRelatorio = new System.Windows.Forms.TabPage();
            this.Alunos = new System.Windows.Forms.ListBox();
            this.Materias = new System.Windows.Forms.ListBox();
            this.btAssociar = new System.Windows.Forms.Button();
            this.Relatorio = new System.Windows.Forms.ListBox();
            this.tabGuias.SuspendLayout();
            this.tpAluno.SuspendLayout();
            this.tpMateria.SuspendLayout();
            this.tpRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGuias
            // 
            this.tabGuias.Controls.Add(this.tpAluno);
            this.tabGuias.Controls.Add(this.tpMateria);
            this.tabGuias.Controls.Add(this.tpRelatorio);
            this.tabGuias.Location = new System.Drawing.Point(2, 3);
            this.tabGuias.Name = "tabGuias";
            this.tabGuias.SelectedIndex = 0;
            this.tabGuias.Size = new System.Drawing.Size(795, 255);
            this.tabGuias.TabIndex = 0;
            // 
            // tpAluno
            // 
            this.tpAluno.Controls.Add(this.Alunos);
            this.tpAluno.Controls.Add(this.tbPeriodoAluno);
            this.tpAluno.Controls.Add(this.tbMatriculaAluno);
            this.tpAluno.Controls.Add(this.tbNomeAluno);
            this.tpAluno.Controls.Add(this.btCadastrarAluno);
            this.tpAluno.Controls.Add(this.lbPeriodo);
            this.tpAluno.Controls.Add(this.lbMatriculaAluno);
            this.tpAluno.Controls.Add(this.lbNomeAluno);
            this.tpAluno.Location = new System.Drawing.Point(4, 22);
            this.tpAluno.Name = "tpAluno";
            this.tpAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tpAluno.Size = new System.Drawing.Size(787, 229);
            this.tpAluno.TabIndex = 0;
            this.tpAluno.Text = "Aluno";
            this.tpAluno.UseVisualStyleBackColor = true;
            // 
            // tbPeriodoAluno
            // 
            this.tbPeriodoAluno.Location = new System.Drawing.Point(150, 124);
            this.tbPeriodoAluno.Name = "tbPeriodoAluno";
            this.tbPeriodoAluno.Size = new System.Drawing.Size(268, 20);
            this.tbPeriodoAluno.TabIndex = 5;
            // 
            // tbMatriculaAluno
            // 
            this.tbMatriculaAluno.Location = new System.Drawing.Point(150, 68);
            this.tbMatriculaAluno.Name = "tbMatriculaAluno";
            this.tbMatriculaAluno.Size = new System.Drawing.Size(268, 20);
            this.tbMatriculaAluno.TabIndex = 4;
            // 
            // tbNomeAluno
            // 
            this.tbNomeAluno.Location = new System.Drawing.Point(150, 12);
            this.tbNomeAluno.Name = "tbNomeAluno";
            this.tbNomeAluno.Size = new System.Drawing.Size(268, 20);
            this.tbNomeAluno.TabIndex = 3;
            // 
            // btCadastrarAluno
            // 
            this.btCadastrarAluno.Location = new System.Drawing.Point(25, 187);
            this.btCadastrarAluno.Name = "btCadastrarAluno";
            this.btCadastrarAluno.Size = new System.Drawing.Size(393, 23);
            this.btCadastrarAluno.TabIndex = 6;
            this.btCadastrarAluno.Text = "Cadastrar";
            this.btCadastrarAluno.UseVisualStyleBackColor = true;
            this.btCadastrarAluno.Click += new System.EventHandler(this.btCadastrarAluno_Click);
            // 
            // lbPeriodo
            // 
            this.lbPeriodo.AutoSize = true;
            this.lbPeriodo.Location = new System.Drawing.Point(25, 131);
            this.lbPeriodo.Name = "lbPeriodo";
            this.lbPeriodo.Size = new System.Drawing.Size(92, 13);
            this.lbPeriodo.TabIndex = 2;
            this.lbPeriodo.Text = "Período Do Aluno";
            // 
            // lbMatriculaAluno
            // 
            this.lbMatriculaAluno.AutoSize = true;
            this.lbMatriculaAluno.Location = new System.Drawing.Point(25, 75);
            this.lbMatriculaAluno.Name = "lbMatriculaAluno";
            this.lbMatriculaAluno.Size = new System.Drawing.Size(99, 13);
            this.lbMatriculaAluno.TabIndex = 1;
            this.lbMatriculaAluno.Text = "Matrícula Do Aluno";
            // 
            // lbNomeAluno
            // 
            this.lbNomeAluno.AutoSize = true;
            this.lbNomeAluno.Location = new System.Drawing.Point(25, 19);
            this.lbNomeAluno.Name = "lbNomeAluno";
            this.lbNomeAluno.Size = new System.Drawing.Size(82, 13);
            this.lbNomeAluno.TabIndex = 0;
            this.lbNomeAluno.Text = "Nome Do Aluno";
            // 
            // tpMateria
            // 
            this.tpMateria.Controls.Add(this.btAssociar);
            this.tpMateria.Controls.Add(this.Materias);
            this.tpMateria.Controls.Add(this.tbCodigoMateria);
            this.tpMateria.Controls.Add(this.tbNomeMateria);
            this.tpMateria.Controls.Add(this.btCadastrarMateria);
            this.tpMateria.Controls.Add(this.lbCodigoMateria);
            this.tpMateria.Controls.Add(this.lbNomeMateria);
            this.tpMateria.Location = new System.Drawing.Point(4, 22);
            this.tpMateria.Name = "tpMateria";
            this.tpMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tpMateria.Size = new System.Drawing.Size(787, 229);
            this.tpMateria.TabIndex = 1;
            this.tpMateria.Text = "Matéria";
            this.tpMateria.UseVisualStyleBackColor = true;
            // 
            // tbCodigoMateria
            // 
            this.tbCodigoMateria.Location = new System.Drawing.Point(148, 103);
            this.tbCodigoMateria.Name = "tbCodigoMateria";
            this.tbCodigoMateria.Size = new System.Drawing.Size(218, 20);
            this.tbCodigoMateria.TabIndex = 10;
            // 
            // tbNomeMateria
            // 
            this.tbNomeMateria.Location = new System.Drawing.Point(148, 25);
            this.tbNomeMateria.Name = "tbNomeMateria";
            this.tbNomeMateria.Size = new System.Drawing.Size(218, 20);
            this.tbNomeMateria.TabIndex = 9;
            // 
            // btCadastrarMateria
            // 
            this.btCadastrarMateria.Location = new System.Drawing.Point(23, 188);
            this.btCadastrarMateria.Name = "btCadastrarMateria";
            this.btCadastrarMateria.Size = new System.Drawing.Size(343, 23);
            this.btCadastrarMateria.TabIndex = 11;
            this.btCadastrarMateria.Text = "Cadastrar";
            this.btCadastrarMateria.UseVisualStyleBackColor = true;
            this.btCadastrarMateria.Click += new System.EventHandler(this.btCadastrarMateria_Click);
            // 
            // lbCodigoMateria
            // 
            this.lbCodigoMateria.AutoSize = true;
            this.lbCodigoMateria.Location = new System.Drawing.Point(23, 110);
            this.lbCodigoMateria.Name = "lbCodigoMateria";
            this.lbCodigoMateria.Size = new System.Drawing.Size(95, 13);
            this.lbCodigoMateria.TabIndex = 8;
            this.lbCodigoMateria.Text = "Código Da Matéria";
            // 
            // lbNomeMateria
            // 
            this.lbNomeMateria.AutoSize = true;
            this.lbNomeMateria.Location = new System.Drawing.Point(23, 32);
            this.lbNomeMateria.Name = "lbNomeMateria";
            this.lbNomeMateria.Size = new System.Drawing.Size(90, 13);
            this.lbNomeMateria.TabIndex = 7;
            this.lbNomeMateria.Text = "Nome Da Matéria";
            // 
            // tpRelatorio
            // 
            this.tpRelatorio.Controls.Add(this.Relatorio);
            this.tpRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tpRelatorio.Name = "tpRelatorio";
            this.tpRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelatorio.Size = new System.Drawing.Size(787, 229);
            this.tpRelatorio.TabIndex = 2;
            this.tpRelatorio.Text = "Relatório";
            this.tpRelatorio.UseVisualStyleBackColor = true;
            this.tpRelatorio.Enter += new System.EventHandler(this.tpRelatorio_Enter);
            this.tpRelatorio.Leave += new System.EventHandler(this.tpRelatorio_Leave);
            // 
            // Alunos
            // 
            this.Alunos.FormattingEnabled = true;
            this.Alunos.Location = new System.Drawing.Point(462, 12);
            this.Alunos.Name = "Alunos";
            this.Alunos.Size = new System.Drawing.Size(308, 199);
            this.Alunos.TabIndex = 14;
            // 
            // Materias
            // 
            this.Materias.FormattingEnabled = true;
            this.Materias.Location = new System.Drawing.Point(408, 25);
            this.Materias.Name = "Materias";
            this.Materias.Size = new System.Drawing.Size(350, 134);
            this.Materias.TabIndex = 15;
            // 
            // btAssociar
            // 
            this.btAssociar.Location = new System.Drawing.Point(408, 188);
            this.btAssociar.Name = "btAssociar";
            this.btAssociar.Size = new System.Drawing.Size(350, 23);
            this.btAssociar.TabIndex = 16;
            this.btAssociar.Text = "Associar Aluno E Matéria";
            this.btAssociar.UseVisualStyleBackColor = true;
            this.btAssociar.Click += new System.EventHandler(this.btAssociar_Click);
            // 
            // Relatorio
            // 
            this.Relatorio.FormattingEnabled = true;
            this.Relatorio.Location = new System.Drawing.Point(3, 3);
            this.Relatorio.Name = "Relatorio";
            this.Relatorio.Size = new System.Drawing.Size(779, 225);
            this.Relatorio.TabIndex = 0;
            // 
            // fAlunoMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.tabGuias);
            this.Name = "fAlunoMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Aluno/Materia";
            this.tabGuias.ResumeLayout(false);
            this.tpAluno.ResumeLayout(false);
            this.tpAluno.PerformLayout();
            this.tpMateria.ResumeLayout(false);
            this.tpMateria.PerformLayout();
            this.tpRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGuias;
        private System.Windows.Forms.TabPage tpAluno;
        private System.Windows.Forms.TabPage tpMateria;
        private System.Windows.Forms.TabPage tpRelatorio;
        private System.Windows.Forms.TextBox tbPeriodoAluno;
        private System.Windows.Forms.TextBox tbMatriculaAluno;
        private System.Windows.Forms.TextBox tbNomeAluno;
        private System.Windows.Forms.Button btCadastrarAluno;
        private System.Windows.Forms.Label lbPeriodo;
        private System.Windows.Forms.Label lbMatriculaAluno;
        private System.Windows.Forms.Label lbNomeAluno;
        private System.Windows.Forms.TextBox tbCodigoMateria;
        private System.Windows.Forms.TextBox tbNomeMateria;
        private System.Windows.Forms.Button btCadastrarMateria;
        private System.Windows.Forms.Label lbCodigoMateria;
        private System.Windows.Forms.Label lbNomeMateria;
        private System.Windows.Forms.ListBox Alunos;
        private System.Windows.Forms.ListBox Materias;
        private System.Windows.Forms.Button btAssociar;
        private System.Windows.Forms.ListBox Relatorio;
    }
}

