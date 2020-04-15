using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2920
{
    class Karyawan
    {
        public string Nik;
        public string Nama;
        public int GajiBulanan;
        public Karyawan(string nik, string nama, int GajiBulanan)
        {
            this.Nik = nik;
            this.Nama = nama;
            if (GajiBulanan < 0)
            {
                this.Nik = "0";
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
            }
        }
    }
}
