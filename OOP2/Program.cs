using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //elif ertürk

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Elif";
            musteri1.Soyadi = "Ertürk";
            musteri1.TcNo = "12345678906";


            //KODLAMA.IO

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "324";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "244";


            //gerçek müşteri-tüzel müşteri birbirlerinin yerine asla kullanılmamalı.
            //SOLID -L PRENSİBİ SÖYLER BUNU

            Musteri musteri3 = new GercekMusteri(); //her gerçek hemde tüzelin nosunu tutabiliyor. musteri onların refaranslarını tutar böylelikle.
            Musteri musteri4 = new TuzelMusteri(); //base sınıf ref tutucudur.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
        }
    }
}
