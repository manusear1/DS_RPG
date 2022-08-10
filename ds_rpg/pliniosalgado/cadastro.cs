using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pliniosalgado
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolstrip toolstrip = new toolstrip();
            toolstrip.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        private void cadastro_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.progressBar1.Value > 100)
                this.timer1.Enabled = false;
            else 
                this.progressBar1.Value += 1;
        }
    }
}
