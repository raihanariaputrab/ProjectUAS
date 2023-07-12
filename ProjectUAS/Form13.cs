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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void pembeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fe = new Form2();
            fe.Show();
            this.Hide();
        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fe = new Form4();
            fe.Show();
            this.Hide();
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fe = new Form3();
            fe.Show();
            this.Hide();
        }

        private void lihatTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 fe = new Form9();
            fe.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
