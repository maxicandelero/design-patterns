namespace design_patterns.Patterns.TemplateMethod
{
    public class MasterCardValidator : CreditCardValidator
    {
        protected override string GetCreditCardInfo()
        {
            return "MasterCardValidator: The credit card has a valid number. ";
        }   
    }
}