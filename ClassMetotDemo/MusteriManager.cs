using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {



        List<Musteri> musteriler = new List<Musteri>();


        public void Ekle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("Müşteri Eklenmiştir  : " + musteri.Adi + " " + musteri.Soyadi);
        }
        
        public void Sil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Müşteri Silinnmiştir  : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi : " + musteri.Adi + " " + musteri.Soyadi);
            foreach (Musteri Musteri in musteriler)

            {
                Console.WriteLine("Müşteri Id : " + musteri.Id);
                Console.WriteLine("Müşteri Adı : " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : " + musteri.Soyadi);
                Console.WriteLine("Müşteri Kimlik No : " + musteri.kimlikNo);
                Console.WriteLine("Müşteri Yaşadığı Şehir : " + musteri.Sehir);
                Console.WriteLine("Müşteri Cep Tel.No. : " + musteri.cepTel);
            }
        }


    }
}
