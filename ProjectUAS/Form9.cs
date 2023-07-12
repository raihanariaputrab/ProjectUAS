using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS
{
    public partial class Form9 : Form
    {
        private string stringConnection = "data source = LAPTOP-CK57KRTO;" + "database=TokoGramedia;User ID=sa; Password=Mudah123";
        private SqlConnection koneksi;

        public Form9()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void IDBuku_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 fr = new Form13();
            fr.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridView();
            btnAdd.Enabled = false;
        }

        private void DataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.buku";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void DataGridView2()
        {
            koneksi.Open();
            string str = "select * from dbo.pembeli";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            koneksi.Close();
        }



        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView2();
            btnAdd.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
