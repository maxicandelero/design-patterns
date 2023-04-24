namespace design_patterns.Patterns.ChainOfResponsibility
{
    public class Dollar50Dispenser : DispenserBase
    {
        public override string Dispense(Currency currency)
        {
            if (currency.GetAmount() >= 50)
            {
                int num = currency.GetAmount() / 50;
                int remainder = currency.GetAmount() % 50;
                if (remainder != 0 && this._handler != null)
                {
                    return $"Dispensing {num} 50$ note. {this._handler.Dispense(new Currency(remainder))}";
                }
                else
                {
                    return $"Dispensing {num} 50$ note. Dispensing finished.";
                }
            }
            if (this._handler == null)
                return "Dispensing finished.";
            return this._handler.Dispense(currency);
        }
    }
}