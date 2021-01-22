using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Do not repeat yourself = kendini tekrarlama
            //değer tututucu-kategoriEtiketi = alias(takma isim)

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faiz = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)

            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
