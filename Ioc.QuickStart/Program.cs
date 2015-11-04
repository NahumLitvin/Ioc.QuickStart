using System;
using Ioc.QuickStart.Concreet;
using Ioc.QuickStart.Interfaces;
using Ioc.QuickStart.MongoDAL;

namespace Ioc.QuickStart
{
    static class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator(new MongoInputProvider(new MongoProvider("localhost:\\mongo")), 
                new MongoOutputProvider(new MongoProvider("localhost:\\mongo")), 
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
