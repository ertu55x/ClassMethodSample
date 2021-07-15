using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + musteri.Id);
            Console.WriteLine("Müşteri Eklendi!");
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + musteri.Id);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + musteri.Id);
            Console.WriteLine("Müşteri Silindi.");
        }
    }
}
