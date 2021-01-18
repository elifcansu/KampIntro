using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs(); //kurs tipinde kurs1 tanımladık
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); //kurs tipinde kurs1 tanımladık
            kurs2.KursAdi = "jAVA";
            kurs2.Egitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); //kurs tipinde kurs1 tanımladık
            kurs3.KursAdi = "PYTHON";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs(); //kurs tipinde kurs1 tanımladık
            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "Murat Vardır";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi+ " : " + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 }; //böyle yazdığımız için kurs tipini tutacağız içinde

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
