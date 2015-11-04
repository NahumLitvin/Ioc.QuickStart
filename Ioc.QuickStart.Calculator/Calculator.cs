using Ioc.QuickStart.Concreet;
using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart
{
    public class Calculator
    {

        private readonly IInputProvider _inputProvider = new ConsoleInputProvider();
        private readonly IOutputProvider _outputProvider = new ConsoleOutputProvider();
        private readonly IParseProvider _parseProvider = new ConsoleParseProvider();
        private readonly IMathProvider _mathProvider = new DefaultMathProviderProvider();

        public void MainLoop()
        {
            string input = "";
            decimal x;
            string symbol;
            decimal y;
            input = _inputProvider.GetInput();
            _parseProvider.ParseInput(input,out x, out symbol, out y);
            decimal sum = _mathProvider.Calculate(symbol, x, y);
            _outputProvider.OutPut(sum);

        }
    }
}
