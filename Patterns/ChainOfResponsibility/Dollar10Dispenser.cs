namespace design_patterns.Patterns.ChainOfResponsibility
{
    public class Dollar10Dispenser : DispenserBase
    {
        public override string Dispense(Currency currency)
        {    
            if (currency.GetAmount() >= 10)
            {
                int num = currency.GetAmount() / 10;
                int remainder = currency.GetAmount() % 10;
                if (remainder != 0 && this._handler != null)
                {
                    return $"Dispensing {num} 10$ note. {this._handler.Dispense(new Currency(remainder))}";
                }
                else
                {
                    return $"Dispensing {num} 10$ note. Dispensing finished.";
                }
            }
            if (this._handler == null)
                return "Dispensing finished.";
            return this._handler.Dispense(currency);
        }
    }
}