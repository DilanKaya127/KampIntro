using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------");
            }

            Console.WriteLine("--------metotlar-----------");

            //instance - örnek
            //encapsulation = kapsülleme = düzenli kapsülün içine koyma

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12,100);
            sepetManager.Ekle2("elma", "kırmızı elma", 15,89);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 30,78);


        }
    }
}


//tekrar kullanılabilirliği sağlar metotlar
//dont repeat yourself (dry) - clean code - best practice = en iyi, doğru uygulama teknikleri
