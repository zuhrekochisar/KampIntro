using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            //sayi1 = ? 
            //Cevap = 30. sayi1'i sayi2'ye ata. 


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;



            foreach (int sayi in sayilar1)
            {
                Console.WriteLine(sayilar1[0]);
            }
            //sayilar1[0] = ?
            //Cevap = 999.

           
            //int, decimal, float, bool,double = değer tip
            //array, class, interface = referans tip
            //stack - değer tipler burada tanımlanıyor. sayi1,sayi2
            //heap -  101/[10,20,30]
            //heap -  102/[100,200,300]      new; bellekten bir adres oluştur demektir.



        }
    }
}
