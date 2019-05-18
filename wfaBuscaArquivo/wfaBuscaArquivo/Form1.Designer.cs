namespace wfaBuscaArquivo
{
    partial class formMain
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbDirEntrada = new System.Windows.Forms.TextBox();
            this.tbRWArquivo = new System.Windows.Forms.TextBox();
            this.btSalvarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(12, 44);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(173, 17);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Entre arquivo ou diretório:";
            // 
            // tbDirEntrada
            // 
            this.tbDirEntrada.Location = new System.Drawing.Point(12, 94);
            this.tbDirEntrada.Name = "tbDirEntrada";
            this.tbDirEntrada.Size = new System.Drawing.Size(362, 20);
            this.tbDirEntrada.TabIndex = 1;
            this.tbDirEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDirEntrada_KeyDown);
            // 
            // tbRWArquivo
            // 
            this.tbRWArquivo.Location = new System.Drawing.Point(12, 151);
            this.tbRWArquivo.Multiline = true;
            this.tbRWArquivo.Name = "tbRWArquivo";
            this.tbRWArquivo.Size = new System.Drawing.Size(362, 351);
            this.tbRWArquivo.TabIndex = 2;
            // 
            // btSalvarArquivo
            // 
            this.btSalvarArquivo.Location = new System.Drawing.Point(396, 94);
            this.btSalvarArquivo.Name = "btSalvarArquivo";
            this.btSalvarArquivo.Size = new System.Drawing.Size(75, 408);
            this.btSalvarArquivo.TabIndex = 4;
            this.btSalvarArquivo.Text = "Gravar No Arquivo";
            this.btSalvarArquivo.UseVisualStyleBackColor = true;
            this.btSalvarArquivo.Click += new System.EventHandler(this.btSalvarArquivo_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 515);
            this.Controls.Add(this.btSalvarArquivo);
            this.Controls.Add(this.tbRWArquivo);
            this.Controls.Add(this.tbDirEntrada);
            this.Controls.Add(this.lbInfo);
            this.Name = "formMain";
            this.Text = "Busca de Arquivo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbDirEntrada;
        private System.Windows.Forms.TextBox tbRWArquivo;
        private System.Windows.Forms.Button btSalvarArquivo;
    }
}

