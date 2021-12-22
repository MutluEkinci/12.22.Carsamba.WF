using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready...";
            toolStripProgressBar1.Value = 76;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.Show("Merhaba", button2);

            notifyIcon1.ShowBalloonTip(2000, "Naber?", "Merhaba", ToolTipIcon.Error);
        }
    }
}
