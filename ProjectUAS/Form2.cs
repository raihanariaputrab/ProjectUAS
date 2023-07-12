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
    public partial class Form2 : Form
    {
        private string stringConnection = "data source = LAPTOP-CK57KRTO;" + "database=TokoGramedia;User ID=sa; Password=Mudah123";
        private SqlConnection koneksi;
        private string nama_pembeli, id_Pembeli, id_Buku;
      

        public Form2()
        {
            InitializeComponent();
            koneksi= new SqlConnection(stringConnection);
            refreshform();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDPembeli.Text = "";
            txtNamaPembeli.Text = "";
            txtIDBuku.Text = "";
            txtIDPembeli.Enabled= true;
            txtNamaPembeli.Enabled = true;
            txtIDBuku.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nama_pembeli = txtNamaPembeli.Text;
            id_Pembeli = txtIDPembeli.Text;
            id_Buku = txtIDBuku.Text;

            koneksi.Open();
            string str = "insert into dbo.pembeli (nama_pembeli, id_pembeli, id_buku)" + "values(@nama_pembeli, @id_pembeli, @id_buku)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("nama_pembeli", nama_pembeli));
            cmd.Parameters.Add(new SqlParameter("id_pembeli", id_Pembeli));
            cmd.Parameters.Add(new SqlParameter("id_buku", id_Buku));

            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }

    
    

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 fr = new Form13();
            fr.Show();
            this.Hide();
        }

        private void refreshform()
        {
            txtIDBuku.Enabled = false;
            txtIDPembeli.Enabled = false;
            txtNamaPembeli.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            clearBinding();
            form2();
        }

        private void clearBinding()
        {
            this.txtIDBuku.DataBindings.Clear();
            this.txtIDPembeli.DataBindings.Clear();
            this.txtNamaPembeli.DataBindings.Clear();
        }

        private void txtIDPembeli_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form2()
        {
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
