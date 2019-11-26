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
    public partial class Yakin : Form
    {
        public Yakin()
        {
            InitializeComponent();
        }

        private void btn_IYA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_TIDAK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
