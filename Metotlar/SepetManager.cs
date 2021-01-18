using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming convention -büyük harf ie yaz
        public void Ekle(Urun urun) //ne ekliyeyim diye sorar işte o yüzdn paramtre ekleriz yani burada paramtre ürün oluyor.
        {
            Console.WriteLine("Sepete eklendi : "+ urun.Adi);

        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);

        }
    }
}
