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
    public partial class Form3 : Form
    {
        private string stringConnection = "data source = LAPTOP-CK57KRTO;" + "database=TokoGramedia;User ID=sa; Password=Mudah123";
        private SqlConnection koneksi;

        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtNamaPembeli.Enabled = false;
            txtNamaPengarang.Enabled = false;
            txtHargaBuku.Enabled = false;
            txtIDBuku.Visible = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;

        }

        private void dataGridview1_CellContentClick(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.buku";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 fr = new Form11();
            fr.Show();
            this.Hide();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void txtNamaPembeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string id = "";
            string strs = "select ID from dbo.Pembeli where nama_pembeli = @nm";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@nm", txtNamaPembeli.Text));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                id = dr["ID"].ToString();
            }
            dr.Close();
            koneksi.Close();

            txtIDBuku.Text = id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNamaPembeli.Enabled = true;
            txtNamaPengarang.Enabled = true;
            txtHargaBuku.Enabled = true;
            txtIDBuku.Visible = true;
            btnClear.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string idBuku = txtIDBuku.Text;
            string NamaPengarang = txtNamaPengarang.Text;
            string HargaBuku = txtHargaBuku.Text;
            int count = 0;
            string tempkodestatus = "";
            string kodestatus = "";
            koneksi.Open();

            string str = "select count (*) from dbo.buku";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();

            if (count == 0)
            {
                kodestatus = "1";
            }
            else
            {
                string querryString = "select from dbo.buku";
                SqlCommand cmStatusMahasiswaSum = new SqlCommand(str, koneksi);
                int totalStatusMahasiswa = (int)cmStatusMahasiswaSum.ExecuteScalar();
                int finalkodestatusint = totalStatusMahasiswa + 1;
                kodestatus = Convert.ToString(finalkodestatusint);
            }
            string queryString = "insert into dbo.buku (id_buku, nama_pengarang, harga)" + "values(@ids, @idB, @np)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ids", idBuku));
            cmd.Parameters.Add(new SqlParameter("idB", NamaPengarang));
            cmd.Parameters.Add(new SqlParameter("np", HargaBuku));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            refreshform();
            dataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
