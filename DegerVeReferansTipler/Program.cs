using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimalifloat,double,bool=deger tip
            //array,class,interface=referans tip
            //bellekte stack ve heap diye iki yer var.deger tipleri stack de toplanır.deger tiplerde deger atanır referans tiplerde adres atanır..new demek heapte yeni bir adres oluştur demek .sanki kkapı numarası veriyormuş gibi oluruz .heapteki degerlerde sayilar 1 artık sayilar 2 nin adresini gössterir. o yüzden sayilar1 artık kullanılmadığı içn .net in garbage collecter yani çöp toplayıcısı sayilar1 i bellekten çıkarır.

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? cevap 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] cevap 999
        }
    }
}
