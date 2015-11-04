using System;

namespace Ioc.QuickStart
{
    public class Calculator
    {
        public void MainLoop()
        {
            string input = "";
            decimal x;
            string symbol;
            decimal y;
            do
            {

                try
                {
                    input = GetInput();
                    ParseInput(out x, input, out symbol, out y);
                    decimal sum = Calculate(symbol, x, y);
                    Console.WriteLine("=" + sum);
                    
                }
                catch
                {
                    Console.WriteLine("bad input");
                }

            } while (input != "exit");
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
                    sum = x / y;
                    break;
                case "*":
                    sum = x * y;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return sum;
        }

        private static void ParseInput(out decimal x, string input, out string symbol, out decimal y)
        {
            string[] split = input.Split(' ');
            x = Decimal.Parse(split[0]);
            symbol = split[1];
            y = Decimal.Parse(split[2]);
        }

        private static string GetInput()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
