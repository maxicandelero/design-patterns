namespace design_patterns.Patterns.ChainOfResponsibility
{
    public class Dollar20Dispenser : BaseDispenser
    {
        public override string Dispense(Currency currency)
        {
            if (currency.GetAmount() >= 20)
            {
                int num = currency.GetAmount() / 20;
                int remainder = currency.GetAmount() % 20;
                if (remainder != 0 && this._handler != null)
                {
                    return $"Dispensing {num} 20$ note. {this._handler.Dispense(new Currency(remainder))}";
                }
                else
                {
                    return $"Dispensing {num} 20$ note. Dispensing finished.";
                }
            }
            if (this._handler == null)
                return "Dispensing finished.";
            return this._handler.Dispense(currency);
        }
    }
}