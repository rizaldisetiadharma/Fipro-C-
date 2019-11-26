using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FiPro.Interface
{
    interface intDaftarSanksi
    {
        string kodeBaru();
        void OpenConnection();
        void CloseConnection();
        Boolean InsertSanksi(Entity.EntDaftarSanksi es);
        Boolean UpdateSanksi(Entity.EntDaftarSanksi es);
        Boolean DeleteSanksi(string KodeAturan);
        DataTable DisplaySanksi();
    }
}
