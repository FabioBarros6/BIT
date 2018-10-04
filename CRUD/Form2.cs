using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void AbrirFormNoPainel(object FormFB)
        {
            if (this.pnCentral.Controls.Count > 0)
                this.pnCentral.Controls.RemoveAt(0);
            Form fh = FormFB as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnCentral.Controls.Add(fh);
            this.pnCentral.Tag = fh;
            fh.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Form1());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void pnCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ferramentas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Ferramentas());
        }
    }
}
