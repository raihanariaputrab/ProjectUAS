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
    public partial class Form5 : Form
    {
        private string stringConnection = "data source=LAPTOP-CK57KRTO;" + "database=TokoGramedia;User ID=sa;Password=Mudah123";
        private SqlConnection koneksi;
        public Form5()
        {
            InitializeComponent();
            koneksi= new SqlConnection(stringConnection);
            refreshfrom();
        }

        public void refreshfrom()
        {
            txtAlamat.Text = "";
            txtIDKrywn.Text = "";
            txtNoHP.Text = "";
            txtAlamat.Enabled= false;
            txtIDKrywn.Enabled = false;
            txtNoHP.Enabled = false;
            btnSave.Enabled= false;
            btnClear.Enabled= false;
        }

        

        private void IDPembeli_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 fr = new Form12();
            fr.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
