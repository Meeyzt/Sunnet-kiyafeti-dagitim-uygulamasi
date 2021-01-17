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
    public partial class yenikayit : Form
    {
        int Mov;
        int mx;
        int my;
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

        //kod başlangıç
        // () ;
        public yenikayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            tbtc.Clear();
            tbnot.Clear();
            tbad.Clear();
            tbsoyad.Clear();
            tbmahalle.Clear();
            tbalan.Clear();
            tbadres.Clear();
            tbtel.Clear();
            cbdurum.Text = "";
            cbdurum.Items.Clear();
            string[] durum = { "ALDI", "ALMADI", "EKSİKLERİ VAR" };
            cbdurum.Items.AddRange(durum);
            cbilce.Items.Clear();
            string[] ilceler = { "OSMANGAZİ", "NİLÜFER", "YILDIRIM" };
            cbilce.Items.AddRange(ilceler);            
        }
       
        Class1 c = new Class1();

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        //kayıt butonu
        public bool sadisfeksın;
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbtc.Text == "" && tbnot.Text == "" && tbad.Text == "" && tbsoyad.Text == "" && tbmahalle.Text == "" && tbadres.Text == "" && tbtel.Text == "" && cbdurum.Text == "" && cbilce.Text == "" && tbalan.Text == "")
            {
                //boş textbox  olunca yapılacaklar
                MessageBox.Show("Lütfen boş alan bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                c.baglantikur("select * from tumkayitlar where tcno='" + tbtc.Text + "'", "tumkayitlar");
                dataGridView1.DataSource = c.ds.Tables["tumkayitlar"];
                if (dataGridView1.Rows.Count > 0)
                {
                    MessageBox.Show("Aynı TC Numarasına Sahip Kayıt Mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                c.kaydet("insert into tumkayitlar (tcno,ad,soyad,ilce,mahalle,telefon,durum,alankisi,notl,adres) values ('" + tbtc.Text + "','" + tbad.Text + "','" + tbsoyad.Text + "','" + cbilce.Text + "','" + tbmahalle.Text + "','" + tbtel.Text + "','" + cbdurum.Text + "','" + tbalan.Text + "','" + tbnot.Text + "','" + tbadres.Text + "')");
                MessageBox.Show("Kayıt Başarılı", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
        }

        private void yenikayit_Load(object sender, EventArgs e)
        {
            string[] ilceler = { "OSMANGAZİ", "NİLÜFER", "YILDIRIM" };
            cbilce.Items.AddRange(ilceler);
            string[] durum = { "ALDI", "ALMADI", "EKSİKLERİ VAR" };
            cbdurum.Items.AddRange(durum);
        }

        private void tbtc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                tbad.Focus();
            }
        }
        private void tbad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                tbsoyad.Focus();
            }
        }
        private void tbsoyad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                cbilce.Focus();
            }
        }
        private void cbilce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                tbmahalle.Focus();
            }
        }
        private void tbmahalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                tbadres.Focus();
            }
        }
        private void tbadres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                cbdurum.Focus();
            }
        }
        private void cbdurum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                tbalan.Focus();
            }
        }
        private void tbalan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                tbnot.Focus();
            }
        }
        private void tbnot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                tbtel.Focus();
            }
        }
        private void tbtel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                button1.Focus();
            }
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                tbtc.Focus();
            }
        }
    }
    
}
