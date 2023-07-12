using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPembeli_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void btnKasir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuku_Click(object sender, EventArgs e)
        {

        }

        private void btnKasir_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnBuku_Click_1(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
