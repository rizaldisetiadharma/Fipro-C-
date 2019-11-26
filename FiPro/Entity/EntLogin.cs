using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiPro.Entity
{
    class EntLogin
    {
        private string nip;
        private string pwd;

        public void setNIP(string nip)
        {
            this.nip = nip;
        }
        public void setPwd(string pwd)
        {
            this.pwd = pwd;
        }
        public string getNIP()
        {
            return nip;
        }
        public string getPwd()
        {
            return pwd;
        }
    }
}
