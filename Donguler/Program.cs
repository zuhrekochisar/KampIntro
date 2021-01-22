
using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazlım Geliştirme Kursu";
            string kurs2 = "Temel Kurs";
            string kurs3 = "Java";

            //array-dizi
            //kursları her seferinde yeniden yazmamak için dizi içinde yazarız. Bu durumda
            //yukarıdaki tanımlamamlara gerek yoktur.

            string[] kurslar = new string[] { "Yazılım Geliştirme Kursu",
                "Temel Kurs",
               "Java" , "Python"};

            //length = eleman sayısını verir. <3 kullandığımızda 0'dan başlayıp 2 ye kadar 
            // 3 eleman sayıyordu. Length ile dizide kaç eleman varsa o verilir.

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                // kursların i'inci elemanını yaz. 

            }
            Console.WriteLine("For Bitti");

            //foreach; dizi temelli yapıları tek tek dönmeye yarar. Dizilere uygulanır.
            //in kurslar; kursları tek tek dolaş demek.
            //kurs; abc de yazılsa çalışır. Verilen takma isimdir.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu - footer");

        }
    }
}


