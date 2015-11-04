namespace Ioc.QuickStart.Interfaces
{
    internal interface IParseProvider
    {
        void ParseInput(string input,out decimal x, out string symbol, out decimal y);
    }
}