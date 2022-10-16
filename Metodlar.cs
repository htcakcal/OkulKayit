using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelAlistirma
{
    public static class Metodlar
    { 
        public  static char GetChar(string metin)
        {
            Console.WriteLine(metin);
            return Console.ReadKey().KeyChar;

        }

        public static string GetString(string metin)
        {
            string txt = string.Empty;  //""    yani boş değerdir
            bool hata = false;
            do
            {
                Console.WriteLine(metin);
                txt = Console.ReadLine();
                if (!string.IsNullOrEmpty(txt))
                {
                    hata = false;
                }
                else
                {
                    hata = true;
                    Console.WriteLine("Boş bırakılamaz");
                    Console.WriteLine();
                }
            } while (hata);  //
            return txt;

        }

        public static int GetInt(string metin,int min,int max)
        {
            int sayi = 0;
            bool hata = false;

            do
            {
                Console.WriteLine(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if(sayi >= min && sayi<= max)
                    {
                        hata = false;

                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine("Girilen sayı {0} ie {1} aralığında olmalıdır",min,max);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    hata = true;
                }
            } while (hata);
            return sayi;
        }



    }
}
