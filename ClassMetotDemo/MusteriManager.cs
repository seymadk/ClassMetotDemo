using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi!   " + musteri.Adi + "  " + musteri.Soyadi + "  " + musteri.Yasi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi!   " + musteri.Adi + "  " + musteri.Soyadi + "  " + musteri.Yasi);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler bilgileri listelendi");
        }
    }
}
