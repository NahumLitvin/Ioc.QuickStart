using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart.MongoDAL
{
    public class MongoOutputProvider : IOutputProvider
    {        
        private readonly IMongoProvider _provider;

        public MongoOutputProvider(IMongoProvider provider)
        {
            _provider = provider;
        }
        public void OutPut(object sum)
        {
            _provider.DoStuff();
        }
    }
}