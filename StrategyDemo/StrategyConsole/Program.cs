using System;

namespace StrategyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Request request = new Request(100);
            Santander santander = new Santander(request);

            TaxCalculator calculator = new TaxCalculator(santander);

            calculator.CalculateTax(request);
            Console.WriteLine();
        }
    }
}
