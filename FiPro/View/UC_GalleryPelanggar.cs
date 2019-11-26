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
    public partial class UC_GalleryPelanggar : UserControl
    {
        private Entity.EntSiswa siswa;
        private Interface.intSiswa siswaDao;
        private DataTable tabel;

        public UC_GalleryPelanggar()
        {
            InitializeComponent();
            siswa = new Entity.EntSiswa();
            siswaDao = Factory.Factory.getSiswaDao();
            TampilDataSiswa();
        }

        private void UC_GalleryPelanggar_Load(object sender, EventArgs e)
        {
            
        }
        public void TampilDataSiswa()
        {
            tabel = new DataTable();
            tabel = siswaDao.DisplaySiswa();
            dgv.DataSource = tabel;

        }

        private void cmbPOINT_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(tabel);
            if(cmbPOINT.Text == "   100")
            {
                DV.RowFilter = string.Format("POINT >= 100");
            }
            else if(cmbPOINT.Text == "50 - 99")
            {
                DV.RowFilter = string.Format("POINT >= 50 and POINT <= 99");
            }
            else if (cmbPOINT.Text == "20 - 49")
            {
                DV.RowFilter = string.Format("POINT >= 20 and POINT <= 49");
            }
            else if (cmbPOINT.Text == "10 - 19")
            {
                DV.RowFilter = string.Format("POINT >= 10 and POINT <=19");
            }
            else if (cmbPOINT.Text == "  5 - 9")
            {
                DV.RowFilter = string.Format("POINT >= 5 and POINT <=9");
            }
            else if (cmbPOINT.Text == "  2 - 4")
            {
                DV.RowFilter = string.Format("POINT >= 2 and POINT <=4");
            }
            else if (cmbPOINT.Text == "     0")
            {
                DV.RowFilter = string.Format("POINT = 0");
            }
            else
            {
                DV.RowFilter = string.Format("POINT >= 0");
            }


                dgv.DataSource = DV;
        }
    }
}
