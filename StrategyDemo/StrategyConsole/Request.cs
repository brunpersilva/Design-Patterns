using System;

namespace StrategyConsole
{
    public class Request
    {
        private double _total;

        public Request(double total)
        {
            _total = total;
        }
        
        public double GetTotal()
        {
            return _total;
        }
    }
}