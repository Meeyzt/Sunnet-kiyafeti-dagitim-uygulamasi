using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace qweqwe
{
    public partial class acilisekran : Form
    {
        public acilisekran()
        {
            InitializeComponent();
        }

        private void acilisekran_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        bilgilendirme sa = new bilgilendirme();
        Class1 c = new Class1();
        private void acilisekran_Load(object sender, EventArgs e)
        {
      
                this.Opacity = 0;
                acilistimer.Enabled = true;
        }
        double suka = 0.0;
        private void acilistimer_Tick(object sender, EventArgs e)
        {
            for (double i = 0.0; i < 1.1; i+=0.1)
            {
                this.Opacity = i;
                this.Refresh();
                Thread.Sleep(100);
                suka += 0.1;
                if (suka == 1.2)
                {
                    acilistimer.Enabled = false;
                    kapanistimer.Enabled = true;
                }
            }
        }

        private void kapanistimer_Tick(object sender, EventArgs e)
        {
            for (double i = 1.1; i >=0.0; i -= 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                Thread.Sleep(100);
                if (i == 0.00000000000000013877787807814457)
                {
                    anasayfa s = new anasayfa();
                    s.Show();
                    kapanistimer.Enabled = false;
                    this.Hide();
                }
             }
        }
    }
}
