using System;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static string GetAnswer(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static void DisplayConfirmationMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("[Press Enter to Continue]");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            DepartmentRepo repo = new DepartmentRepo();
            string menuChoice = "";
            while (menuChoice.ToUpper() != "QUIT")
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("INSERT");
                Console.WriteLine("UPDATE");
                Console.WriteLine("DELETE");
                Console.WriteLine("SELECT");
                Console.WriteLine("QUIT");

                menuChoice = Console.ReadLine();
                Console.Clear();

                if (menuChoice.ToUpper() == "INSERT")
                {
                    string newDepartment = GetAnswer("What is the name of the new department?");
                    repo.InsertNewDepartment(newDepartment);
                    DisplayConfirmationMessage("Department inserted.");
                }
                else if (menuChoice.ToUpper() == "UPDATE")
                {
                    string currentName = GetAnswer("What department name would you like to change?");
                    string newName = GetAnswer("What would you like to use as its new name?");
                    repo.UpdateDepartmentName(currentName, newName);
                    DisplayConfirmationMessage("Department name updated.");
                }
                else if (menuChoice.ToUpper() == "DELETE")
                {
                    string departmentName = GetAnswer("What department name would you like to delete?");
                    repo.DeleteDepartment(departmentName);
                    DisplayConfirmationMessage("Department deleted.");
                }
                else if (menuChoice.ToUpper() == "SELECT")
                {
                    List<Department> departments = repo.GetAllDepartments();

                    Console.WriteLine("ID   Department Name");
                    foreach (Department department in departments)
                    {
                        Console.WriteLine(department.Id + "    " + department.Name);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
