namespace Ioc.QuickStart.Interfaces
{
    public interface IParseProvider
    {
        void ParseInput(string input,out decimal x, out string symbol, out decimal y);
    }
}