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
    public partial class Peminjaman : Form
    {
        public Peminjaman()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select Judul_Buku from TBL_DataBuku", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBuku.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }


        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearchNama.Text != "")
            {
                String nama = txtSearchNama.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText="select * from TBL_Pengunjung where Kartu_Identitas = '" + nama + "' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);



                //------------------------------------------------------------------------
                //Code untuk membatasi peminjaman

                cmd.CommandText = "select count(kartu_iden) from DataPeminjaman where kartu_iden = '" + nama + "' and tanggal_pengembalian is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                //------------------------------------------------------------------------

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtNama.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtCard.Text = DS.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    txtNama.Clear();
                    MessageBox.Show("Kartu Identitas Tidak Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if(txtNama.Text != "")
            {
                if(comboBoxBuku.SelectedIndex != -1 && count <= 2)
                {
                    String cari = txtSearchNama.Text;
                    String pnama = txtNama.Text;
                    Int64 kartu = Int64.Parse(txtCard.Text);
                    String namabuku = comboBoxBuku.Text;
                    String tanggalpinjam = dateTimePicker.Text;

                    String nama = txtSearchNama.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into DataPeminjaman (nama_pgj,kartu_iden,nama_buku,tanggal_peminjaman) values ('" + pnama + "', " + kartu + ", '" + namabuku + "', '" + tanggalpinjam + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Selamat, Anda Berhasil Meminjam Buku","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pilih Buku. OR Maximum Peminjaman Telah Tercapai", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Masukan Kartu Peminjaman yang Valid", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtSearchNama_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchNama.Text == "")
            {
                txtNama.Clear();
                txtCard.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchNama.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
