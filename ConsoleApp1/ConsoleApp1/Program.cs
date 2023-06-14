using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there!");
            Console.WriteLine("This is a new message.");

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Line " + i);
            }

            Console.WriteLine("Finished writing lines.");
            Console.WriteLine("Finished writing lines02.");
            Console.WriteLine("Finished writing lines03.");

            Console.ReadLine();
        }
    }
}
