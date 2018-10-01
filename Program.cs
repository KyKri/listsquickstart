using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListQuickstart
{
    class Program
    {
        static void ListNames()
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"{name.ToUpper()}");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added names {names[2]} and {names[3]}");
            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");

            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");

            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
        }

        static void FibonacciFun()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            for (var count = fibonacciNumbers.Count; count < 20; count++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var number in fibonacciNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static void Main(string[] args)
        {
            //ListNames();

            FibonacciFun();

            Console.ReadKey();
        }
    }
}
