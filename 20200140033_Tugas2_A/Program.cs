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
                    + "create table Penyewa_Mall (Id_Penyewa char(4) not null primary key, Nama_Penyewa varchar(30) not null, No_Hp char (12), Jenis_Kelamin char(1))"
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

        public void InsertTable()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=LAPTOP-GK6AO77T;database=Rey;Integrated Security = TRUE");
                conn.Open();

                SqlCommand comand = new SqlCommand("insert into Kios_Mall (Id_Kios, Nama_Kios, Alamat) values ('K5B1','Kios Jamet','Kios 5 Blok 1 lantai 4')"
                    + "insert into Kios_Mall (Id_Kios, Nama_Kios, Alamat) values ('K6B2','Kios Jono','Kios 6 Blok 2 Lantai 2')"
                    + "insert into Kios_Mall (Id_Kios, Nama_Kios, Alamat) values ('K7B3','Kios Joni','Kios 7 Blok 3 Lantai 3')"
                    + "insert into Kios_Mall (Id_Kios, Nama_Kios, Alamat) values ('K8B4','Kios Jett','Kios 8 Blok 4 Lantai 1')"
                    + "insert into Kios_Mall (Id_Kios, Nama_Kios, Alamat) values ('K9B5','Kios Sage','Kios 9 Blok 5 Lantai 1')"
                    + "insert into Pemilik_Mall (Id_Pemilik, Nama_Pemilik, No_Hp, Jenis_Kelamin) values ('3031','Raihan','081385786531','L')"
                    + "insert into Pemilik_Mall (Id_Pemilik, Nama_Pemilik, No_Hp, Jenis_Kelamin) values ('3032','Raihana','081385786532','P')"
                    + "insert into Pemilik_Mall (Id_Pemilik, Nama_Pemilik, No_Hp, Jenis_Kelamin) values ('3033','Raihani','081385786533','P')"
                    + "insert into Pemilik_Mall (Id_Pemilik, Nama_Pemilik, No_Hp, Jenis_Kelamin) values ('3034','Raihanu','081385786534','L')"
                    + "insert into Pemilik_Mall (Id_Pemilik, Nama_Pemilik, No_Hp, Jenis_Kelamin) values ('3035','Raihano','081385786535','L')"
                    + "insert into Penyewa_Mall (Id_Penyewa, Nama_Penyewa, No_Hp, Jenis_Kelamin) values ('4041','Jamet','081385786536','L')"
                    + "insert into Penyewa_Mall (Id_Penyewa, Nama_Penyewa, No_Hp, Jenis_Kelamin) values ('4042','Jono','081385786537','L')"
                    + "insert into Penyewa_Mall (Id_Penyewa, Nama_Penyewa, No_Hp, Jenis_Kelamin) values ('4043','Joni','081385786538','L')"
                    + "insert into Penyewa_Mall (Id_Penyewa, Nama_Penyewa, No_Hp, Jenis_Kelamin) values ('4044','Jett','081385786539','L')"
                    + "insert into Penyewa_Mall (Id_Penyewa, Nama_Penyewa, No_Hp, Jenis_Kelamin) values ('4045','Sage','081385786510','L')"
                    + "insert into Transaksi (Id_Transaksi, Id_Kios, Id_Pemilik, Id_Penyewa, Waktu, TempoKontrak, Harga_Sewa, Alamat_Kios) values ('2021','K5B1','3031','4041','14 Januari 2011','1 Tahun','Rp 15.000.000','Jakarta')"
                    + "insert into Transaksi (Id_Transaksi, Id_Kios, Id_Pemilik, Id_Penyewa, Waktu, TempoKontrak, Harga_Sewa, Alamat_Kios) values ('2022','K6B2','3032','4042','15 Februari 2012','2 Tahun','Rp 30.000.000','Yogyakarta')"
                    + "insert into Transaksi (Id_Transaksi, Id_Kios, Id_Pemilik, Id_Penyewa, Waktu, TempoKontrak, Harga_Sewa, Alamat_Kios) values ('2023','K7B3','3033','4043','16 Maret 2013','3 Tahun','Rp 45.000.000','Bandung')"
                    + "insert into Transaksi (Id_Transaksi, Id_Kios, Id_Pemilik, Id_Penyewa, Waktu, TempoKontrak, Harga_Sewa, Alamat_Kios) values ('2024','K8B4','3034','4044','17 April 2014','4 Tahun','Rp 60.000.000','Surabaya')"
                    + "insert into Transaksi (Id_Transaksi, Id_Kios, Id_Pemilik, Id_Penyewa, Waktu, TempoKontrak, Harga_Sewa, Alamat_Kios) values ('2025','K9B5','3035','4045','18 Mei 2015','5 Tahun','Rp 75.000.000','Medan')", conn);
                comand.ExecuteNonQuery();

                Console.WriteLine("Data sukses ditambahkan lur");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Data gagal ditambahkan lur" + e);
                Console.ReadKey();
            }
            finally
            {
                conn.Close();
            }
        }
        static void Main(string[] args)
        {
            new Program().CreateTable();
            new Program().InsertTable();
        }
    }
}
