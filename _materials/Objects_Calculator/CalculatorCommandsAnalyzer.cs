using System;

namespace Calculator
{
    internal sealed class CalculatorCommandsAnalyzer
    {
        private readonly Calculator _calculator;
        private bool _shouldExit;

        public CalculatorCommandsAnalyzer(Calculator calculator)
        {
            _calculator = calculator;
        }

        public void ExecuteCommand(string command)
        {
            command = command.Trim(' ');

            if (command == "exit")
            {
                _shouldExit = true;
                return;
            }

            if (!HandleCommand(command))
            {
                Console.WriteLine("Command unknown: {0}.", command);

            }
        }

        private bool HandleCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                return false;
            }

            string[] parts = command.Split(' ');

            if (parts.Length != 2 && parts.Length != 1)
            {
                return false;
            }

            if (parts.Length == 2)
            {

            }

            var operation = parts[0];
            var value = parts.Length > 1 ? parts[1] : string.Empty;

            if (parts.Length == 1)
            {
                switch (operation)
                {
                    case "m+":
                        _calculator.MemoryAdd();
                        return true;
                    case "m-":
                        _calculator.MemorySubtract();
                        return true;
                    case "mr":
                        _calculator.MemoryRecall();
                        return true;
                    case "mc":
                        _calculator.MemoryClear();
                        return true;
                    default:
                        return false;
                }
            }

            decimal decimalValue;
            if (!decimal.TryParse(value, out decimalValue))
            {
                return false;
            }

            switch (operation)
            {
                case "+":
                    _calculator.Add(decimalValue);
                    break;
                case "-":
                    _calculator.Subtract(decimalValue);
                    break;
                case "*":
                    _calculator.MultipleBy(decimalValue);
                    break;
                case "/":
                    _calculator.DivideBy(decimalValue);
                    break;
                default:
                    return false;
            }

            return true;
        }

        public void ShowCurrentResult()
        {
            Console.WriteLine("Result is:" + _calculator.GetCurrentValue());
            Console.WriteLine("Memory is:" + _calculator.GetMemoryValue());
        }

        public bool ShouldExit()
        {
            return _shouldExit;
        }
    }
}
