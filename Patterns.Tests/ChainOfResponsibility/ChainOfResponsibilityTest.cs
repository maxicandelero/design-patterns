using design_patterns.Patterns.ChainOfResponsibility;
using Xunit;

namespace design_patterns.Patterns.Tests.ChainOfResponsibility
{
    public class ChainOfResponsibilityTest
    {
        [Fact]
        public void validate_an_atm_dispense_chain()
        {   
            BaseDispenser dollar50Dispenser = new Dollar50Dispenser();
            BaseDispenser dollar20Dispenser = new Dollar20Dispenser();
            BaseDispenser dollar10Dispenser = new Dollar10Dispenser();
            dollar50Dispenser.SetNext(dollar20Dispenser).SetNext(dollar10Dispenser);

            string result = dollar50Dispenser.Dispense(new Currency(130));

            Assert.Equal("Dispensing 2 50$ note. Dispensing 1 20$ note. Dispensing 1 10$ note. Dispensing finished.", result);
        }
    }
}