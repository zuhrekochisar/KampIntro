using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //Ekle, sil, güncelleme, listeleme vb operasyonların bulunduğu classlar manager'dır.
    {
        public void Add(Product product)  // void git ekle, git güncelle...
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }

        
       
        /*public int Topla(int sayi1, int sayi2)
        {
        return sayi1 + sayi2;
       }

    public void Topla2(int sayi1, int sayi2)
        {
        Console.WriteLine(sayi1 + sayi2);
       }*/


    }
}


