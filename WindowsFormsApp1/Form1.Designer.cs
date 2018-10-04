namespace WindowsFormsApp1
{
    partial class Form1
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
            this.bt_Cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Cadastro
            // 
            this.bt_Cadastro.Location = new System.Drawing.Point(24, 26);
            this.bt_Cadastro.Name = "bt_Cadastro";
            this.bt_Cadastro.Size = new System.Drawing.Size(124, 23);
            this.bt_Cadastro.TabIndex = 0;
            this.bt_Cadastro.Text = "Cadastro";
            this.bt_Cadastro.UseVisualStyleBackColor = true;
            this.bt_Cadastro.Click += new System.EventHandler(this.bt_Cadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 255);
            this.Controls.Add(this.bt_Cadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Cadastro;
    }
}

