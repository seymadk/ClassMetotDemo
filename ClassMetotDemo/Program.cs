using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "YILMAZ";
            musteri1.Yasi = 30;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "ARSLAN";
            musteri2.Yasi = 25;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Mehmet";
            musteri3.Soyadi = "KAYA";
            musteri3.Yasi = 28;

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                musteriManager.Listele(musteri);
                Console.WriteLine("---------------------------");

            }

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);

        }
    }
}
