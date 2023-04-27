namespace design_patterns.Patterns.TemplateMethod
{
    public class VisaValidator : CreditCardValidator
    {
        protected override string GetCreditCardInfo()
        {
            return "VisaValidator: The credit card has a valid number. ";
        }
    }
}