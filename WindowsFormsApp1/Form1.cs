using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Color.Red);
            g.DrawEllipse(pen, 150, 150, 100, 100);
            g.DrawLine(pen, 250, 250, 100, 100);
        }
        Graphics g;
        Point ilk, son;
        bool kontrol = false;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (kontrol)
            //{
            //    son = e.Location;
            //    kontrol = false;
            //    Draw();
            //}
            //else
            //{
            //    ilk = e.Location;
            //    kontrol = true;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!kontrol)
            {
                ilk = e.Location;
                kontrol = false;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + " ," + e.Y;
            Pen pen = new Pen(Color.Red);
            pen.Width = 5;

            if (e.Button == MouseButtons.Left)
            {
                if (!ilk.IsEmpty)
                    son = e.Location;
                g.Clear(this.BackColor);
                Draw();
            }

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!kontrol)
            {
                ilk = e.Location;
                Draw();
                kontrol = false;
            }
        }

        private void Draw()
        {
            Pen pen = new Pen(Color.Blue);

            g.DrawLine(pen, ilk, son);
        }

    }
}
