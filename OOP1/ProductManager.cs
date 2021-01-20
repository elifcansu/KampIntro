using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1,int sayi2)//returnlerin amacı ben bu işlemi yaptıktan sonra başka bişeylerde ekleyebileyim.mesela birinin kredi notu bu iki sayının toplamıyken başka birininki bu toplamın 2 katı olabilir.
        {
            return sayi1 + sayi2;
        }


        public void Topla2(int sayi1, int sayi2)//void emir kipi ile o işlemi yap der yazdırır.
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
