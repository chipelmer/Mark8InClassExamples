using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mark8InClassExamplesAspNet
{
    class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = System.IO.File.ReadAllText("ConnectionString.txt");

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ProductID, Name, Price FROM products;";

            using (conn)
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                List<Product> products = new List<Product>();

                while (reader.Read())
                {
                    Product nextProduct = new Product();

                    nextProduct.Id = reader.GetInt32("ProductID");
                    nextProduct.Name = reader.GetString("Name");
                    nextProduct.Price = reader.GetDecimal("Price");

                    products.Add(nextProduct);
                }

                return products;
            }
        }
    }
}
