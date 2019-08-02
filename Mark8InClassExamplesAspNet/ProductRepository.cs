using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Mark8InClassExamplesAspNet.Models;

namespace Mark8InClassExamplesAspNet
{
    class ProductRepository
    {
        public void AddProductToDatabase(Product newProduct)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = System.IO.File.ReadAllText("ConnectionString.txt");

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO products (name, price) " +
                              "VALUES (@name, @price);";
            cmd.Parameters.AddWithValue("name", newProduct.Name);
            cmd.Parameters.AddWithValue("price", newProduct.Price);

            using (conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProductFromDatabase(int id)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = System.IO.File.ReadAllText("ConnectionString.txt");

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM products " +
                              "WHERE ProductID = @id;";
            cmd.Parameters.AddWithValue("id", id);

            using (conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product prod)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = System.IO.File.ReadAllText("ConnectionString.txt");

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE products " +
                              "SET Name = @name, Price = @price " +
                              "WHERE productid = @id;";
            cmd.Parameters.AddWithValue("name", prod.Name);
            cmd.Parameters.AddWithValue("price", prod.Price);
            cmd.Parameters.AddWithValue("id", prod.Id);

            using (conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

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

        public Product GetProduct(int id)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = System.IO.File.ReadAllText("ConnectionString.txt");

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ProductID, Name, Price " +
                              "FROM products " +
                              "WHERE ProductId = @id;";
            cmd.Parameters.AddWithValue("id", id);

            using (conn)
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Product product = new Product();

                    product.Id = reader.GetInt32("ProductID");
                    product.Name = reader.GetString("Name");
                    product.Price = reader.GetDecimal("Price");

                    return product;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
