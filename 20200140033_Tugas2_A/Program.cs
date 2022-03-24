using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140033_Tugas2_A
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=LAPTOP-GK6AO77T;database=Rey;Integrated Security = TRUE");
                conn.Open();

                SqlCommand comand = new SqlCommand("create table Kios_Mall (Id_Kios char(4) not null primary key, Nama_Kios varchar(30) not null, Alamat varchar(30))"
                    + "create table Pemilik_Mall (Id_Pemilik char(4) not null primary key, Nama_Pemilik varchar(30) not null, No_Hp char(12), Jenis_Kelamin char(1))"
                    + "create table Penyewa_Mall (Id_Penyewa char(4) not null primary key, Nama_Penyewa varchar(30) not null, Jenis_Kelamin char(1))"
                    + "create table Transaksi (Id_Transaksi char(4) not null primary key, Id_Kios char(4) FOREIGN KEY REFERENCES Kios_Mall(Id_Kios), Id_Pemilik char(4) FOREIGN KEY REFERENCES Pemilik_Mall(Id_Pemilik), Id_Penyewa char(4) FOREIGN KEY REFERENCES Penyewa_Mall(Id_Penyewa), Waktu varchar(30), TempoKontrak varchar(30), Harga_Sewa varchar(30), Alamat_Kios varchar(30))", conn);
                comand.ExecuteNonQuery();

                Console.WriteLine("Tabel telah dibuat lur");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Tabel gagal dibuat lurr" + e);
                Console.ReadKey();
            }
            finally
            {
                conn.Close();
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
