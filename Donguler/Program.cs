using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            //array-dizi

            string[] kurslar = new string[] {"python", "yazılım geliştirici yetiştirme kampı", "programlamaya başlangıç için temel kurs" , "java"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine();

            foreach (string kurs in kurslar)
            {
                //dizi temelli yapıları tek tek dönmeye yarar
                //kursları tek tek dolaş demek. foreach dizilere uygulanır
                //fordan daha kolay. for daha genel amaçlı, foreach ise dizileri daha kolay dolaşmak için kullanırız
                //burda kurs i gibidir. takma isimdir, aliastır
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
