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
    public partial class YakinLogout : Form
    {
        public YakinLogout()
        {
            InitializeComponent();
        }

        private void btn_IYA_Click(object sender, EventArgs e)
        {
            Beranda BR = new Beranda();
            BR.Dispose();

            Login LG = new Login();
            LG.Show();
            this.Hide();        
        }

        private void btn_TIDAK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
