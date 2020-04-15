using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2920
{
    class Program
    {
        static void Main(string[] args)
        {
            int gaji1, gaji2;
            Karyawan karyawan1 = new Karyawan("1123451", "Novandi", 3000000);
            Karyawan karyawan2 = new Karyawan("3242432", "Gatot", 2000000);
            Console.WriteLine("No Nik/nama        Gaji Bulanan");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. " + karyawan1.Nik + " " + karyawan1.Nama + "\t" + karyawan1.GajiBulanan);
            Console.WriteLine("2. " + karyawan2.Nik + " " + karyawan2.Nama + "\t" + karyawan2.GajiBulanan);
            gaji1 = (10 * karyawan1.GajiBulanan) / 100;
            gaji2 = (10 * karyawan2.GajiBulanan) / 100;
            Console.WriteLine("\n\nAsyiiiiik Ada Kenaikan Gaji 10%!!\n");
            Console.WriteLine("No Nik/nama        Gaji Bulanan");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. " + karyawan1.Nik + " " + karyawan1.Nama + "\t" + (gaji1 + karyawan1.GajiBulanan));
            Console.WriteLine("2. " + karyawan2.Nik + " " + karyawan2.Nama + "\t" + (gaji2 + karyawan2.GajiBulanan));

            Console.ReadKey();
        }
    }
}

