namespace design_patterns.Patterns.Facade
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class UserFacade
    {
        protected UserValidationSubsystem _userValidationSubsystem;
        protected EmailValidationSubsystem _emailValidationSubsystem;
        protected UserDatabaseSystem _userDatabaseSystem;

        public UserFacade(UserValidationSubsystem userValidationSubsystem, EmailValidationSubsystem emailValidationSubsystem, UserDatabaseSystem userDatabaseSystem)
        {
            this._userValidationSubsystem = userValidationSubsystem;
            this._emailValidationSubsystem = emailValidationSubsystem;
            this._userDatabaseSystem = userDatabaseSystem;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation(User user)
        {
            if (this._userValidationSubsystem.ValidateUser(user))
            {
                if (this._emailValidationSubsystem.EmailIsValid(user.Email))
                {
                    return this._userDatabaseSystem.SaveUser(user);
                }
            }
            return "Error!";
        }
    }
}