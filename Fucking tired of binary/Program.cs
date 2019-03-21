using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucking_tired_of_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator calculator = new calculator();
            string choice;
            do
            {
                Console.WriteLine("Choose:");
                Console.WriteLine();
                Console.WriteLine("1. Binary to decimal");
                Console.WriteLine("2. Decimail to binary");
                Console.WriteLine("0. Exit");

                choice = Console.ReadLine();

                if (int.TryParse(choice, out int intchoice))
                {
                    if (intchoice == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Input: ");
                        string input = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(calculator.Binary(input));
                        Console.WriteLine();
                    }
                    else if (intchoice == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Input: ");
                        string input = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(calculator.Decimal(input));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid choice");
                        Console.WriteLine();
                    }
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please choose a number");
                    Console.WriteLine();
                }
                
            }
            while (choice != "0");
        }
    }
}
