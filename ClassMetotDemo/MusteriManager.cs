using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli müşteri eklendi.");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Listelendi.");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli müşteri silindi.");
        }
    }
}
