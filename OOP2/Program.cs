using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zühre Koçhisar
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Zühre";
            musteri1.Soyadi = "Koçhisar";
            musteri1.TcNo = "12345678912";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "34567";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";

            Musteri musteri3 = new GercekMusteri();  // referans no
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
