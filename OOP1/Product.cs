using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet hazır kodlar demek - tab tab
    class Product //entity (varlık) gibi isimler veririz
    {
        public int Id { get; set; }  // ana anahtar
        public int CategoryId { get; set; } //kod okunurluğu için id'leri alt alta koyduk
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; } //stok adedi demek

        //CRUD operasyonları. create read update delete
    }
}
