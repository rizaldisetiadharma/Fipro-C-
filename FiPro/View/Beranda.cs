using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiPro
{
    public partial class Beranda : Form
    {
        public Beranda()
        {
            InitializeComponent();
            SlidePanel.Height = btn_BERANDA.Height;
            SlidePanel.Top = btn_BERANDA.Top;
            uC_Beranda1.BringToFront();
        }

        private void btn_Minimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_CLOSE_Click_1(object sender, EventArgs e)
        {
            Yakin YK = new Yakin();
            YK.Show();
        }


        private void btn_BERANDA_Click_1(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_BERANDA.Height;
            SlidePanel.Top = btn_BERANDA.Top;
            uC_Beranda1.BringToFront();
            
        }

        private void btn_DataPelanggaran_Click_1(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_DataPelanggaran.Height;
            SlidePanel.Top = btn_DataPelanggaran.Top;
            uC_DataPelanggaran1.BringToFront();
            uC_DataPelanggaran1.TampilDataSiswa();
        }

        private void btn_Siswa_Click_1(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_Siswa.Height;
            SlidePanel.Top = btn_Siswa.Top;
            uC_Siswa1.BringToFront();
            uC_Siswa1.TampilDataSiswa();
        }

        private void btn_GalleryPelanggar_Click_1(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_GalleryPelanggar.Height;
            SlidePanel.Top = btn_GalleryPelanggar.Top;
            uC_GalleryPelanggar1.BringToFront();
            uC_GalleryPelanggar1.TampilDataSiswa();
        }

        private void btn_Peraturan_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_Peraturan.Height;
            SlidePanel.Top = btn_Peraturan.Top;
            uC_Peraturan1.BringToFront();
        }

        private void btn_SANKSI_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_SANKSI.Height;
            SlidePanel.Top = btn_SANKSI.Top;
            uC_Sanksi1.BringToFront();
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = btn_PDF.Height;
            SlidePanel.Top = btn_PDF.Top;
            uC_SimpanPDF1.BringToFront();
            uC_SimpanPDF1.TampilDataSiswa();
        }

        private void btn_KELUAR1_Click(object sender, EventArgs e)
        {
            Login LG = new Login();
            LG.Show();
            this.Hide();
        }
    }
    
}
