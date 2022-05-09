using System;

namespace Homework
{
    class Task
    {
        static void Main(string[] args)
        {
            string userInput;

            Dictionary<string, string> words = new Dictionary<string, string>();

            words.Add("Компьютер", "устройство для обработки информации");
            words.Add("Калькулятор", "устройство для проведения математических рассчетов");
            words.Add("Секундомер", "устройство для рассчета времени");
            words.Add("Чайник", "устройство для нагревания воды");

            InputWord(out userInput);

            FindWord(words, userInput);
        }

        static void InputWord(out string input)
        {
            Console.WriteLine("Введите слово:");
            input = Console.ReadLine();
        }

        static void FindWord(Dictionary<string, string> dictionary, string input)
        {
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