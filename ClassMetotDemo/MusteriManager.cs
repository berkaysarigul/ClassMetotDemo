using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Id + " " + musteri.Name + " " + musteri.Surname + " " + musteri.CardNo);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Id + " " + musteri.Name + " " + musteri.Surname + " " + musteri.CardNo);
        }


    }
}
