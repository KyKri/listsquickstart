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

        static void Main(string[] args)
        {
            ListNames();

            Console.ReadKey();
        }
    }
}
