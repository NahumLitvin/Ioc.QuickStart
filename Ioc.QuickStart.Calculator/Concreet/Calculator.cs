using Ioc.QuickStart.Concreet;
using Ioc.QuickStart.Interfaces;

namespace Ioc.QuickStart
{
    public class Calculator
    {

        private readonly IInputProvider _inputProvider;
        private readonly IOutputProvider _outputProvider;
        private readonly IParseProvider _parseProvider;
        private readonly IMathProvider _mathProvider;

        public Calculator(IInputProvider inputProvider, IOutputProvider outputProvider, IParseProvider parseProvider, IMathProvider mathProvider)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
            _parseProvider = parseProvider;
            _mathProvider = mathProvider;
        }

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
