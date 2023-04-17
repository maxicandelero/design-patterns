namespace design_patterns.Patterns.Facade
{
    // Some facades can work with multiple subsystems at the same time.
    public class EmailValidationSubsystem
    {
        public bool EmailIsValid(string email)
        {
            return email == "example@gmail" ? false : true;
        }
    }
}