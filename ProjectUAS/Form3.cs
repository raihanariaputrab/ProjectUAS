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
        string connectionString = "data source = LAPTOP-CK57KRTO;database=TokoGramedia;MultipleActiveResultSets=True;User ID = sa; Password = Mudah123";
        private SqlConnection koneksi;
        public Form3()
        {
            InitializeComponent();
        }

        private void refreshform()
        {
            txtNamaPembeli.Enabled = false;
            txtNamaPengarang.Enabled = false;
            txtHargaBuku.Enabled = false;
            txtNamaPembeli.SelectedIndex = -1;
            txtNamaPengarang.SelectedIndex = -1;
            txtHargaBuku.SelectedIndex = -1;
            txtIDBuku.Visible = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = true;

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.data_pembeli";
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

        private void cbNamaPembeli()
        {
            koneksi.Open();
            string str = "select nama_pembeli from dbo.pembeli where " +
                "not EXISTS(select id_status from dbo.status_pembeli where " +
                "status_pembeli.idBuku = mahasiswa.idBuku)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            txtNamaPembeli.DisplayMember = "nama_mahasiswa";
            txtNamaPembeli.ValueMember = "Nim";
            txtNamaPembeli.DataSource = ds.Tables[0];
        }

        private void cbHarga()
        {
            int y = DateTime.Now.Year - 2010;
            string[] type = new string[y];
            int i = 0;
            for (i = 0; i < type.Length; i++)
            {
                if (i == 0)
                {
                    txtHargaBuku.Items.Add("2010");
                }
                else
                {
                    int l = 2010 + i;
                    txtHargaBuku.Items.Add(l.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNamaPembeli.Enabled = true;
            txtNamaPengarang.Enabled = true;
            txtHargaBuku.Enabled = true;
            txtIDBuku.Visible = true;
            cbHarga();
            cbNamaPembeli();
            btnClear.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
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

            string str = "select count (*) from dbo.nama_pembeli";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();

            if (count == 0)
            {
                kodestatus = "1";
            }
            else
            {
                string querryString = "select max(id_status) from dbo.nama_pembeli";
                SqlCommand cmStatusMahasiswaSum = new SqlCommand(str, koneksi);
                int totalStatusMahasiswa = (int)cmStatusMahasiswaSum.ExecuteScalar();
                int finalkodestatusint = totalStatusMahasiswa + 1;
                kodestatus = Convert.ToString(finalkodestatusint);
            }
            string queryString = "insert into dbo.status_mahasiswa (nama_pembeli, id_buku, " +
                "nama_pengarang, harga_buku)" + "values(@ids, @idB, @np, @hb)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ids", kodestatus));
            cmd.Parameters.Add(new SqlParameter("idB", idBuku));
            cmd.Parameters.Add(new SqlParameter("np", NamaPengarang));
            cmd.Parameters.Add(new SqlParameter("hb", HargaBuku));
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
