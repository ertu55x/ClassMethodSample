using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 55;
            musteri1.Adi = "Ertuğ";
            musteri1.Soyadi = "Gül";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 34;
            musteri2.Adi = "Ertuğrul";
            musteri2.Soyadi = "Güllüoğlu";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 54;
            musteri3.Adi = "Ertan";
            musteri3.Soyadi = "Güllü";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + " => " + musteri.Soyadi + " " + "=>" + " " + musteri.Id);
            }
            Console.WriteLine("------------------------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);
            musteriManager.Listeleme(musteri3);
            Console.WriteLine("Müşteriler Listelendi");
            Console.WriteLine("------------------------");
            musteriManager.Ekleme(musteri1);
            Console.WriteLine("------------------------");
            musteriManager.Silme(musteri3);



            Console.ReadKey();
        }
    }
}
