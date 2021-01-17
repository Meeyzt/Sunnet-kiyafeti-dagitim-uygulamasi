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
    public partial class alacak : Form
    {
        public alacak()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Clear();
            tbnot.Clear();
            tbad.Clear();
            tbsoy.Clear();
            tbmahalle.Clear();
            tbadres.Clear();
            tbtel.Clear();
            cbdurum.Text = "";
            cbdurum.Items.Clear();
            string[] durum = { "ALDI", "ALMADI", "EKSİKLERİ VAR" };
            cbdurum.Items.AddRange(durum);
            tbalan.Clear();
            tbilce.Clear();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                temizle();
            }
            else
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbsoy.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbilce.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbmahalle.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbadres.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbtel.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbalan.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbnot.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }
        Class1 c = new Class1();
        private void alacak_Load(object sender, EventArgs e)
        {
            c.baglantikur("Select *from tumkayitlar", "tumkayitlar");
            dataGridView1.DataSource = c.ds.Tables["tumkayitlar"];
            if (dataGridView1.Rows.Count < 0)
            {
                 label14.Visible = true;
            }
            else
            {
                 label14.Visible = false;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
        int Mov;
        int mx;
        int my;
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            c.kaydet("update tumkayitlar set alankisi='"+tbalan.Text+"',notl='"+tbnot.Text+"',durum='"+cbdurum.Text+"' where tcno='"+textBox1.Text+"'");
            if (c.kaydettimi == true)
            {
                temizle();
                MessageBox.Show("Başarı İle Kayıt Tamamlandı!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                c.baglantikur("select*from tumkayitlar", "tumkayitlar");
                dataGridView1.DataSource = c.ds.Tables["tumkayitlar"];
            }
            else
            {
                MessageBox.Show("Opps! Birşeyler Ters gitti", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.baglantikur("Select *from tumkayitlar Where Tcno like'" + textBox1.Text + "%'", "tumkayitlar");
            dataGridView1.DataSource = c.ds.Tables["tumkayitlar"];
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox1.Text = "";
        }
    }
}
