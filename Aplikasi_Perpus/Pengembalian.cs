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
    public partial class Pengembalian : Form
    {
        public Pengembalian()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Int64 crd = Int64.Parse(txtSearchCard.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from DataPeminjaman where kartu_iden = " + crd + " and tanggal_pengembalian IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Kartu Identitas Invalid atau Tidak Ada Peminjaman","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtSearchCard.Clear();
        }

        String nmBuku;
        String tgl;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                nmBuku = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tgl = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            txtNamaBuku.Text = nmBuku;
            txtPeminjaman.Text = tgl;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Int64 crd = Int64.Parse(txtSearchCard.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = FREN; database = DB_PERPUS;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update DataPeminjaman set tanggal_pengembalian = '" + dateTimePicker1.Text + "' where kartu_iden = '" + crd + "' and id = "+rowid+"";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Pengembalian Berhasil","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Pengembalian_Load(this, null);
        }

        private void txtSearchCard_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchCard.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchCard.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
