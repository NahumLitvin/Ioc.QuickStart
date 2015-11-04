using System;
using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart.Concreet
{
    internal class ConsoleOutputProvider : IOutputProvider
    {
        public void OutPut(object sum)
        {
            Console.WriteLine(sum);
        }
    }
}