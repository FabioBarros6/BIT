namespace WindowsFormsApp1
{
    partial class Form2
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
            this.bt_Cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Cadastro
            // 
            this.bt_Cadastro.Location = new System.Drawing.Point(24, 27);
            this.bt_Cadastro.Name = "bt_Cadastro";
            this.bt_Cadastro.Size = new System.Drawing.Size(75, 23);
            this.bt_Cadastro.TabIndex = 0;
            this.bt_Cadastro.Text = "Cadastro";
            this.bt_Cadastro.UseVisualStyleBackColor = true;
            this.bt_Cadastro.Click += new System.EventHandler(this.bt_Cadastro_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 217);
            this.Controls.Add(this.bt_Cadastro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Cadastro;
    }
}