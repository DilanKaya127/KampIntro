using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager //manager operasyon tutuyor demek
    {
        public void Ekle(Urun urun) // () varsa metot vardır //naming convention. bu def gibi?
        {
            Console.WriteLine("tebrikler. sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)  //bir classın içinde bidrden fazla metot olabilir
        {
            Console.WriteLine("tebrikler. sepete eklendi : " + urunAdi);
        }
    }
}
