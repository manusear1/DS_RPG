using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pliniosalgado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void abrirOutroFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.Show();
        }

        private void umToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loucoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolstrip toolstrip = new toolstrip();
            toolstrip.Show();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void aplicativosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecutor.StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\Office15\\WinWord.Exe";
            prcExecutor.Start();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecutor.StartInfo.FileName ="Calc.Exe";
            prcExecutor.Start();
        }
    }
}
