using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //bu 2 dediğimizi mobilya gibi düşün
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id=2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Topla2(3, 6); //direkt 9 u yazdırır
            int sonuc = productManager.Topla(3, 9); //sağdaki yazdığımız return dediğimiz yer onu sonuca atarız.
            Console.WriteLine(sonuc*2);

            
        }
    }
}
