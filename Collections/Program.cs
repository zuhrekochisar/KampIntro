using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Zühre", "Öznur", "Burcu", "Mihriban" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // 5 elemanlı bir dizi tanımlandı.
            //isimler[4] = "İlker"; //Dizinin 5.elemanı.
            //Console.WriteLine(isimler[4]);  
            //Console.Writelinw(isimler[2]); Bu ekranda yazılmaz. Bunun için List kullanılır.
            //Control+K ve Control+C  - komple yorum satırı için(önce alanı seç.). Geri almak için C yerine U.


            List<string> isimler2 = new List<string> { "Zühre", "Öznur", "Burcu", "Mihriban" }; //Değerleri kaybetmemek için liste kullanılır.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[4]);

            //List yazdıktan sonra ampule tıkla, ardından using ...generic(ilk) olanı seç.

        }
    }
}
