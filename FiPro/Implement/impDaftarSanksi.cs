using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FiPro.Implement
{
    class impDaftarSanksi : Interface.intDaftarSanksi
    {
        private string query;
        private Boolean status;
        private SqlConnection koneksi;
        private SqlCommand command;
        private SqlDataReader reader;

        public impDaftarSanksi()
        {
            koneksi = KoneksiDB.KoneksiDaftarSanksi.getKoneksi();
        }

        public void OpenConnection()
        {
            if (koneksi.State == ConnectionState.Closed)
            {
                koneksi.Open();
            }
        }

        public void CloseConnection()
        {
            if (koneksi.State == ConnectionState.Open)
            {
                koneksi.Close();
            }
        }

        public string kodeBaru()
        {
            int kode = 0;
            string kodeBaru = "";

            try
            {
                query = "SELECT MAX(RIGHT(NIS, 2)) from DaftarSanksi";

                OpenConnection();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    kode = Int16.Parse(reader.GetString(0).ToString());
                    if (kode < 10)
                    {
                        kodeBaru = "S00" + (kode + 1);
                    }
                    else
                    {
                        kodeBaru = "S0" + (kode + 1);
                    }
                }

            }
            catch (SqlException se)
            {
                Console.WriteLine("Error" + se);
            }
            finally
            {
                CloseConnection();
            }
            return kodeBaru;

        }

        public Boolean InsertSanksi(Entity.EntDaftarSanksi es)
        {
            status = false;
            try
            {
                query = "insert into DaftarSanksi values ('" + es.getKodeAturan() +
                    "','" + es.getNamaAturan() + "','" + es.getPoint() +
                    "','" + es.getSanksi() + "')";

                OpenConnection();

                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;

            }
            catch (SqlException se)
            {
                Console.WriteLine("Error" + se);
            }
            finally
            {
                CloseConnection();
            }

            return status;

        }

        public Boolean UpdateSanksi(Entity.EntDaftarSanksi es)
        {
            status = false;
            try
            {
                query = "Update DaftarSanksi set Kode Aturan = '" + es.getKodeAturan() + "', NamaAturan = '" + es.getNamaAturan() +
                    "', Point ='" + es.getPoint() + "', Sanksi = '" + es.getSanksi() +"'";

                OpenConnection();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error" + se);
            }
            finally
            {
                CloseConnection();
            }

            return status;

        }

        public Boolean DeleteSanksi(string KodeAturan)
        {
            status = false;
            try
            {
                query = "delete DaftarSanksi where Kode Aturan = '" + KodeAturan + "'";

                OpenConnection();

                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error" + se);
            }
            finally
            {
                CloseConnection();
            }

            return status;
        }

        public DataTable DisplaySanksi()
        {
            DataTable tabel1 = new DataTable();
            try
            {
                query = "SELECT [Kode Aturan] as 'Kode Aturan', NamaAturan as 'NamaAturan', Point as 'Point', Sanksi as 'Sanksi' from DaftarSanksi";

                OpenConnection();
                command = new SqlCommand(query, koneksi);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(tabel1);

            }
            catch (SqlException)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                CloseConnection();
            }

            return tabel1;
        }
    }
}
