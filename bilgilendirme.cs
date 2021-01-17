using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qweqwe
{
    public partial class bilgilendirme : Form
    {
        public bilgilendirme()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            string hayır = "Hayır";
            if (checkBox1.Checked == true)
            {
                c.baglantikur("select * from tekrar", "bilgilendirme");
                c.kaydet("update tekrar set bilgilendirme='" + hayır +"' where sno = '"+1+"'");
                this.Close();

            }
            else
            {
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bilgilendirme_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void bilgilendirme_FormClosing(object sender, FormClosingEventArgs e)
        {
            acilisekran a = new acilisekran();
            a.Close();
        }
    }
}
