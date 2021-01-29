namespace StrategyConsole
{
    internal class Santander : IBank
    {
        private Request _request;

        public Santander(Request request)
        {
            _request = request;
        }

        public double GetTax(Request request)
        {
            return 10;
        }
    }
}