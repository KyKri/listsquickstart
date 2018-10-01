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
            foreach (var name in names)
            {
                Console.WriteLine($"{name.ToUpper()}");
            }
        }

        static void Main(string[] args)
        {
            ListNames();

            Console.ReadKey();
        }
    }
}
