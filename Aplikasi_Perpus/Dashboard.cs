using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Perpus
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah Anda Ingin Keluar dari Aplikasi ini?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tambahDataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahDataBuku abs = new TambahDataBuku();
            abs.Show();
        }

        private void lihatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LihatDataBuku vb = new LihatDataBuku();
            vb.Show();
        }

        private void tambahDataPengunjungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahDataPengunjung tdp = new TambahDataPengunjung();
            tdp.Show();
        }

        private void lihatDataPengunjungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LihatDataPengunjung ldp = new LihatDataPengunjung();
            ldp.Show();
        }

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peminjaman pjm = new Peminjaman();
            pjm.Show();
        }

        private void pengembalianBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pengembalian pgm = new Pengembalian();
            pgm.Show();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laporan lpr = new Laporan();
            lpr.Show();
        }
    }
}
