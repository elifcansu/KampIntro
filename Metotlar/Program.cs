using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //Classın örneği .manavdaki bir ürün bu gibi düşün
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80; 
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)//var da olur o tipi yakalar
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");         
            }

            Console.WriteLine("--------------Metotlar--------------");

            //instance-örnek
            //encapsulation kapsülleme demek özellikleri classda tut ve metotda kullanırken bir kutu içinde tutuyormuş gibi tek bir veri tipinden getir.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //Aşağıdaki gibi yazmamamız gerekir. yönetim bide stok bilgisi isterse ilerde gidip metotu değiştirmek gerekir.bu yanlış kullanım heryerde değişiklik gerekir.
            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Çilek", "Dağ Çileği", 10);
          
        }
    }
}


//do not repeat yourself -Dry-Clean Code-Best Practice
//metotlar tekrar tekrar kod yazmamızı önler.aynı kod bloklarını bir çok yerde kullanmak yanlış. bunun yerine metot belirle ve onu çağır. 