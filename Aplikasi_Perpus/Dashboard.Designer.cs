namespace Aplikasi_Perpus
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahDataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengunjungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahDataPengunjungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatDataPengunjungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukuToolStripMenuItem,
            this.pengunjungToolStripMenuItem,
            this.peminjamanToolStripMenuItem,
            this.pengembalianBukuToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bukuToolStripMenuItem
            // 
            this.bukuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahDataBukuToolStripMenuItem,
            this.lihatToolStripMenuItem});
            this.bukuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bukuToolStripMenuItem.Image")));
            this.bukuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bukuToolStripMenuItem.Name = "bukuToolStripMenuItem";
            this.bukuToolStripMenuItem.Size = new System.Drawing.Size(96, 54);
            this.bukuToolStripMenuItem.Text = "Buku";
            // 
            // tambahDataBukuToolStripMenuItem
            // 
            this.tambahDataBukuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tambahDataBukuToolStripMenuItem.Image")));
            this.tambahDataBukuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tambahDataBukuToolStripMenuItem.Name = "tambahDataBukuToolStripMenuItem";
            this.tambahDataBukuToolStripMenuItem.Size = new System.Drawing.Size(207, 56);
            this.tambahDataBukuToolStripMenuItem.Text = "Tambah Data Buku";
            this.tambahDataBukuToolStripMenuItem.Click += new System.EventHandler(this.tambahDataBukuToolStripMenuItem_Click);
            // 
            // lihatToolStripMenuItem
            // 
            this.lihatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lihatToolStripMenuItem.Image")));
            this.lihatToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lihatToolStripMenuItem.Name = "lihatToolStripMenuItem";
            this.lihatToolStripMenuItem.Size = new System.Drawing.Size(207, 56);
            this.lihatToolStripMenuItem.Text = "Lihat Data Buku";
            this.lihatToolStripMenuItem.Click += new System.EventHandler(this.lihatToolStripMenuItem_Click);
            // 
            // pengunjungToolStripMenuItem
            // 
            this.pengunjungToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.pengunjungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahDataPengunjungToolStripMenuItem,
            this.lihatDataPengunjungToolStripMenuItem});
            this.pengunjungToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pengunjungToolStripMenuItem.Image")));
            this.pengunjungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pengunjungToolStripMenuItem.Name = "pengunjungToolStripMenuItem";
            this.pengunjungToolStripMenuItem.Size = new System.Drawing.Size(134, 54);
            this.pengunjungToolStripMenuItem.Text = "Pengunjung";
            // 
            // tambahDataPengunjungToolStripMenuItem
            // 
            this.tambahDataPengunjungToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tambahDataPengunjungToolStripMenuItem.Image")));
            this.tambahDataPengunjungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tambahDataPengunjungToolStripMenuItem.Name = "tambahDataPengunjungToolStripMenuItem";
            this.tambahDataPengunjungToolStripMenuItem.Size = new System.Drawing.Size(245, 56);
            this.tambahDataPengunjungToolStripMenuItem.Text = "Tambah Data Pengunjung";
            this.tambahDataPengunjungToolStripMenuItem.Click += new System.EventHandler(this.tambahDataPengunjungToolStripMenuItem_Click);
            // 
            // lihatDataPengunjungToolStripMenuItem
            // 
            this.lihatDataPengunjungToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lihatDataPengunjungToolStripMenuItem.Image")));
            this.lihatDataPengunjungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lihatDataPengunjungToolStripMenuItem.Name = "lihatDataPengunjungToolStripMenuItem";
            this.lihatDataPengunjungToolStripMenuItem.Size = new System.Drawing.Size(245, 56);
            this.lihatDataPengunjungToolStripMenuItem.Text = "Lihat Data Pengunjung";
            this.lihatDataPengunjungToolStripMenuItem.Click += new System.EventHandler(this.lihatDataPengunjungToolStripMenuItem_Click);
            // 
            // peminjamanToolStripMenuItem
            // 
            this.peminjamanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peminjamanToolStripMenuItem.Image")));
            this.peminjamanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peminjamanToolStripMenuItem.Name = "peminjamanToolStripMenuItem";
            this.peminjamanToolStripMenuItem.Size = new System.Drawing.Size(136, 54);
            this.peminjamanToolStripMenuItem.Text = "Peminjaman";
            this.peminjamanToolStripMenuItem.Click += new System.EventHandler(this.peminjamanToolStripMenuItem_Click);
            // 
            // pengembalianBukuToolStripMenuItem
            // 
            this.pengembalianBukuToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.pengembalianBukuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pengembalianBukuToolStripMenuItem.Image")));
            this.pengembalianBukuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pengembalianBukuToolStripMenuItem.Name = "pengembalianBukuToolStripMenuItem";
            this.pengembalianBukuToolStripMenuItem.Size = new System.Drawing.Size(175, 54);
            this.pengembalianBukuToolStripMenuItem.Text = "Pengembalian Buku";
            this.pengembalianBukuToolStripMenuItem.Click += new System.EventHandler(this.pengembalianBukuToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
            this.laporanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("laporanToolStripMenuItem.Image")));
            this.laporanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(112, 54);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(88, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 505);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahDataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengunjungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahDataPengunjungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatDataPengunjungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianBukuToolStripMenuItem;
    }
}