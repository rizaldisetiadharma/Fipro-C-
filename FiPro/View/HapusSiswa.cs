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
    public partial class HapusSiswa : Form
    {
        private Interface.intSiswa siswaDao;
        private Boolean hasil;
        private UC_Siswa ucsis;

        public HapusSiswa()
        {
            InitializeComponent();
            siswaDao = Factory.Factory.getSiswaDao();
        }

        private void btn_HAPUS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah Anda Yakin Menghapus Data Ini ? ", "Informasi");
            hasil = siswaDao.DeleteSiswa(txt_TAMBAHNIS.Text);

            if (hasil == true)
            {
                Sukses SK = new Sukses();
                SK.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Gagal");
            }

            ucsis = new UC_Siswa();
            ucsis.TampilDataSiswa();
            
        }

        private void btn_BATAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
