using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar" },
                new Category{CategoryId=2,CategoryName="Telefon" }
            };

            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantiTyperUnit = "32 GB RAM", UnıtPrice = 60000,UnıtsınStock = 5 },
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantiTyperUnit = "16 GB RAM", UnıtPrice =50000 , UnıtsınStock = 9 },
                new Product { ProductId = 3, CategoryId = 1, ProductName = "Hp Laptop", QuantiTyperUnit = "32 GB RAM", UnıtPrice = 55000, UnıtsınStock = 3 },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantiTyperUnit = "4 GB RAM", UnıtPrice = 3000, UnıtsınStock = 15 },
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantiTyperUnit = "8 GB RAM", UnıtPrice = 20000, UnıtsınStock = 8 }
            };
            Console.WriteLine("Algoritmik----------");


            foreach (var product in products)
            {
                if (product.UnıtPrice > 5000 && product.UnıtsınStock > 8)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryId);

                }

            }

            Console.WriteLine("Linq---------------");

            var result = products.Where(p => p.UnıtPrice>5000 && p.UnıtsınStock>3); //foreach da ki il verilen geçici değer mantığı verilen p.
            foreach(var product in result) {


                Console.WriteLine(product.ProductName);
            }

            Getproducts(products);
            
            Console.ReadKey();

        }
        static List<Product> Getproducts(List<Product>products) {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
               

                if (product.UnıtPrice > 5000 && product.UnıtsınStock > 8)
                {
                    filteredProducts.Add(product);
                    Console.WriteLine(product.ProductName + " / " + product.CategoryId);

                }

            }
            return filteredProducts;

        }
        static List<Product> GetproductsLinq(List<Product> products) {


            return products.Where(p => p.UnıtPrice > 5000 && p.UnıtsınStock > 3).ToList(); //foreach da ki il verilen geçici değer mantığı verilen p.

        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantiTyperUnit { get; set; }
        public decimal UnıtPrice { get; set; }
        public int UnıtsınStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
