using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace qweqwe
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alanlar f2 = new alanlar();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            almayanlar f4 = new almayanlar();
            f4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            alacak f5= new alacak();
            f5.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Mov;
        int mx;
        int my;
        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = 0;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = 1;
            mx = e.X;
            my = e.Y;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yenikayit f6 = new yenikayit();
            f6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adarama f7 = new Adarama();
            f7.Show();
        }
    }
}
