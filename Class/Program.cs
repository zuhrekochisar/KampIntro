using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Zühre";
            int yas = 24;



            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Zühre Koçhisar";
            kurs1.IzlenmeOrani = 90;

            Console.WriteLine("-----------------------------");

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursunEgitmeni = "Z. K.";
            kurs2.IzlenmeOrani = 95;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (var kurs in kurslar)
            {
                // Console.WriteLine(kurs.KursAdi + ":" + kurs.KursunEgitmeni +":" + kurs.IzlenmeOrani);
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursunEgitmeni);
                Console.WriteLine(kurs.IzlenmeOrani);

            }


        }
    }
    class Kurs
    {
        //prop yazıp 2 kere tab a bastık. >>>
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
