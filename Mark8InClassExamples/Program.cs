using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice = "";
            while (menuChoice != "QUIT")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("INSERT");
                Console.WriteLine("UPDATE");
                Console.WriteLine("DELETE");
                Console.WriteLine("SELECT");
                Console.WriteLine("QUIT");

                menuChoice = Console.ReadLine();

                if (menuChoice.ToUpper() == "INSERT")
                {
                    Console.WriteLine("What is the name of the new department?");
                    string newDepartment = Console.ReadLine();
                    InsertNewDepartment(newDepartment);
                }
                else if (menuChoice.ToUpper() == "UPDATE")
                {
                    Console.WriteLine("What deparment name would you like to change?");
                    string currentName = Console.ReadLine();
                    Console.WriteLine("What would you like to use as its new name?");
                    string newName = Console.ReadLine();
                    UpdateDepartmentName(currentName, newName);
                }
                else if (menuChoice.ToUpper() == "DELETE")
                {
                    Console.WriteLine("What department name would you like to delete?");
                    string departmentName = Console.ReadLine();
                    DeleteDepartment(departmentName);
                }
                else if (menuChoice.ToUpper() == "SELECT")
                {
                    List<string> departments = GetAllDepartments();
                    foreach (string department in departments)
                    {
                        Console.WriteLine(department);
                    }
                }
            }
        }

        static List<string> GetAllDepartments()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = System.IO.File.ReadAllText("ConnectionString.txt");

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT Name FROM departments;";

            using (conn)
            {
                conn.Open();

                List<string> allDepartments = new List<string>();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    string currentDepartment = reader.GetString("Name");
                    allDepartments.Add(currentDepartment);
                }

                return allDepartments;
            }
        }

        static void DeleteDepartment(string departmentName)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = System.IO.File.ReadAllText("ConnectionString.txt");

            MySqlCommand cmd = conn.CreateCommand();

            // parameterized query to prevent SQL Injection
            cmd.CommandText = "DELETE FROM departments WHERE Name = @departmentName;";
            cmd.Parameters.AddWithValue("departmentName", departmentName);

            using (conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        static void UpdateDepartmentName(string currentDepartmentName, string newDepartmentName)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = System.IO.File.ReadAllText("ConnectionString.txt");

            MySqlCommand cmd = conn.CreateCommand();

            // parameterized query to prevent SQL Injection
            cmd.CommandText = "UPDATE departments SET Name = @newName WHERE Name = @currentName;";
            cmd.Parameters.AddWithValue("newName", newDepartmentName);
            cmd.Parameters.AddWithValue("currentName", currentDepartmentName);

            using (conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        static void InsertNewDepartment(string newDepartmentName)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = System.IO.File.ReadAllText("ConnectionString.txt");

            MySqlCommand cmd = conn.CreateCommand();

            // parameterized query to prevent SQL Injection
            cmd.CommandText = "INSERT INTO departments (Name) VALUES (@deptName);";
            cmd.Parameters.AddWithValue("deptName", newDepartmentName);

            using (conn)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
