namespace StrategyConsole
{
    internal class Itau : IBank
    {
        private Request _request;
        public Itau(Request request)
        {
            _request = request;
        }

        public double GetTax(Request request)
        {
            return 20;
        }
    }
}