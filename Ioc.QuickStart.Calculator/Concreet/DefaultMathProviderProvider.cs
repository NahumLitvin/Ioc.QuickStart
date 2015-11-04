using System;
using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart.Concreet
{
    public class DefaultMathProviderProvider : IMathProvider
    {
        public decimal Calculate(string symbol, decimal x, decimal y)
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
    }
}