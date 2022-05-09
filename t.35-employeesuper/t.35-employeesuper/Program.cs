using System;

namespace Homework
{
    class Task
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            bool sucess = false;
            int value = 0;
            
            List<int> numbers = new List<int>();

            while (isWork)
            {
                ShowMenu();
                
                var userInput = Console.ReadLine();

                sucess = int.TryParse(userInput, out value);

                if (sucess)
                {
                    numbers.Add(value);
                }
                else if (userInput == "sum")
                {
                    ComputeSum(numbers);
                }
                else if (userInput == "exit")
                {
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Введено не число!");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("Введите число или команду.\n" +
                "Доступные команды: \"sum\", \"exit\".");
        }

        static void ComputeSum(List<int> numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"Сумма чисел: {sum}");
        }
    }
}