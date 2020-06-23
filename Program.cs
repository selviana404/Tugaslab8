using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.ClassAnak;
using Inheritance.ClassInduk;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab8";
            Console.WriteLine("---------------------");
            Console.WriteLine("Nama: Selviana");
            Console.WriteLine("Nim : 19.11.2875");
            Console.WriteLine("---------------------");

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "190221623332";
            karyawanTetap.Nama = "Selviana";
            karyawanTetap.GajiBulanan = 9000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "190215523215";
            karyawanHarian.Nama = "Andika Nur Arifin";
            karyawanHarian.UpahPerJam = 35000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "192342023652";
            sales.Nama = "Rahajeng Malaika";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 50000;

            // Objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadLine();
        }
    }
}