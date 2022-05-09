using System;

namespace Homework
{
    class Task
    {
        static void Main(string[] args)
        {
            int revenue = 0;
            int sum;
            
            bool isTrade = true;
            
            Queue<int> buyers = new Queue<int>();

            ReadQueye(buyers);

            while (isTrade)
            {
                revenue = CountMoney(buyers, out sum, revenue);

                ShowReport(sum, revenue);

                isTrade = CheckQueue(buyers, isTrade);

                Console.ReadKey();
                Console.Clear();
            }
        }
    
        static void ReadQueye(Queue<int> buyers)
        {
            buyers.Enqueue(250);
            buyers.Enqueue(400);
            buyers.Enqueue(700);
            buyers.Enqueue(1800);
        }

        static int CountMoney(Queue<int> buyers, out int sum, int revenue)
        {
            sum = buyers.Dequeue();
            revenue += sum;

            return revenue;
        }

        static void ShowReport(int sum, int revenue)
        {
            Console.WriteLine($"Покупатель купил товаров на {sum} монет." +
                    $" Общая выручка {revenue} монет.");
        }

        static bool CheckQueue(Queue<int> buyers, bool isTrade)
        {
            if (buyers.Count == 0)
            {
                isTrade = false;
                Console.WriteLine("Больше покупателей нет.");
            }

            return isTrade;
        }
    }
}