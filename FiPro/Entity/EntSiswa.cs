using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiPro.Entity
{
    class EntSiswa
    {
        private string NIS;
        private string nama;
        private string gender;
        private string alamat;
        private string tempatlahir;
        private string tanggallahir;
        private string kelas;
        private int point;

        public void setNIS(string NIS)
        {
            this.NIS = NIS;
        }

        public void setNama(string nama )
        {
            this.nama = nama ;
        }
        public void setGender(string gender)
        {
            this.gender = gender ;
        }
        public void setAlamat(string alamat)
        {
            this.alamat = alamat;
        }
        public void setTemLahir(string tempatlahir)
        {
            this.tempatlahir = tempatlahir;
        }
        public void setTglLahir(string tanggallahir)
        {
            this.tanggallahir = tanggallahir;
        }
        public void setKelas(string kelas)
        {
            this.kelas = kelas;
        }
        public void setPoint(int point)
        {
            this.point = point;
        }



        public string getNIS()
        {
            return NIS;
        }

        public string getNama()
        {
            return nama;
        }

        public string getGender()
        {
            return gender;
        }

        public string getAlamat()
        {
            return alamat;
        }
        public string getTemLahir()
        {
            return tempatlahir;
        }
        public string getTglLahir()
        {
            return tanggallahir;
        }
        public string getKelas()
        {
            return kelas;
        }
        public int getPoint()
        {
            return point;
        }

    }
}
