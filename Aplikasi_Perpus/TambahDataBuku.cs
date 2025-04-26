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
    public partial class TambahDataBuku : Form
    {
        public TambahDataBuku()
        {
            InitializeComponent();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (txtidbuku.Text != "" && txtjudul.Text != "" && txtgenre.Text != "" && txtpenulis.Text != "" && txttahun.Text != "" && txtstok.Text != "")
            {

                Int64 ID_buku = Int64.Parse(txtidbuku.Text);
                String judul_buku = txtjudul.Text;
                String genre_buku = txtgenre.Text;
                String penulis = txtpenulis.Text;
                String tahun_terbit = txttahun.Text;
                Int64 stok_buku = Int64.Parse(txtstok.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into TBL_DataBuku (ID_Buku,Judul_Buku,Genre_Buku,Penulis,Tahun_Terbit,Stok_Buku) values (" + ID_buku + ",'" + judul_buku + "','" + genre_buku + "','" + penulis + "','" + tahun_terbit + "'," + stok_buku + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidbuku.Clear();
                txtjudul.Clear();
                txtgenre.Clear();
                txtpenulis.Clear();
                txttahun.Clear();
                txtstok.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tindakan ini akan MENGHAPUS Data yang Belum Tersimpan", "Apakah Anda Yakin?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
