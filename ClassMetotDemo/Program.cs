using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Samet";
            musteri1.Soyad = "Turgut";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "İlker Furkan";
            musteri2.Soyad = "Şahin";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Doğukan Refik";
            musteri3.Soyad = "Metin";

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Muharrem";
            musteri4.Soyad = "Özbek";

            Musteri musteri5 = new Musteri();
            musteri5.Ad = "Tayfun";
            musteri5.Soyad = "Mersin";

            Musteri musteri6 = new Musteri();
            musteri6.Ad = "Mete";
            musteri6.Soyad = "Kayacan";

            Musteri musteri7 = new Musteri();
            musteri7.Ad = "Yahya Yusuf";
            musteri7.Soyad = "Çolak";

            Musteri musteri8 = new Musteri();
            musteri8.Ad = "Mehmet Kağan";
            musteri8.Soyad = "Ertekin";

            Musteri musteri9 = new Musteri();
            musteri9.Ad ="Emirhan";
            musteri9.Soyad = "Karahan";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, musteri6, musteri7, musteri8 };

            MusteriManager musteriManager = new MusteriManager();
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine("-----");
            }
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriEkle(musteri9);
            musteriManager.MusteriSil(musteri9);
        }
    }
}
