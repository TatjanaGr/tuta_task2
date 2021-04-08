using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value 1");
            string var1 = Console.ReadLine();
            Console.WriteLine("Enter value 2:");
            string var2 = Console.ReadLine();

            int number1 = int.Parse(var1);
            int number2 = int.Parse(var2);
            int result = number1 + number2;

            Console.WriteLine($"Sum is: {result}");
            Console.ReadKey();
        }
    }
}
