using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiPro.Entity
{
    class EntDaftarSanksi
    {
        private string KodeAturan;
        private string NamaAturan;
        private int Point;
        private string Sanksi;

        public void setKodeAturan(string KodeAturan)
        {
            this.KodeAturan = KodeAturan;
        }

        public void setNamaAturan(string NamaAturan)
        {
            this.NamaAturan = NamaAturan;
        }

        public void setPoint(int Point)
        {
            this.Point = Point;
        }

        public void setSanksi(string Sanksi)
        {
            this.Sanksi = Sanksi;
        }

        public string getKodeAturan()
        {
            return KodeAturan;
        }

        public string getNamaAturan()
        {
            return NamaAturan;
        }

        public int getPoint()
        {
            return Point;
        }

        public string getSanksi()
        {
            return Sanksi;
        }

    }
}
