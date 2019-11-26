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


namespace FiPro
{
    public partial class TambahSiswa : Form
    {
        private Entity.EntSiswa siswa;
        private Interface.intSiswa siswaDao;
        private Boolean hasil;


        public TambahSiswa()
        {
            siswa = new Entity.EntSiswa();
            siswaDao = Factory.Factory.getSiswaDao();
            InitializeComponent();

            txt_NIS.Text = siswaDao.nisbaru();
            txt_POIN.Text = "0";       

        }


        private void btn_BATAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdb_LAKI_CheckedChanged(object sender, EventArgs e)
        {

                txtGender.Text = "L";
                txtGender.Show();

        }

        private void rdb_PEREMPUAN_CheckedChanged(object sender, EventArgs e)
        {
                txtGender.Text = "P";
                txtGender.Show();

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

            hasil = siswaDao.InsertSiswa(siswa);

            if(hasil == true)
            {
                MessageBox.Show("Data Berhasil Disimpan");
            }
            else
            {
                MessageBox.Show("Penyimpanan Data Gagal");
            }

        }
    }
}
