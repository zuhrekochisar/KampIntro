using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";




            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            //Tamamen elmaya ait bir sınıf oluşturuldu. Bütün özellikleri barındıran Elma kategorisi.

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Taze Çilek";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe-tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("--------Metotlar-------");

            //instance- Class örneği oluşturmak
            //encapsulation-düzen oluşturmak
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


        }

    }
}
//Metotlar tekrar tekrar kullanılabilirliği sağlar. DRY-(Do not repeat yourself)-Clean Code- Best Practise
