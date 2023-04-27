using design_patterns.Patterns.TemplateMethod;
using Xunit;

namespace design_patterns.Patterns.Tests.TemplateMethod
{
    public class TemplateMethodTest
    {
        [Fact]
        public void check_the_visa_validator()
        {
            CreditCardValidator validator = new VisaValidator();

            string result = validator.Validate();

            Assert.Equal("CreditCardValidator: The credit card has a valid expiration date. " + 
                "CreditCardValidator: The credit card has a valid account status. " + 
                "VisaValidator: The credit card has a valid number. ", result);
        }

        [Fact]
        public void check_the_mastercard_validator()
        {
            CreditCardValidator validator = new MasterCardValidator();

            string result = validator.Validate();

            Assert.Equal("CreditCardValidator: The credit card has a valid expiration date. " + 
                "CreditCardValidator: The credit card has a valid account status. " + 
                "MasterCardValidator: The credit card has a valid number. ", result);
        }
    }
}