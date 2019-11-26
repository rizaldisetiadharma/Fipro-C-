using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiPro.View
{
    public partial class UpdateSiswa : Form
    {
        private Entity.EntSiswa siswa;
        private Interface.intSiswa siswaDao;
        private Boolean hasil;


        public UpdateSiswa()
        {
            InitializeComponent();
            siswa = new Entity.EntSiswa();
            siswaDao = Factory.Factory.getSiswaDao();
            txt_POIN.Text = "0";
        }

        private void btn_BATAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdb_LAKI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_LAKI.Checked == true)
            {
                txtGender.Text = "L";
                txtGender.Show();
            }
        }

        private void rdb_PEREMPUAN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_PEREMPUAN.Checked == true)
            {
                txtGender.Text = "P";
                txtGender.Show();
            }
        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            siswa.setNIS(txt_NIS.Text);
            siswa.setNama(txt_NAMA.Text);
            siswa.setGender(txtGender.Text);
            siswa.setTemLahir(txt_TEMPATLAHIR.Text);
            siswa.setTglLahir(dtp_TGLLAHIR.Text);
            siswa.setAlamat(txt_ALAMAT.Text);
            siswa.setKelas(cmb_KELAS.Text);
            siswa.setPoint(Int16.Parse(txt_POIN.Text));

            hasil = siswaDao.UpdateSiswa(siswa);

            if (hasil == true)
            {
                MessageBox.Show("Data Berhasil Di Ubah");
            }
            else
            {
                MessageBox.Show("Pengubahan Data Gagal");
            }
        }
    }
}
