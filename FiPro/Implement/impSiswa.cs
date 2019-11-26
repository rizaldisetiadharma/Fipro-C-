using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FiPro.Implement
{
    class impSiswa : Interface.intSiswa
    {
        private string query,point;
        private Boolean status;
        private SqlConnection koneksi;
        private SqlCommand command;
        private SqlDataReader reader;

        public impSiswa()
        {
            koneksi = KoneksiDB.KoneksiSiswa.getKoneksi();
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

        public string nisbaru()
        {
            int nis = 0;
            string nisBaru = "";

            try
            {
                query = "SELECT MAX(RIGHT(NIS, 2)) from siswa";

                OpenConnection();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nis = Int16.Parse(reader.GetString(0).ToString());
                    if (nis < 10)
                    {
                        nisBaru = "000" + (nis + 1);
                    }
                    else
                    {
                        nisBaru = "00" + (nis + 1);
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
            return nisBaru;
            
        }

        public Boolean InsertSiswa(Entity.EntSiswa es)
        {
            status = false;
            try
            {
                query = "insert into Siswa values ('" + es.getNIS() +
                    "','" + es.getNama() + "','" + es.getGender() +
                    "','" + es.getTemLahir() + "','" + es.getTglLahir() +
                    "','" + es.getAlamat() + "','" + es.getKelas() +
                    "','" + es.getPoint() + "')";

                OpenConnection();

                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                
            }
            catch(SqlException se)
            {
                Console.WriteLine("Error" + se);
            }
            finally
            {
                CloseConnection();
            }

            return status;

        }

        public Boolean UpdateSiswa(Entity.EntSiswa es)
        {
            status = false;
            try
            {
                query = "Update Siswa set NamaSiswa = '" + es.getNama() + "', Gender = '" + es.getGender() +
                    "', TempatLahir ='" + es.getTemLahir() + "', TanggalLahir = '" + es.getTglLahir() +
                    "', Alamat ='" + es.getAlamat() + "',Kelas = '" + es.getKelas() +
                    "',Point = '" + es.getPoint() + "' where NIS = '" + es.getNIS() + "'";

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

        public Boolean UpdatePointSiswa(Entity.EntSiswa es, Entity.EntDaftarSanksi ek)
        {
            status = false;
            try
            {
                point = "update siswa set Point = point + (select point from DaftarSanksi where [Kode Aturan] = '" + ek.getKodeAturan() + "' ) where nis = '" + es.getNIS() + "'";
                OpenConnection();
                command = koneksi.CreateCommand();
                command.CommandText = point;
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
    
        public Boolean DeleteSiswa(string nis)
        {
            status = false;
            try
            {
                query = "delete siswa where nis = '" + nis + "'";

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

        public Boolean FindSiswa(string nis)
        {
            status = false;
            try
            {
                query = "select * from siswa where nis = '" + nis + "'";

                OpenConnection();
                command = new SqlCommand(query, koneksi);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();


            }
            catch (SqlException)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                CloseConnection();
            }
            return status;

        }

        public DataTable DisplaySiswa()
        {
            DataTable tabel1 = new DataTable();
            try
            {
                query = "SELECT nis as 'NIS', NamaSiswa as 'Nama Siswa', Gender as 'Jenis Kelamin', TempatLahir as 'Tempat Lahir', TanggalLahir as 'Tanggal Lahir', Alamat as 'Alamat', Kelas as 'Kelas', Point as 'Point' from Siswa";

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
