using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Mark8InClassExamples
{
    class ProductRepo
    {
        public List<Product> GetAllProducts()
        {
            MySqlConnection conn = new MySqlConnection();
            // DO NOT WANT TO COMMIT THIS STRING IN GIT
            conn.ConnectionString = "your connection string here";
            // but way better to have the connection string in a configuratio file

            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT ProductID, Name, Price, OnSale, StockLevel " +
                                  "FROM products;";

            using (conn)
            {
                conn.Open();

                MySqlDataReader dataReader = command.ExecuteReader();

                List<Product> allProducts = new List<Product>();

                while (dataReader.Read())
                {
                    Product newProduct = new Product();
                    newProduct.Id = dataReader.GetInt32("ProductID");
                    newProduct.Name = dataReader.GetString("Name");
                    newProduct.Price = dataReader.GetDecimal("Price");
                    newProduct.OnSale = dataReader.GetBoolean("OnSale");
                    newProduct.StockLevel = dataReader.GetInt32("StockLevel");

                    allProducts.Add(newProduct);
                }

                return allProducts;
            }
        }
    }
}
