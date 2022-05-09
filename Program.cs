using System;

namespace Homework
{
    class Task
    {
        static void Main(string[] args)
        {
            string userInput;
            bool isWork = true;

            Dictionary<string, string> words = new Dictionary<string, string>();

            ReadDictionary(words);

            while (isWork)
            {
                ShowMenu();

                switch (userInput = Console.ReadLine())
                {
                    case "1":
                        AddNewWord(words);
                        break;
                    case "2":
                        FindWord(words);
                        break;
                    case "3":
                        isWork = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ReadDictionary(Dictionary<string, string> dictionary)
        {
            dictionary.Add("Компьютер", "устройство для обработки информации");
            dictionary.Add("Калькулятор", "устройство для проведения математических рассчетов");
            dictionary.Add("Секундомер", "устройство для рассчета времени");
            dictionary.Add("Чайник", "устройство для нагревания воды");
        }
        
        static void ShowMenu()
        {
            Console.WriteLine("1) Ввести новое слово в словарь.\n" +
                "2) Узнать значение слова.\n" +
                "3) Выход.");
        }

        static void AddNewWord(Dictionary<string, string> dictionary) 
        {
            string word;
            string meaningOfWord;

            Console.WriteLine("Введите слово: ");
            word = Console.ReadLine();

            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine("Такое слово уже есть!");
            }
            else
            {
                Console.WriteLine("Введите значение этого слова: ");
                meaningOfWord = Console.ReadLine();

                dictionary[word] = meaningOfWord;
            }            
        }

        static void FindWord(Dictionary<string, string> dictionary)
        {
            string input;

            Console.WriteLine("Введите слово:");
            input = Console.ReadLine();

            if (dictionary.ContainsKey(input))
            {
                Console.WriteLine($"{input} - {dictionary[input]}");
            }
            else
            {
                Console.WriteLine("В словаре нет такого слова!");
            }
        }
    }
}