using System;

namespace Homework
{
    class Task
    {
        static void Main(string[] args)
        {
            string[] array1 = { "1", "2", "3", "2"};
            string[] array2 = { "1", "4", "5", "1"};

            List<string> collection = new List<string>();

            AddElements(collection, array1);
            AddElements(collection, array2);

            ShowElements(collection);
        }

        static void AddElements(List<string> list, string[] array)
        {
            foreach (string element in array)
            {
                if (list.Contains(element))
                {
                    continue;
                }
                else
                {
                    list.Add(element);
                }
            }
        }

        static void ShowElements(List<string> list)
        {
            foreach (var elements in list)
            {
                Console.Write(elements + " ");
            }
        }
    }
}