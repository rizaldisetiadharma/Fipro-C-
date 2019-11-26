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
    public partial class Login : Form
    {
        private Boolean status;
        private Entity.EntLogin login;
        private Implement.impLogin impLogin;


        public Login()
        {
           
            impLogin = new Implement.impLogin();
            login = new Entity.EntLogin();
            InitializeComponent();
        }

        private void btn_LOGIN_Click(object sender, EventArgs e)
        {
          
                login.setNIP(txt_USERNAME1.Text);
                login.setPwd(txt_PWD1.Text);

                status = impLogin.Login(login);

                if(status == true)
                {
                Beranda Bobj = new Beranda();
                Bobj.Show();

                this.Hide();

                
                }
                else
                {
                Pastikan PST = new Pastikan();
                PST.Show();
                txt_USERNAME1.Text = "";
                txt_PWD1.Text = "";
                txt_USERNAME1.Focus();
                }

                   
        }
        public string cobacoba()
        {
            return txt_USERNAME1.Text;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Yakin YK = new Yakin();
            YK.Show();
        }

    }
}
