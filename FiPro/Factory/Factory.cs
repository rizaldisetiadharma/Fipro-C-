using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiPro.Factory
{
    class Factory
    {
        private static Interface.intSiswa SiswaDao;
        private static Interface.intDaftarSanksi SanksiDao;

        public static Interface.intSiswa getSiswaDao()
        {
              SiswaDao = new Implement.impSiswa();
              return SiswaDao;
        }

        public static Interface.intDaftarSanksi getSanksiDao()
        {
            SanksiDao = new Implement.impDaftarSanksi();
            return SanksiDao;
        }

     }
   
}
