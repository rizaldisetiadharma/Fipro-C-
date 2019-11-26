using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FiPro.Interface
{
    interface intSiswa
    {
        string nisbaru();
        void OpenConnection();
        void CloseConnection();
        Boolean InsertSiswa(Entity.EntSiswa es);
        Boolean UpdateSiswa(Entity.EntSiswa es);
        Boolean UpdatePointSiswa(Entity.EntSiswa es, Entity.EntDaftarSanksi sk);
        Boolean DeleteSiswa(string nis);
        Boolean FindSiswa(string nis);
        DataTable DisplaySiswa();
    }
}
