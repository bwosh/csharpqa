using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            CalculatorCommandsAnalyzer ui = new CalculatorCommandsAnalyzer(new Calculator());

            ui.ShowCurrentResult();

            while (!exit)
            {
                Console.Write("> ");
                ui.ExecuteCommand(Console.ReadLine());
                ui.ShowCurrentResult();
                exit = ui.ShouldExit();
            }
        }
    }
}
