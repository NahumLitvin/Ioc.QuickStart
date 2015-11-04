using System;
using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart.Concreet
{
    public class ConsoleOutputProvider : IOutputProvider
    {
        public void OutPut(object sum)
        {
            Console.WriteLine(sum);
        }
    }
}