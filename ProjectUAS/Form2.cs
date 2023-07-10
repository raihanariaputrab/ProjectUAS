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
        string connectionString = "data source = LAPTOP-CK57KRTO;database=TokoGramedia;MultipleActiveResultSets=True;User ID = sa; Password = Mudah123";
        private SqlConnection koneksi;
        private string idPembeli, namapembeli, idBuku;
        BindingSource customerBindingsSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDPembeli.Text = "";
            txtNamaPembeli.Text = "";
            txtIDBuku.Text = "";
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            namapembeli = txtNamaPembeli.Text;
            idPembeli = txtIDPembeli.Text;
            idBuku = txtIDBuku.Text;
            int hs = 0;
            koneksi.Open();
            string strs = "select id_buku from dbo.pembeli where id_buku = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", idBuku));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = int.Parse(dr["idBuku"].ToString());
            }
            dr.Close();
            string str = "insert into dbo.pembeli (namapembeli, idPembeli, idBuku)" + "values(@namapembeli, @idPembeli, @idBuku )";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("NamaPembeli", namapembeli));
            cmd.Parameters.Add(new SqlParameter("IDPembeli", idPembeli));
            cmd.Parameters.Add(new SqlParameter("IDBuku", idBuku));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }

        BindingSource customerBindingSource = new BindingSource();
    

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 fr = new Form11();
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
            btnClear.Enabled = false;
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

        private void form2()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("select m.idPembeli, m.NamaPembeli," +
                "m.idPembeli, n.NamaPembeli, m.idBuku" +
                "join dbo.pembeli p on m.idBuku = p.idBuku", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtIDPembeli.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_pembeli", true));
            this.txtNamaPembeli.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_pembeli", true));
            this.txtIDBuku.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "id_buku", true));
            koneksi.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
