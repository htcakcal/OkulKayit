using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelAlistirma
{
    public static class Menu
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public static void Islemler(char cevap)
        {
            switch (cevap)
            {
                case '1':
                    OgrenciEkle("Öğrenci Ekle");
                    //Console.WriteLine("öğrenci Ekle");
                    //Console.ReadKey();
                    break;
                case '2':
                    OgrenciListele("Öğrencileri Listele");
                    //Console.WriteLine("Öğrencileri Listele");
                    //Console.ReadKey();
                    break;
                case '3':
                    OgrenciSil("Öğrenci Sil");
                    //Console.WriteLine("Öğrenci Sil");
                    //Console.ReadKey();
                    break;
                case '4':
                    OgrenciAra("Öğrenci Ara");
                    //Console.WriteLine("Öğrenci Ara");
                    //Console.ReadKey();
                    break;
                case '5':
                    OgrenciToplam("Toplam  Öğrenci Sayısı");

                    //Console.WriteLine("Toplam öğrenci Sayısı");
                    //Console.ReadKey();
                    break;
                case '6':
                    GenelOrtalama("Genel Not Ortalaması");

                    //Console.WriteLine("Öğrencilerin Genel Not Ortalaması");
                    //Console.ReadKey();
                    break;

            }
        }

        private static void GenelOrtalama(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Any())
            {
                double ortalamalarToplami = 0;
                foreach (var ogrenci in ogrenciler)
                {
                    ortalamalarToplami += ogrenci.Ortalama;
                }

                double gOrtalama = ortalamalarToplami / ogrenciler.Count;

                AnaMenuyeDon(string.Format("{0} adet öğrencinin genel not ortalaması {1}", ogrenciler.Count, gOrtalama));
            }
            else
            {
                AnaMenuyeDon("Listede öğrenci bulunmamaktadır");
            }
        }

        
	
        private static void OgrenciToplam(string v)
        {

            BaslikYazdir(v);
            if (ogrenciler.Any()) 
            {
                AnaMenuyeDon(string.Format("{0} adet öğrenci vardır", ogrenciler.Count));
            }
            else
            {
                AnaMenuyeDon("Öğrenci bulunamadı");
            }
        }

        private static void OgrenciAra(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Any())
            {
                string aranacakMetin = Metodlar.GetString("Aramak istediğiniz öğrencinin adı veya soyadını yazınız");

                int adet = 0;
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    if (ogrenciler[i].TamAd.ToLower().Contains(aranacakMetin.ToLower()))
                    {
                        adet++;
                        ogrenciler[i].Yazdir(adet);
                    }

                    AnaMenuyeDon(aranacakMetin + "kelimesine karşılık " + adet + "sonuç bulunmuştur");
                }

            }

            else
            {
                AnaMenuyeDon("Aranacak öğrenci bulunamadı");  
            }
        }

        private static void OgrenciSil(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Any())
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                int siraNo = Metodlar.GetInt("Silmek istediğinizöğrencinin sıra numarasını giriniz :", 1, ogrenciler.Count);

                string ogrenciAdi = ogrenciler[siraNo - 1].TamAd;
                ogrenciler.RemoveAt(siraNo - 1);

                AnaMenuyeDon(ogrenciAdi + "isimli öğrencinin silinme  işlemi başarı ile tamamlanmıştır");
            }


        }

        private static void OgrenciListele(string v)
        {
            #region Any()

            //koleksiyonlarda bulunan Any() metodu koleksiyon içerisinde değer var mı ? yok mu ? kontrolünü yapar.Geriye bool tipinde bir değer döndürür.Listede eleman cvarsa "true" yoksa "false" döndürür

            #endregion


            BaslikYazdir(v);
            if (ogrenciler.Any())//ogrenciler.Count > 0
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);


                }

                AnaMenuyeDon("Toplam" + ogrenciler.Count + "adet öğrenci listelenmistir");

            }

            //AnaMenuyeDon(string.Format("Toplam {0} adet öğrenci listelenmiştir", ogrenciler.Count));  bu şekilde de yazılablir


            else
            {
                AnaMenuyeDon("Listede ögrenci bulunmamaktadır");
            }




            
        }
    
        private static void OgrenciEkle(string v)
        {
            BaslikYazdir(v);
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = Metodlar.GetString("Adı Giriniz: ");
            ogr.Soyad = Metodlar.GetString("Soyadı Giriniz");
            ogr.No = Metodlar.GetInt("Öğrenci Numarası: ",1,9999);
            ogr.N1 = Metodlar.GetInt("1.Notu Giriniz: ",0,100);
            ogr.N2 = Metodlar.GetInt("2.Notu Giriniz: ",0,100);

            ogrenciler.Add(ogr);

            AnaMenuyeDon("Kayıt işlemi başarı ile tamamlanmıştır");
        }

        private static void AnaMenuyeDon(string v)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(v);
            Console.WriteLine("Ana menüye dönmek için bir tuşa basınız");
            Console.ReadKey();
        }

        private static void BaslikYazdir(string v)  //Geçtiğmiz metodun başlığını yazma alanı
        {
            Console.Clear();
            Console.WriteLine(v);
            Console.WriteLine("--------");
            Console.WriteLine();
                
        }
    }
}
