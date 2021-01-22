using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet - hazır kodlar
    class Product  //Bu tip classlarda sadece özellik olur.
    {
        public int Id { get; set; }  //primary key - ana anahtar
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }  //ürünün fiyatı
        public int UnitsInStock { get; set; } //stok adedi




    }
}
