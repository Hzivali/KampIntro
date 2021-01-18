using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Hp Probook 450";
            product1.ProductPrice = 6.339;

            Product product2 = new Product();
            product2.ProductName = "Lenovo L14";
            product2.ProductPrice = 6.459;
            
            Product product3 = new Product();
            product3.ProductName = "Acer Aspire";
            product3.ProductPrice = 5.899;

            Product product4 = new Product();
            product4.ProductName = "Dell XPS 13";
            product4.ProductPrice = 9.298;



            Product[] products = new Product[] {product1,product2,product3,product4 };
            
            
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductPrice + "TL");
            }

            Console.WriteLine("----------------------------------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürun Adı : " + products[i].ProductName + " Fiyatı: " + products[i].ProductPrice + "TL");
            }
            Console.WriteLine("----------------------------------------------");

            int j = 0;
            while (j<products.Length)
            {
                Console.WriteLine("Ürun Adı : " + products[j].ProductName + " Fiyatı: " + products[j].ProductPrice + "TL");
                j++;
            }
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}
