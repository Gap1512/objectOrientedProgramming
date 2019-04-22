namespace wfaMediaAritmetica
{
    partial class formMedia
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
            this.lbNumero1 = new System.Windows.Forms.Label();
            this.lbNumero2 = new System.Windows.Forms.Label();
            this.tbNumero1 = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.tbNumero2 = new System.Windows.Forms.TextBox();
            this.lbMedia = new System.Windows.Forms.Label();
            this.tbMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNumero1
            // 
            this.lbNumero1.AutoSize = true;
            this.lbNumero1.Location = new System.Drawing.Point(45, 35);
            this.lbNumero1.Name = "lbNumero1";
            this.lbNumero1.Size = new System.Drawing.Size(53, 13);
            this.lbNumero1.TabIndex = 0;
            this.lbNumero1.Text = "Número 1";
            // 
            // lbNumero2
            // 
            this.lbNumero2.AutoSize = true;
            this.lbNumero2.Location = new System.Drawing.Point(45, 105);
            this.lbNumero2.Name = "lbNumero2";
            this.lbNumero2.Size = new System.Drawing.Size(53, 13);
            this.lbNumero2.TabIndex = 1;
            this.lbNumero2.Text = "Número 2";
            // 
            // tbNumero1
            // 
            this.tbNumero1.Location = new System.Drawing.Point(101, 32);
            this.tbNumero1.Name = "tbNumero1";
            this.tbNumero1.Size = new System.Drawing.Size(100, 20);
            this.tbNumero1.TabIndex = 2;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(207, 170);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(36, 23);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btOk_MouseClick);
            // 
            // tbNumero2
            // 
            this.tbNumero2.Location = new System.Drawing.Point(101, 102);
            this.tbNumero2.Name = "tbNumero2";
            this.tbNumero2.Size = new System.Drawing.Size(100, 20);
            this.tbNumero2.TabIndex = 3;
            // 
            // lbMedia
            // 
            this.lbMedia.AutoSize = true;
            this.lbMedia.Location = new System.Drawing.Point(45, 175);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.Size = new System.Drawing.Size(36, 13);
            this.lbMedia.TabIndex = 5;
            this.lbMedia.Text = "Média";
            // 
            // tbMedia
            // 
            this.tbMedia.Location = new System.Drawing.Point(101, 172);
            this.tbMedia.Name = "tbMedia";
            this.tbMedia.Size = new System.Drawing.Size(100, 20);
            this.tbMedia.TabIndex = 5;
            // 
            // formMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 226);
            this.Controls.Add(this.tbMedia);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.tbNumero2);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbNumero1);
            this.Controls.Add(this.lbNumero2);
            this.Controls.Add(this.lbNumero1);
            this.Name = "formMedia";
            this.Text = "Média Aritmética";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumero1;
        private System.Windows.Forms.Label lbNumero2;
        private System.Windows.Forms.TextBox tbNumero1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbNumero2;
        private System.Windows.Forms.Label lbMedia;
        private System.Windows.Forms.TextBox tbMedia;
    }
}

