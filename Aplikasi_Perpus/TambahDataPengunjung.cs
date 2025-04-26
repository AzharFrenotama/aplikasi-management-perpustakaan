using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_Perpus
{
    public partial class TambahDataPengunjung : Form
    {
        public TambahDataPengunjung()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtNama.Clear();
            txtCard.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtNama.Text != "" && txtCard.Text != "")
            {
                Int64 id = Int64.Parse(txtid.Text);
                String nama = txtNama.Text;
                Int64 kartu = Int64.Parse(txtCard.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into TBL_Pengunjung (ID_Pengunjung,Nama_Pengunjung,Kartu_Identitas) values (" + id + ", '" + nama + "', " + kartu + ") ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tolong isi Kolom yang Kosong Terlebih Dahulu!","Suggest",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
