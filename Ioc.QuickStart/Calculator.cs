using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ioc.QuickStart
{
    static class Calculator
    {
        static void Main(string[] args)
        {
            string input="";
            decimal x;
            string symbol;
            decimal y;
            do
            {

                try
                {
                input = GetInput(input);
                ParseInput(out x, input, out symbol, out y);
                decimal sum = Calculate(symbol, x, y);
                Console.WriteLine(sum);
                }
                catch
                {
                    Console.WriteLine("bad input");
                }

            } while (input != "exit");
        }

        private static void PrintOutput(decimal sum)
        {
            Console.WriteLine(sum);
        }

        private static decimal Calculate(string symbol, decimal x, decimal y)
        {
            decimal sum;
            switch (symbol)
            {
                case "+":
                    sum = x + y;
                    break;
                case "-":
                    sum = x - y;
                    break;
                case "/":
                    sum = x/y;
                    break;
                case "*":
                    sum = x*y;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return sum;
        }

        private static void ParseInput(out decimal x, string input, out string symbol, out decimal y)
        {
            string[] split = input.Split(' ');
            x = decimal.Parse(split[0]);
            symbol = split[1];
            y = decimal.Parse(split[2]);
        }

        private static string GetInput(string input)
        {
            input = Console.ReadLine();
            return input;
        }
    }
}
