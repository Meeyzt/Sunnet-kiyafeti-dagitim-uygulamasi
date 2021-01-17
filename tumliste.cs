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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
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
            tbdurum.Text = "";
            tbalan.Clear();
            tbilce.Clear();
        }
        Class1 c = new Class1();
        private void Form3_Load(object sender, EventArgs e)
        {
            c.baglantikur("Select *from tumkayitlar", "tumkayitlar");
            dataGridView1.DataSource = c.ds.Tables["tumkayitlar"];
            if (dataGridView1.Rows.Count < 0)
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible =false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                tbdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbalan.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbnot.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.baglantikur("Select *from tumkayitlar Where Tcno like'" + textBox1.Text + "%'", "tumkayitlar");
            dataGridView1.DataSource = c.ds.Tables["tumkayitlar"];
            label14.Visible =false;
            if (dataGridView1.Rows.Count == 0)
            {
                temizle();
                c.baglantikur("Select *from tumkayitlar Where Tcno like'" + textBox1.Text + "%'", "tumkayitlar");
                dataGridView1.DataSource = c.ds.Tables["tumkayitlar"];
                MessageBox.Show("Bu Tc numarası ile Kayıt Bulunamadı!.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
