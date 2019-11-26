using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FiPro.Entity;

namespace FiPro.Implement
{
    class impLogin : Interface.intLogin
    {
        private string query;
        private Boolean status;
        private SqlConnection koneksi;

        public impLogin()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public Boolean Login(Entity.EntLogin e)
        {
            query = "SELECT NIP, Pwd FROM Guru WHERE NIP = '" + e.getNIP() + "'AND Pwd = '" + e.getPwd()+"'";


            koneksi.Open();

            SqlCommand command = koneksi.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                if((reader.GetString(0).ToString() == e.getNIP())
                    && (reader.GetString(1).ToString() == e.getPwd()))
                {
                    status = true;

                }
                else
                {
                    status = false;
                }
            }
            koneksi.Close();
            return status;
            
        }

        



        
    }
}
