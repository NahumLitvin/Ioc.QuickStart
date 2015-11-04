using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart.MongoDAL
{
    public class MongoInputProvider : IInputProvider
    {
        private readonly IMongoProvider _provider;

        public MongoInputProvider(IMongoProvider provider)
        {
            _provider = provider;
        }

        public string GetInput()
        {
            _provider.DoStuff();
        }
    }


}