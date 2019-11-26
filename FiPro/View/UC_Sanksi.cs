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
    public partial class UC_Sanksi : UserControl
    {
        private Entity.EntDaftarSanksi sanksi;
        private Interface.intDaftarSanksi sanksiDao;
        private DataTable tabel;

        public UC_Sanksi()
        {
            InitializeComponent();
            sanksi = new Entity.EntDaftarSanksi();
            sanksiDao = Factory.Factory.getSanksiDao();
            TampilDataSanksi();
        }

        public void TampilDataSanksi()
        {
            tabel = new DataTable();
            tabel = sanksiDao.DisplaySanksi();
            dgvSanksi.DataSource = tabel;
        }

        private void btn_RELOAD_Click(object sender, EventArgs e)
        {
            TampilDataSanksi();
        }
    }
}
