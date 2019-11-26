using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiPro
{
    public partial class UC_Siswa : UserControl
    {
        private Entity.EntSiswa siswa;
        private Interface.intSiswa siswaDao;
        private DataTable tabel;
        private Boolean hasil;

        public UC_Siswa()
        {
            InitializeComponent();
            siswa = new Entity.EntSiswa();
            siswaDao = Factory.Factory.getSiswaDao();
            TampilDataSiswa();

        }

        private void btn_TAMBAH_Click(object sender, EventArgs e)
        {
            TambahSiswa Tmb = new TambahSiswa();
            Tmb.Show();
        }

        private void btn_KURANG_Click(object sender, EventArgs e)
        {
            HapusSiswa Hps = new HapusSiswa();
            Hps.Show();
        }

        private void UC_Siswa_Load(object sender, EventArgs e)
        {

        }
        public void TampilDataSiswa()
        {
            tabel = new DataTable();
            tabel = siswaDao.DisplaySiswa();
            dgv.DataSource = tabel;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            TampilDataSiswa();
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            hasil = siswaDao.FindSiswa(txt_CARINIS.Text);

            if (hasil == true)
            {
                TampilDataSiswa(); 
            }

            else
            {
                MessageBox.Show("Gagal");
            }

        }

        private void btn_EDITSISWA_Click(object sender, EventArgs e)
        {
            View.UpdateSiswa UPD = new View.UpdateSiswa();
            UPD.Show();
        }

        private void txt_CARINIS_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(tabel);
            DV.RowFilter = string.Format("NIS LIKE '%{0}%'", txt_CARINIS.Text);
            dgv.DataSource = DV;
        }
    }
}
