using System;
using Ioc.QuickStart.Concreet;
using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart
{
    static class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator(new ConsoleInputProvider(),
                new MongoOutputProvider(), 
                new ConsoleParseProvider(),
                new DefaultMathProviderProvider()
                );

          /*  var calc = new Calculator(new ConsoleInputProvider(),
                new ConsoleOutputProvider(),
                new ConsoleParseProvider(),
                new DefaultMathProviderProvider()
                );*/


            calc.MainLoop();

            Console.ReadLine();
        }
    }
}
