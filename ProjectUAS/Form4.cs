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
    
    public partial class Form4 : Form
    {
        string connectionString = "data source = LAPTOP-CK57KRTO;database=TokoGramedia;MultipleActiveResultSets=True;User ID = sa; Password = Mudah123";
        private SqlConnection koneksi;
        public Form4()
        {
            InitializeComponent();
            koneksi = new SqlConnection(connectionString);
            refreshform();
        }

        private void refreshform()
        {
            txtIDKasir.Text = "";
            txtNoHP.Text = "";
            txtAlamat.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtIDKasir.Enabled = false;
            txtNoHP.Enabled = false;
            txtAlamat.Enabled = false;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            txtIDKasir.Enabled = false;
            txtIDKasir.Text = "";
            txtNoHP.Text = "";
            txtAlamat.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_kasir, id_kasir from dbo.kasir";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 fr = new Form11();
            fr.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idKasir = txtIDKasir.Text;
            string Almt = txtAlamat.Text;
            string noHP = txtNoHP.Text;
            string Us = txtUsername.Text;
            string Ps = txtPassword.Text;

            if (idKasir == "")
            {
                MessageBox.Show("masukan id kasir", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.TokoGramedia (id_kasir, alamat, no_hp, username, password)" + "values(@id, @almt, @nh, @us, @ps)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", idKasir));
                cmd.Parameters.Add(new SqlParameter("almt", Almt));
                cmd.Parameters.Add(new SqlParameter("nh", noHP));
                cmd.Parameters.Add(new SqlParameter("us", Us));
                cmd.Parameters.Add(new SqlParameter("ps", Ps));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil disimpan", "sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDKasir.Enabled = true;
            txtNoHP.Enabled = true;
            txtPassword.Enabled = true;
            txtAlamat.Enabled = true;
            txtUsername.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;

        }

        private void txtIDKasir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}