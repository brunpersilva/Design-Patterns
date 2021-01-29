namespace StrategyConsole
{
    internal class Bradesco : IBank
    {
        private Request _request;
        public Bradesco(Request request)
        {
            _request = request;
        }

        public double GetTax(Request request)
        {
            return 15;
        }
    }
}