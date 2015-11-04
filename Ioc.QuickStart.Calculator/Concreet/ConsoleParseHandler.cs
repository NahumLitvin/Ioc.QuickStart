using System;
using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart.Concreet
{
    public class ConsoleParseProvider : IParseProvider
    {
        public void ParseInput(string input, out decimal x, out string symbol, out decimal y)
        {
            string[] split = input.Split(' ');
            x = decimal.Parse(split[0]);
            symbol = split[1];
            y = Decimal.Parse(split[2]);    
        }
    }
}