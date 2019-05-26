namespace wfaPilha
{
    partial class formPilha
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
            this.lbPilha = new System.Windows.Forms.Label();
            this.btPush = new System.Windows.Forms.Button();
            this.btPop = new System.Windows.Forms.Button();
            this.btImprime = new System.Windows.Forms.Button();
            this.btMaior = new System.Windows.Forms.Button();
            this.btMenor = new System.Windows.Forms.Button();
            this.btInverte = new System.Windows.Forms.Button();
            this.tbPilha = new System.Windows.Forms.TextBox();
            this.tbPush = new System.Windows.Forms.TextBox();
            this.tbPop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPilha
            // 
            this.lbPilha.AutoSize = true;
            this.lbPilha.Location = new System.Drawing.Point(12, 17);
            this.lbPilha.Name = "lbPilha";
            this.lbPilha.Size = new System.Drawing.Size(30, 13);
            this.lbPilha.TabIndex = 0;
            this.lbPilha.Text = "Pilha";
            // 
            // btPush
            // 
            this.btPush.Location = new System.Drawing.Point(180, 12);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(75, 23);
            this.btPush.TabIndex = 1;
            this.btPush.Text = "Push";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // btPop
            // 
            this.btPop.Location = new System.Drawing.Point(180, 88);
            this.btPop.Name = "btPop";
            this.btPop.Size = new System.Drawing.Size(75, 23);
            this.btPop.TabIndex = 2;
            this.btPop.Text = "Pop";
            this.btPop.UseVisualStyleBackColor = true;
            this.btPop.Click += new System.EventHandler(this.btPop_Click);
            // 
            // btImprime
            // 
            this.btImprime.Location = new System.Drawing.Point(180, 164);
            this.btImprime.Name = "btImprime";
            this.btImprime.Size = new System.Drawing.Size(75, 23);
            this.btImprime.TabIndex = 3;
            this.btImprime.Text = "Imprime";
            this.btImprime.UseVisualStyleBackColor = true;
            this.btImprime.Click += new System.EventHandler(this.btImprime_Click);
            // 
            // btMaior
            // 
            this.btMaior.Location = new System.Drawing.Point(180, 240);
            this.btMaior.Name = "btMaior";
            this.btMaior.Size = new System.Drawing.Size(75, 23);
            this.btMaior.TabIndex = 4;
            this.btMaior.Text = "Maior";
            this.btMaior.UseVisualStyleBackColor = true;
            this.btMaior.Click += new System.EventHandler(this.btMaior_Click);
            // 
            // btMenor
            // 
            this.btMenor.Location = new System.Drawing.Point(180, 316);
            this.btMenor.Name = "btMenor";
            this.btMenor.Size = new System.Drawing.Size(75, 23);
            this.btMenor.TabIndex = 5;
            this.btMenor.Text = "Menor";
            this.btMenor.UseVisualStyleBackColor = true;
            this.btMenor.Click += new System.EventHandler(this.btMenor_Click);
            // 
            // btInverte
            // 
            this.btInverte.Location = new System.Drawing.Point(180, 392);
            this.btInverte.Name = "btInverte";
            this.btInverte.Size = new System.Drawing.Size(75, 23);
            this.btInverte.TabIndex = 6;
            this.btInverte.Text = "Inverte";
            this.btInverte.UseVisualStyleBackColor = true;
            this.btInverte.Click += new System.EventHandler(this.btInverte_Click);
            // 
            // tbPilha
            // 
            this.tbPilha.Location = new System.Drawing.Point(53, 12);
            this.tbPilha.Multiline = true;
            this.tbPilha.Name = "tbPilha";
            this.tbPilha.ReadOnly = true;
            this.tbPilha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPilha.Size = new System.Drawing.Size(121, 403);
            this.tbPilha.TabIndex = 7;
            // 
            // tbPush
            // 
            this.tbPush.Location = new System.Drawing.Point(261, 14);
            this.tbPush.Name = "tbPush";
            this.tbPush.Size = new System.Drawing.Size(100, 20);
            this.tbPush.TabIndex = 8;
            // 
            // tbPop
            // 
            this.tbPop.Location = new System.Drawing.Point(261, 90);
            this.tbPop.Name = "tbPop";
            this.tbPop.ReadOnly = true;
            this.tbPop.Size = new System.Drawing.Size(100, 20);
            this.tbPop.TabIndex = 9;
            // 
            // formPilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 428);
            this.Controls.Add(this.tbPop);
            this.Controls.Add(this.tbPush);
            this.Controls.Add(this.tbPilha);
            this.Controls.Add(this.btInverte);
            this.Controls.Add(this.btMenor);
            this.Controls.Add(this.btMaior);
            this.Controls.Add(this.btImprime);
            this.Controls.Add(this.btPop);
            this.Controls.Add(this.btPush);
            this.Controls.Add(this.lbPilha);
            this.Name = "formPilha";
            this.Text = "Pilha de Inteiros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPilha;
        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.Button btPop;
        private System.Windows.Forms.Button btImprime;
        private System.Windows.Forms.Button btMaior;
        private System.Windows.Forms.Button btMenor;
        private System.Windows.Forms.Button btInverte;
        private System.Windows.Forms.TextBox tbPilha;
        private System.Windows.Forms.TextBox tbPush;
        private System.Windows.Forms.TextBox tbPop;
    }
}

