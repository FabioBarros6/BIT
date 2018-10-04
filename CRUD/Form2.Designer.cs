namespace CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Cadastro = new System.Windows.Forms.Button();
            this.pnLateral = new System.Windows.Forms.Panel();
            this.Ferramentas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnSup = new System.Windows.Forms.Panel();
            this.pnCentral = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cadastro.FlatAppearance.BorderSize = 0;
            this.Cadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Cadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastro.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cadastro.Image = ((System.Drawing.Image)(resources.GetObject("Cadastro.Image")));
            this.Cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cadastro.Location = new System.Drawing.Point(6, 87);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(191, 38);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            this.Cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnLateral
            // 
            this.pnLateral.BackColor = System.Drawing.Color.Silver;
            this.pnLateral.Controls.Add(this.Ferramentas);
            this.pnLateral.Controls.Add(this.pictureBox1);
            this.pnLateral.Controls.Add(this.Cadastro);
            this.pnLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLateral.Location = new System.Drawing.Point(0, 0);
            this.pnLateral.Name = "pnLateral";
            this.pnLateral.Size = new System.Drawing.Size(200, 403);
            this.pnLateral.TabIndex = 1;
            // 
            // Ferramentas
            // 
            this.Ferramentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ferramentas.FlatAppearance.BorderSize = 0;
            this.Ferramentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Ferramentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.Ferramentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ferramentas.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ferramentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ferramentas.Image = ((System.Drawing.Image)(resources.GetObject("Ferramentas.Image")));
            this.Ferramentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ferramentas.Location = new System.Drawing.Point(5, 138);
            this.Ferramentas.Name = "Ferramentas";
            this.Ferramentas.Size = new System.Drawing.Size(191, 38);
            this.Ferramentas.TabIndex = 2;
            this.Ferramentas.Text = "Ferramentas";
            this.Ferramentas.UseVisualStyleBackColor = true;
            this.Ferramentas.Click += new System.EventHandler(this.Ferramentas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnSup
            // 
            this.pnSup.BackColor = System.Drawing.Color.Silver;
            this.pnSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSup.Location = new System.Drawing.Point(200, 0);
            this.pnSup.Name = "pnSup";
            this.pnSup.Size = new System.Drawing.Size(788, 54);
            this.pnSup.TabIndex = 2;
            // 
            // pnCentral
            // 
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCentral.Location = new System.Drawing.Point(200, 54);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(788, 349);
            this.pnCentral.TabIndex = 3;
            this.pnCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCentral_Paint);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 403);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.pnSup);
            this.Controls.Add(this.pnLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cadastro;
        private System.Windows.Forms.Panel pnLateral;
        private System.Windows.Forms.Panel pnSup;
        private System.Windows.Forms.Panel pnCentral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ferramentas;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}