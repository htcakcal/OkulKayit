using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelAlistirma
{
    class Program
    {
        static void Main(string[] args)
        {

            //Öğrenci Kayıt Programı
            //........
            //1 Öğrenci Ekle
            //2.Öğrencileri Listele
            //3.Öğrenci Sİl
            //4.Öğrenci Ara
            //5.Toplam Öğrenci SAyısı
            //6.Öğrencilerin GEnel Not Ortalamsı
            //0.Çıkış

            //Yukarıda belirtilen menüye bağlı kalarak menüler içerisinde gerekli işlemleri yaptıralım.
            //uygulama içerisinde kullanıcı programdan çık seçeneğini seçerse uygulamayı kapattığına dair metin çıkaralım ve uygulamayı kapatalım

            char cevap = ' ';

            do
            {
                Console.Clear();
                Console.WriteLine("Öğrenci Kayıt Uygulaması");
                Console.WriteLine("-----");
                Console.WriteLine("1- Öğrenci Ekle");
                Console.WriteLine("2- Öğrencileri Listele");
                Console.WriteLine("3- Öğrenci Sil");
                Console.WriteLine("4- Öğrenci Ara");
                Console.WriteLine("5- Toplam öğrenci Sayısı");
                Console.WriteLine("6- Öğrencilerin Genel Not Ortalaması");
                Console.WriteLine("0- Çıkış");
                //Console.WriteLine("Hangi işlemi yapmak istersiniz?");

                cevap = Metodlar.GetChar("Hangi işlemi yapmak istersiniz?\nMenü numarasını tuşlayınız: ");                //cevap = char.Parse(Console.ReadLine());


                Menu.Islemler(cevap);


            } while (cevap !='0');
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Programı kullandığınız için teşekkür ederiz");
            Console.WriteLine("Kapatmak için bir tuşa basınız");

            Console.ReadKey();




        }
    }
}
