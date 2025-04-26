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
    public partial class LihatDataBuku : Form
    {
        public LihatDataBuku()
        {
            InitializeComponent();
        }

        private void LihatDataBuku_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString= "data source = FREN; database = DB_PERPUS;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from TBL_DataBuku";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int ID_Buku;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                ID_Buku = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible=true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from TBL_DataBuku where ID_Buku= "+ID_Buku+"";  
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtJdl.Text = ds.Tables[0].Rows[0][1].ToString();
            txtGenre.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPenulis.Text = ds.Tables[0].Rows[0][3].ToString();
            txtThn.Text = ds.Tables[0].Rows[0][4].ToString();
            txtStok.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible= false;
        }

        private void txtNamaBuku_TextChanged(object sender, EventArgs e)
        {
            if(txtNamaBuku.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from TBL_DataBuku where Judul_Buku LIKE '"+txtNamaBuku.Text+ "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from TBL_DataBuku";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNamaBuku.Clear();
            panel2.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confrim?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String judul_buku = txtJdl.Text;
                String genre_buku = txtGenre.Text;
                String penulis = txtPenulis.Text;
                String tahun_terbit = txtThn.Text;
                Int64 stok_buku = Int64.Parse(txtStok.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update TBL_DataBuku set Judul_Buku = '" + judul_buku + "', Genre_Buku = '" + genre_buku + "', Penulis = '" + penulis + "', Tahun_Terbit = '" + tahun_terbit + "', Stok_Buku = " + stok_buku + "  where ID_Buku=" + rowid + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Deleted. Confrim?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from TBL_DataBuku where ID_Buku=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
