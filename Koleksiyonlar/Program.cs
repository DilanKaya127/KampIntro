using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"engin","murat","kerem" ,"halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]); //arrayde sabitlik var

            //isimler = new string[5]; //new demek yeni bir şey oluşturmak demek
            //isimler[4] = "ilker"; //arraye yeni bir isim eklemek istedik ve üste de arrayin 5 elamanlı olduğunu söyledik
            //Console.WriteLine(isimler[4]); //ilkeri artık yazar ama
            //Console.WriteLine(isimler[0]); //listenin 0.elemanı olan engini yazmaz. çünkü sen üstte new string 5 diyerek 5 elemanlı boş bir array oluşturdun aslında. işte bu yüzdeeennn koleksiyonlar var:

            List<string> isimler2 = new List<string> {"murat","kerem","halil", "engin", }; //string listesi
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]); //koleksiyonlar 0.elemanı da yazar
            
            //c#ta list olmasaydı kendi koleksiyonumuzu nasıl yazardık?
            //bu arada sınıflar yeşil renkte gösterilir yani list sınıftır



        }
    }
}
