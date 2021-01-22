using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{

    class MyList<T> //T - Bana bir tip ver demek. Type'ın T'si.
    {
        // string[] items;
        T[] items;
        
        //constructor
        public MyList()  //ctor + 2 tab
        {
            items = new T[0];    //Bir class new'lendiğinde çalışana bloğa constructor denir.
        }
        public void Add(T item) // T ile ne sitersem elemanın türü de odur. item - eleman (yerine başka bir şey de yazılabilir.)

                            //Diziye eleman ekleme
        {
            T[] tempArray = items;     //tempArray - Geçici Dizi  //Geçici dizinin referansı items'ın referansı. Elemanlar kaybolmasın diye yapılır.
            //Dizinin eleman sayısını 1 arttırmak istiyoruz. Dizinin sayısnı 1 artırmak için new'lemek zorundayız.

            items = new T[items.Length+1]; //items.length - dizinin eleman sayısı demek. Önce burası çalışır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;    //Dizi 0'dan başladığı için -1 oldu. Dizinin son elemanını yazdırmak için.
        }
    }
}
