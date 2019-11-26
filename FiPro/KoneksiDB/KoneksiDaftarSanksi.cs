using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FiPro.KoneksiDB
{
    class KoneksiDaftarSanksi
    {
        public static SqlConnection getKoneksi()
        {
            string strCon = "Data Source=DESKTOP-EJN5ODD;Initial Catalog=Fipro;Integrated Security=True";

            return new SqlConnection(strCon);
        }
    }
}
