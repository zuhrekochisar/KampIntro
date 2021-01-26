using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //özellik sınıfı
    class GercekMusteri:Musteri  //invidual 
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
//inheritance - gerçek ve tüzelde ortak özellikler vardır. Musteri sınıfında olan tüm özelliklerin gerçek ve tüzel müşteride bulunması.