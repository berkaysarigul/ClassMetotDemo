using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Berkay";
            musteri1.Surname = "Sarıgül";
            musteri1.CardNo = 111111;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Engin";
            musteri2.Surname = "Demiroğ";
            musteri2.CardNo = 222222;


            MusteriManager musteriManager = new MusteriManager();
            //Müşteri ekleme
            Console.WriteLine("-----------müşteri ekleme----------");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            //müşteri listeleme
            Console.WriteLine("-------------müşteri listeleme--------");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri : {0} {1} {2} {3} ", musteri.Id, musteri.Name, musteri.Surname, musteri.CardNo);
            }

            //Müşteri silme
            Console.WriteLine("-------------Müşteri Silme-----------");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);






        }
    }
}
