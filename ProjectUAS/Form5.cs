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
        private string stringConnection = "data source = LAPTOP-CK57KRTO;" + "database=TokoGramedia;User ID=sa; Password=Mudah123";
        private SqlConnection koneksi;
        private string id_karyawan,no_hp,alamat;
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
            btnDelete.Enabled= false;
        }

        

        private void IDPembeli_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDKrywn.Text = "";
            txtNoHP.Text = "";
            txtAlamat.Text = "";
            txtIDKrywn.Enabled = true;
            txtNoHP.Enabled = true;
            txtAlamat.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string id_Karyawan = txtIDKrywn.Text;
            string no_hp = txtNoHP.Text;
            string alamat = txtAlamat.Text;
            int count = 0;
            string tempkodestatus = "";
            string kodestatus = "";
            koneksi.Open();

            string str = "select count (*) from dbo.karyawan";
            SqlCommand cm = new SqlCommand(str, koneksi);
            count = (int)cm.ExecuteScalar();

            if (count == 0)
            {
                kodestatus = "1";
            }
            else
            {
                string querryString = "select from dbo.karyawan";
                SqlCommand cmStatusMahasiswaSum = new SqlCommand(str, koneksi);
                int totalStatusMahasiswa = (int)cmStatusMahasiswaSum.ExecuteScalar();
                int finalkodestatusint = totalStatusMahasiswa + 1;
                kodestatus = Convert.ToString(finalkodestatusint);
            }
            string queryString = "insert into dbo.karyawan (id_karyawan, no_hp, alamat)" + "values(@idk, @nhp, @almt)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("idk", id_Karyawan));
            cmd.Parameters.Add(new SqlParameter("nhp", no_hp));
            cmd.Parameters.Add(new SqlParameter("almt", alamat));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            refreshform();
            dataGridView();
        }

        private void refreshform()
        {
            txtIDKrywn.Enabled = false;
            txtNoHP.Enabled = false;
            txtAlamat.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 fr = new Form12();
            fr.Show();
            this.Hide();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnRead.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dlt = "DELETE FROM karyawan WHERE id_karyawan = @id_karyawan";
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(dlt, conn))
                {
                    cmd.Parameters.AddWithValue("id_karyawan", txtIDKrywn.Text);
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        dataGridView();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An Error Occurred: " + ex.Message + ("Error Code: " + ex.Number));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An Error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string upd = "UPDATE karyawan SET id_karyawan = @id_karyawan, no_hp = @no_hp, alamat = @alamat where id_karyawan = @id_karyawan";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(upd, conn))
                {
                    cmd.Parameters.AddWithValue("id_karyawan", txtIDKrywn.Text);
                    cmd.Parameters.AddWithValue("no_hp", txtNoHP.Text);
                    cmd.Parameters.AddWithValue("alamat", txtAlamat.Text);
                    

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil di Updated");
                        dataGridView();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occured: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.karyawan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }



        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
