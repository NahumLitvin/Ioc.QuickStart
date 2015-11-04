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
            do
            {
                try
                {

                input = Console.ReadLine();

                string[] split = input.Split(' ');
                decimal x = decimal.Parse(split[0]);
                string symbol = split[1];
                decimal y = decimal.Parse(split[2]);

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
                        sum = x / y;
                        break;
                    case "*":
                        sum = x * y;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                    Console.WriteLine(sum);
                }
                catch
                {
                    Console.WriteLine("bad input");
                }

            } while (input != "exit");
        }
    }
}
