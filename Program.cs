﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman2285
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kry1 = new Karyawan();

            kry1.Nik = "18.11.2285";
            kry1.Nama = "Reza";
            kry1.GajiBulanan = 9500000;

            Karyawan kry2 = new Karyawan();

            kry2.Nik = "18.11.2258";
            kry2.Nama = "Rama";
            kry2.GajiBulanan = 5900000;

            Console.WriteLine("No.\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Aseeeek gaji naik 10% Bosss!!!");
            Console.WriteLine("\n");
            Console.WriteLine("No.\tNik/Nama\t\tGaji Bulanan");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));

            Console.ReadKey();
        }
    }
}