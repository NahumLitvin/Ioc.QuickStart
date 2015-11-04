using System;
using Ioc.QuickStart.Concreet;
using Ioc.QuickStart.Interfaces;
using Ioc.QuickStart.MongoDAL;
using SimpleInjector;

namespace Ioc.QuickStart
{
    static class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a new Simple Injector container
            var container = new Container();

            // 2. Configure the container (register)
            container.Register<IMongoProvider, MongoProvider>(Lifestyle.Singleton);
            container.Register<IInputProvider, MongoInputProvider>();
            container.Register<IOutputProvider, MongoOutputProvider>();
            container.Register<IParseProvider,ConsoleParseProvider>();
            container.Register<IMathProvider, DefaultMathProviderProvider>();

            // 3. Optionally verify the container's configuration.
            container.Verify();

            /*
            var calc = new Calculator(
                new MongoInputProvider(new MongoProvider("localhost:\\mongo")), //<===
                new MongoOutputProvider(new MongoProvider("localhost:\\mongo")),//<=== 
                new ConsoleParseProvider(),
                new DefaultMathProviderProvider()
                );

            */
            var calc = container.GetInstance<Calculator>();
            calc.MainLoop();

            Console.ReadLine();
        }
    }
}
