using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._22.Çarşamba.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //multicast:bir delege birden fazla event taşıyabilir.öyle olduğunda en son değeri döndürür.eventten sonra bir değer dönecekse eventargs tarafından döndürür.Eğer eventargs harici bir şeyse o zaman onun içerisinde öenmli bir bilgi var demektir.

            int sayi = 5;
            if (e.KeyCode == Keys.Right)
                lblAt.Left += sayi;
            else if (e.KeyCode == Keys.Left)
                lblAt.Left -= sayi;
            else if (e.KeyCode == Keys.Up)
                lblAt.Top -= sayi;
            else if (e.KeyCode == Keys.Down)
                lblAt.Top += sayi;
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dr = MessageBox.Show("Emin misiniz", "Uyarı", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    this.Close();
            }
            Label removedLabel = new Label();
            foreach (var item in yemler)
            {
                if (Math.Abs(lblAt.Location.X - item.Location.X) <= 10 && Math.Abs(lblAt.Location.Y - item.Location.Y) < 10)
                {
                    removedLabel = item;
                    this.Controls.Remove(item);
                    lblAt.ForeColor = Color.Blue;
                    float sz = lblAt.Font.Size;
                    lblAt.Font = new Font(this.Font.FontFamily, (sz + 5.00f));
                }
                if (Math.Abs(lblAt.Location.X - item.Location.X) < 50 && Math.Abs(lblAt.Location.Y - item.Location.Y) < 50)
                    item.ForeColor = Color.Red;
                else
                    item.ForeColor = Color.Black;
            }
            yemler.Remove(removedLabel);
        }
        List<Label> yemler;
        private void Form1_Load(object sender, EventArgs e)
        {
            yemler = new List<Label>();
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                int x = rnd.Next(50, this.Width - 50);
                int y = rnd.Next(50, this.Height - 50);
                Label lbl = new Label() { Text = "*", Top = x, Left = y };
                lbl.Font = new Font("Arial", 15.00f);

                this.Controls.Add(lbl);
                yemler.Add(lbl);
            }





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();



            for (int i = 0; i < 3; i++)
            {
                int x = rnd.Next(100, this.Width - 100);
                int y = rnd.Next(100, this.Height - 100);
                Label lbl = new Label() { Text = "*", Top = x, Left = y };
                lbl.Font = new Font("Arial", 15.00f);

                this.Controls.Add(lbl);
                yemler.Add(lbl);
                if (yemler.Count == 0)
                    timer1.Enabled = false;
            }

        }
    }
}

