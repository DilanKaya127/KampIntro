using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //manager, ürünle ilgili çeşitli operasyonların oldu amlamına gelir
    {
        //encapsulation
        public void Add(Product product)  //(string ad) yazmak gibi. metodun nasıl çağrılacağının anlatıldığı yer. yani başka yerde productManager.Add("dilan") deriz eğer string türündeyse
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        public void Update(Product product) //void metotları emir kipli konuşmak anlamına geliyor. yani update et
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        ////aralarındaki fark şu. void emret yap bitir daha sonra tekrar kullanmazsın. ama int topla diyip returnlersen onu yeniden kullanabilirsin

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }
}
