using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FiPro
{

    public partial class UC_DataPelanggaran : UserControl
    {
        private Entity.EntSiswa siswa;
        private Entity.EntLogin login;
        private Entity.EntDaftarSanksi sanksi;
        private Interface.intSiswa siswaDao;
        private DataTable tabel;
        private Boolean hasil;
        private string txtSANKSI;
        private string nip;

        public void setNIP(string nip)
        {
            this.nip = nip;
        }


        public UC_DataPelanggaran()
        {
            InitializeComponent();
            sanksi = new Entity.EntDaftarSanksi();
            siswa = new Entity.EntSiswa();
            siswaDao = Factory.Factory.getSiswaDao();
            login = new Entity.EntLogin();
            TampilDataSiswa();
            textBox1.Text = login.getNIP();
        }

        private void btn_TambahPoint_Click(object sender, EventArgs e)
        {
            siswa.setNIS(txt_CARINIS.Text);
            sanksi.setKodeAturan(txtSANKSI);
            siswa.setPoint(Int16.Parse(txtPOINT.Text));

            hasil = siswaDao.UpdatePointSiswa(siswa,sanksi);

            if (hasil == true)
            {
                Sukses y = new Sukses();
                y.Show();
            }
            else
            {
                View.Gagal n = new View.Gagal();
                n.Show();
            }

        }

        private void UC_DataPelanggaran_Load(object sender, EventArgs e)
        {
        }

        public void TampilDataSiswa()
        {
            tabel = new DataTable();
            tabel = siswaDao.DisplaySiswa();         
            dgv.DataSource = tabel;
         
        }

        private void btn_RELOAD_Click(object sender, EventArgs e)
        {
            TampilDataSiswa();
        }

        private void txtPOINT_TextChanged(object sender, EventArgs e)
        {
        }

        private void rdb_1_CheckedChanged(object sender, EventArgs e)
        {

            txtSANKSI = "S001";
            txtPOINT.Text = "2";
            txtPOINT.Show();
        }

        private void rdb_2_CheckedChanged(object sender, EventArgs e)
        {
            txtSANKSI = "S002";
            txtPOINT.Text = "5";
            txtPOINT.Show();

        }

        private void rdb_3_CheckedChanged(object sender, EventArgs e)
        {
            txtSANKSI = "S003";
            txtPOINT.Text = "10";
            txtPOINT.Show();
        }

        private void rdb_4_CheckedChanged(object sender, EventArgs e)
        {
            txtSANKSI = "S004";
            txtPOINT.Text = "20";
            txtPOINT.Show();
        }

        private void rdb_5_CheckedChanged(object sender, EventArgs e)
        {
            txtSANKSI = "S005";
            txtPOINT.Text = "50";
            txtPOINT.Show();
        }

        private void rdb_6_CheckedChanged(object sender, EventArgs e)
        {
            txtSANKSI = "S006";
            txtPOINT.Text = "100";
            txtPOINT.Show();
        }

        private void txt_CARINIS_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(tabel);
            DV.RowFilter = string.Format("NIS LIKE '%{0}%'", txt_CARINIS.Text);
            dgv.DataSource = DV;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(login.getNIP() == "00000001")
            {
                textBox1.Text = "00000001";
            }
        }
    }
}
