using System;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are all the products:");
            Console.WriteLine("ID | Name | Price | Stock Level | On Sale");

            ProductRepo repo = new ProductRepo();
            List<Product> products = repo.GetAllProducts();

            for (int i = 0; i < products.Count; i++)
            {
                int id = products[i].Id;
                string name = products[i].Name;
                decimal price = products[i].Price;
                bool onSale = products[i].OnSale;
                int stock = products[i].StockLevel;

                Console.WriteLine($"{id} | {name} | {price} | {stock} | {onSale}");
                Console.WriteLine();
            }
        }
    }
}
