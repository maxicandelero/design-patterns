namespace design_patterns.Patterns.Facade
{
    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class UserValidationSubsystem
    {
        public bool ValidateUser(User user)
        {
            return user.Name != "" && user.Email != "" && user.Password != "" ? true : false;
        }
    }
}