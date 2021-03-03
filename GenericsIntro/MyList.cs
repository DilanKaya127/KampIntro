using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //buraya T yazmamızın nedeni, bana herhangi bir tip ver demek
    class MyList<T> // <> buraya str dışında int, bool ya da class koyabiliriz
    {
        T[] items; //bu metotun içinde değil, classın içindedir
        public MyList() //constructor. ctor yazıp tab tab yapınca çıktı. bir eleman newlendiğince bu çıkar?
        {
            items = new T[0];
        }
        public void Add(T item) //bu bir metottur
        {
            T[] tempArray = items; //geçici olarak itemsın elemanlarını temparraye verdik
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //burda items emanetini temparreyden alıp teşekkür ediyor
            }

            items[items.Length - 1] = item;

        }

        public int Length
        {
            get { return items.Length; }
        }
            

    }
}
