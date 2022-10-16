using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelAlistirma
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }

        public double Ortalama
        {
            get { return (double)(N1 + N2) / 2; } //iki int sayıyı double a çevirmeyi gösteriyor
        }

        public string TamAd
        {
            get { return Ad + ""+ Soyad; }
        }

        public void Yazdir(int siraNo)
        {
            Console.WriteLine(siraNo + "- " + TamAd);
        }

    }
}
