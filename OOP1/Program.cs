using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //Mobilya gibi düşün.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Yukarıdaki gibi yazılacağı gibi aşağıdaki gibi de yazılabilir.
            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName ="kalem", UnitPrice = 35 };

            //PascalCase   camelCase  -  Classlar ve değişkenlerin tanımlanması
            //steck                           heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            /*
            productManager.Topla2(3, 6);
            int toplamaSonucu = productManager.Topla(3,6);
            Console.WriteLine(toplamaSonucu*2);
            */

        }
    }
}
