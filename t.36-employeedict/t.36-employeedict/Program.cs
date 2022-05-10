using System;

namespace Homework
{
    class Task
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            string userInput;

            Dictionary<string, string> employees= new Dictionary<string, string>();

            ReadDataBase(employees);

            while (isWork)
            {
                ShowMenu();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddDossier(employees);
                        break;
                    case "2":
                        ShowDossier(employees);
                        break;
                    case "3":
                        DeleteDossier(employees);
                        break;
                    case "4":
                        isWork = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ReadDataBase(Dictionary<string, string> employees)
        {
            employees.Add("Jonh Doe", "CEO");
            employees.Add("Anna Frank", "HR");
            employees.Add("John Dhorian", "Janitor");
        }

        static void ShowMenu()
        {
            Console.WriteLine("Enter number of command: ");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("1. Add dossier.\n" +
                "2. Show all dossiers.\n" +
                "3. Delete dossier.\n" +
                "4. Exit.");
            Console.SetCursorPosition (0, 1);
        }

        static void AddDossier(Dictionary<string, string> employees)
        {
            string name, position;

            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter position: ");
            position = Console.ReadLine();

            employees.Add(name, position);
        }

        static void ShowDossier(Dictionary<string, string> employees)
        {
            int count = 0;
            
            foreach (var employee in employees)
            {
                count++;
                Console.WriteLine($"{count}. {employee.Key} - {employee.Value}");
            }
        }
    
        static void DeleteDossier(Dictionary<string, string> employees)
        {
            string name;
            Console.WriteLine("Enter full name of employee, that you want to delete: ");
            name= Console.ReadLine();

            employees.Remove(name);
        }
    }
}