using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Mark8InClassExamples
{
    class DepartmentRepo
    {
        private string connectionString = System.IO.File.ReadAllText("ConnectionString.txt");

        public List<Department> GetAllDepartments()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT DepartmentID, Name FROM departments;";

            using (conn)
            {
                conn.Open();

                List<Department> allDepartments = new List<Department>();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    Department currentDept = new Department();
                    currentDept.Id = reader.GetInt32("DepartmentID");
                    currentDept.Name = reader.GetString("Name");
                    allDepartments.Add(currentDept);
                }

                return allDepartments;
            }
        }

        public void DeleteDepartment(string departmentName)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

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

        public void UpdateDepartmentName(string currentDepartmentName, string newDepartmentName)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

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

        public void InsertNewDepartment(string newDepartmentName)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

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
