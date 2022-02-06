using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLookupWithDictionary
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class ProductCatalog
    {
        public Dictionary<int, Product> Products { get; set; }

        public ProductCatalog()
        {
            Products = new Dictionary<int, Product>();

            Products.Add(12345, new Product { ID = 12345, Name = "Widget", Price = 8.99m });
            Products.Add(12346, new Product { ID = 12346, Name = "Fidget", Price = 6.99m });
            Products.Add(12347, new Product { ID = 12347, Name = "Midget", Price = 4.99m });
        }

        public Product Lookup(int ProductID)
        {
            return Products[ProductID];
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var myVar = new ProductCatalog();
            Console.WriteLine(myVar.Lookup(12345).Name);
            Console.ReadLine();
        }
    }
}
