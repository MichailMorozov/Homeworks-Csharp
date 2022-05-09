using System;

namespace Homework
{
    class Task
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            int sum = 0;
            int value = 0;
            
            List<int> numbers = new List<int>();
            

            while (isWork)
            {
                Console.WriteLine("Введите число или команду.");
                var userInput = Console.ReadLine();

                if (userInput == "sum")
                {
                    foreach (var number in numbers)
                    {
                        sum += number;
                    }
                    Console.WriteLine($"Сумма чисел: {sum}");                  
                }
                else
                {                 
                    if (userInput == "exit")
                    {
                        isWork = false;
                    }
                    else
                    {
                        if (int.TryParse(userInput, out value))
                        {
                            numbers.Add(value);
                        }
                        else
                        {
                            Console.WriteLine("Введено не число");
                        }
                    }
                }
            }
        }
    }
}