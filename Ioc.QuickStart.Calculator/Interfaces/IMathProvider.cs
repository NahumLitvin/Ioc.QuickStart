namespace Ioc.QuickStart.Interfaces
{
    internal interface IMathProvider
    {
        decimal Calculate(string symbol, decimal x, decimal y);
    }
}