using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldNomads.Utility;

namespace WorldNomads.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World Nomads Test!");
            while (!Console.KeyAvailable)
            {
                Console.WriteLine("Please enter a number below, or enter E(e) to exit:");
                string input = Console.ReadLine();
                if (input.Equals("e", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting application...");
                    break;
                }
                int i;
                if (int.TryParse(input, out i))
                {
                    Console.WriteLine("All numbers:{0}{1}{0}", Environment.NewLine, IntegerParser.GetAllNumbers(i));
                    Console.WriteLine("Even numbers:{0}{1}{0}", Environment.NewLine, IntegerParser.GetEvenNumbers(i));
                    Console.WriteLine("Odd numbers:{0}{1}{0}", Environment.NewLine, IntegerParser.GetOddNumbers(i));
                    Console.WriteLine("Special numbers:{0}{1}{0}", Environment.NewLine, IntegerParser.GetSpecialNumbers(i));
                    Console.WriteLine("Fibonacci numbers:{0}{1}{0}", Environment.NewLine, IntegerParser.GetFibonacciNumbers(i));
                }
                else
                {
                    Console.WriteLine("You have entered invalid number.");
                }
            }
        }
    }
}
