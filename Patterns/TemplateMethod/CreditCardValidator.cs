namespace design_patterns.Patterns.TemplateMethod
{
    // The Abstract Class defines a template method that contains a skeleton of
    // some algorithm, composed of calls to (usually) abstract primitive
    // operations.
    //
    // Concrete subclasses should implement these operations, but leave the
    // template method itself intact.
    public abstract class CreditCardValidator
    {
        // The template method defines the skeleton of an algorithm.
        public string Validate()
        {
            string result = "";

            result += CheckExpirationDate();
            result += CheckAccountStatus();
            result += GetCreditCardInfo();

            Hook1();

            return result;
            
        }

        // These operations have to be implemented in subclasses.
        protected abstract string GetCreditCardInfo();


        // These operations already have implementations.
        protected string CheckExpirationDate()
        {
            return "CreditCardValidator: The credit card has a valid expiration date. ";
        }

        protected string CheckAccountStatus()
        {
            return "CreditCardValidator: The credit card has a valid account status. ";
        }
        
        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void Hook1() { }
    }
}