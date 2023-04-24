namespace design_patterns.Patterns.ChainOfResponsibility
{
    public class Currency
    {
        private int _amount;

        public Currency(int amt)
        {
            this._amount = amt;
        }

        public int GetAmount()
        {
            return this._amount;
        }
    }
}