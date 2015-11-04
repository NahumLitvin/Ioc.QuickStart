using System;
using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart.Concreet
{
    public class ConsoleInputProvider : IInputProvider
    {
        public string GetInput()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}