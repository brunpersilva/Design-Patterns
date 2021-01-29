using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyConsole
{
    class TaxCalculator
    {
        private IBank _bankStrategy;
        public TaxCalculator(IBank bank)
        {
            _bankStrategy = bank;
        }

        public double CalculateTax(Request request)
        {
            return _bankStrategy.GetTax(request);
        }
    }
}
