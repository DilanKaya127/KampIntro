using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Dilan";
            int yas = 20;

            Kurs kurs1= new Kurs(); //kurs değiişkeni tanımlamak istersen //sanki sen kendi tipini yazıyormuşsun gibi
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;      //oaaaaaaa

            Kurs kurs2 = new Kurs(); 
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem varış";
            kurs2.IzlenmeOrani = 90;

            Kurs kurs3 = new Kurs(); 
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay bilgin";
            kurs3.IzlenmeOrani = 64;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.Egitmen = "dilan kaya";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " "+ kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4 }; //içinde kurs nesnesini barından kurs arrayi yazdık

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            
        }
    }

    class Kurs //sanki sen kendi tipini yazıyormuşsun gibi
    {
        public string KursAdi { get; set; }  //prop tab tab yapıyoruz. property özellik?
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
