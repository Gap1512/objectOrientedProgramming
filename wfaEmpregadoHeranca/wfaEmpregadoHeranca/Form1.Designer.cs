namespace wfaEmpregadoHeranca
{
    partial class Janela1
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.cbCLT = new System.Windows.Forms.CheckBox();
            this.cbHorista = new System.Windows.Forms.CheckBox();
            this.listbCLT = new System.Windows.Forms.ListBox();
            this.listbHorista = new System.Windows.Forms.ListBox();
            this.tbSBrutoCLT = new System.Windows.Forms.TextBox();
            this.tbPrecoH = new System.Windows.Forms.TextBox();
            this.tbNHoras = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbSBrutoCLT = new System.Windows.Forms.Label();
            this.lbPrecoH = new System.Windows.Forms.Label();
            this.lbNHoras = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.listbRelatorio = new System.Windows.Forms.ListBox();
            this.tabs.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabCadastro);
            this.tabs.Controls.Add(this.tabRelatorio);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(776, 426);
            this.tabs.TabIndex = 15;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.btCadastrar);
            this.tabCadastro.Controls.Add(this.cbCLT);
            this.tabCadastro.Controls.Add(this.cbHorista);
            this.tabCadastro.Controls.Add(this.listbCLT);
            this.tabCadastro.Controls.Add(this.listbHorista);
            this.tabCadastro.Controls.Add(this.tbSBrutoCLT);
            this.tabCadastro.Controls.Add(this.tbPrecoH);
            this.tabCadastro.Controls.Add(this.tbNHoras);
            this.tabCadastro.Controls.Add(this.tbEndereco);
            this.tabCadastro.Controls.Add(this.tbCPF);
            this.tabCadastro.Controls.Add(this.tbNome);
            this.tabCadastro.Controls.Add(this.lbSBrutoCLT);
            this.tabCadastro.Controls.Add(this.lbPrecoH);
            this.tabCadastro.Controls.Add(this.lbNHoras);
            this.tabCadastro.Controls.Add(this.lbEndereco);
            this.tabCadastro.Controls.Add(this.lbCPF);
            this.tabCadastro.Controls.Add(this.lbNome);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(768, 400);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(49, 343);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(317, 34);
            this.btCadastrar.TabIndex = 18;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // cbCLT
            // 
            this.cbCLT.AutoSize = true;
            this.cbCLT.Location = new System.Drawing.Point(462, 203);
            this.cbCLT.Name = "cbCLT";
            this.cbCLT.Size = new System.Drawing.Size(103, 17);
            this.cbCLT.TabIndex = 17;
            this.cbCLT.Text = "Empregado CLT";
            this.cbCLT.UseVisualStyleBackColor = true;
            this.cbCLT.CheckedChanged += new System.EventHandler(this.cbCLT_CheckedChanged);
            // 
            // cbHorista
            // 
            this.cbHorista.AutoSize = true;
            this.cbHorista.Location = new System.Drawing.Point(462, 40);
            this.cbHorista.Name = "cbHorista";
            this.cbHorista.Size = new System.Drawing.Size(116, 17);
            this.cbHorista.TabIndex = 16;
            this.cbHorista.Text = "Empregado Horista";
            this.cbHorista.UseVisualStyleBackColor = true;
            this.cbHorista.CheckedChanged += new System.EventHandler(this.cbHorista_CheckedChanged);
            // 
            // listbCLT
            // 
            this.listbCLT.FormattingEnabled = true;
            this.listbCLT.Location = new System.Drawing.Point(462, 226);
            this.listbCLT.Name = "listbCLT";
            this.listbCLT.Size = new System.Drawing.Size(249, 134);
            this.listbCLT.TabIndex = 15;
            // 
            // listbHorista
            // 
            this.listbHorista.FormattingEnabled = true;
            this.listbHorista.Location = new System.Drawing.Point(462, 63);
            this.listbHorista.Name = "listbHorista";
            this.listbHorista.Size = new System.Drawing.Size(249, 134);
            this.listbHorista.TabIndex = 14;
            // 
            // tbSBrutoCLT
            // 
            this.tbSBrutoCLT.Location = new System.Drawing.Point(142, 236);
            this.tbSBrutoCLT.Name = "tbSBrutoCLT";
            this.tbSBrutoCLT.Size = new System.Drawing.Size(225, 20);
            this.tbSBrutoCLT.TabIndex = 11;
            this.tbSBrutoCLT.Visible = false;
            // 
            // tbPrecoH
            // 
            this.tbPrecoH.Location = new System.Drawing.Point(141, 302);
            this.tbPrecoH.Name = "tbPrecoH";
            this.tbPrecoH.Size = new System.Drawing.Size(225, 20);
            this.tbPrecoH.TabIndex = 10;
            this.tbPrecoH.Visible = false;
            // 
            // tbNHoras
            // 
            this.tbNHoras.Location = new System.Drawing.Point(142, 236);
            this.tbNHoras.Name = "tbNHoras";
            this.tbNHoras.Size = new System.Drawing.Size(225, 20);
            this.tbNHoras.TabIndex = 9;
            this.tbNHoras.Visible = false;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(141, 170);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(225, 20);
            this.tbEndereco.TabIndex = 8;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(141, 104);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(225, 20);
            this.tbCPF.TabIndex = 7;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(141, 38);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(225, 20);
            this.tbNome.TabIndex = 6;
            // 
            // lbSBrutoCLT
            // 
            this.lbSBrutoCLT.AutoSize = true;
            this.lbSBrutoCLT.Location = new System.Drawing.Point(46, 243);
            this.lbSBrutoCLT.Name = "lbSBrutoCLT";
            this.lbSBrutoCLT.Size = new System.Drawing.Size(67, 13);
            this.lbSBrutoCLT.TabIndex = 5;
            this.lbSBrutoCLT.Text = "Salário Bruto";
            this.lbSBrutoCLT.Visible = false;
            // 
            // lbPrecoH
            // 
            this.lbPrecoH.AutoSize = true;
            this.lbPrecoH.Location = new System.Drawing.Point(46, 308);
            this.lbPrecoH.Name = "lbPrecoH";
            this.lbPrecoH.Size = new System.Drawing.Size(76, 13);
            this.lbPrecoH.TabIndex = 4;
            this.lbPrecoH.Text = "Preço da Hora";
            this.lbPrecoH.Visible = false;
            // 
            // lbNHoras
            // 
            this.lbNHoras.AutoSize = true;
            this.lbNHoras.Location = new System.Drawing.Point(46, 242);
            this.lbNHoras.Name = "lbNHoras";
            this.lbNHoras.Size = new System.Drawing.Size(90, 13);
            this.lbNHoras.TabIndex = 3;
            this.lbNHoras.Text = "Número de Horas";
            this.lbNHoras.Visible = false;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(46, 176);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 2;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(46, 110);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 1;
            this.lbCPF.Text = "CPF";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(46, 44);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.listbRelatorio);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(768, 400);
            this.tabRelatorio.TabIndex = 1;
            this.tabRelatorio.Text = "Relatório";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            this.tabRelatorio.Enter += new System.EventHandler(this.tabRelatorio_Enter);
            this.tabRelatorio.Leave += new System.EventHandler(this.tabRelatorio_Leave);
            // 
            // listbRelatorio
            // 
            this.listbRelatorio.FormattingEnabled = true;
            this.listbRelatorio.Location = new System.Drawing.Point(7, 7);
            this.listbRelatorio.Name = "listbRelatorio";
            this.listbRelatorio.Size = new System.Drawing.Size(755, 381);
            this.listbRelatorio.TabIndex = 0;
            // 
            // Janela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Name = "Janela1";
            this.Text = "Empregados";
            this.tabs.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tabRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.ListBox listbCLT;
        private System.Windows.Forms.ListBox listbHorista;
        private System.Windows.Forms.TextBox tbSBrutoCLT;
        private System.Windows.Forms.TextBox tbPrecoH;
        private System.Windows.Forms.TextBox tbNHoras;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbSBrutoCLT;
        private System.Windows.Forms.Label lbPrecoH;
        private System.Windows.Forms.Label lbNHoras;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.CheckBox cbCLT;
        private System.Windows.Forms.CheckBox cbHorista;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ListBox listbRelatorio;
    }
}

