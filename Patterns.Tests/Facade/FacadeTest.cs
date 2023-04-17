using design_patterns.Patterns.Facade;
using Xunit;

namespace design_patterns.Patterns.Tests.Facade
{
    public class FacadeTest
    {
        [Fact]
        public void user_is_saved_correctly()
        {   
            var userValidationSubsystem = new UserValidationSubsystem();
            var emailValidationSubsystem = new EmailValidationSubsystem();
            var userDatabaseSystem = new UserDatabaseSystem();
            var userFacade = new UserFacade(userValidationSubsystem, emailValidationSubsystem, userDatabaseSystem);

            var user = new User();
            user.Name = "John Doe";
            user.Email = "johndoe@mail.com";
            user.Password = "123456";

            var serviceResult = userFacade.Operation(user);
            
            Assert.Equal("User saved to database", serviceResult);
        }

        [Fact]
        public void user_is_invalid()
        {   
            var userValidationSubsystem = new UserValidationSubsystem();
            var emailValidationSubsystem = new EmailValidationSubsystem();
            var userDatabaseSystem = new UserDatabaseSystem();
            var userFacade = new UserFacade(userValidationSubsystem, emailValidationSubsystem, userDatabaseSystem);

            var user = new User();
            user.Name = "John Doe";
            user.Email = "johndoe@mail.com";
            user.Password = "";

            var serviceResult = userFacade.Operation(user);
            
            Assert.Equal("Error!", serviceResult);
        }

        [Fact]
        public void user_email_is_invalid()
        {   
            var userValidationSubsystem = new UserValidationSubsystem();
            var emailValidationSubsystem = new EmailValidationSubsystem();
            var userDatabaseSystem = new UserDatabaseSystem();
            var userFacade = new UserFacade(userValidationSubsystem, emailValidationSubsystem, userDatabaseSystem);

            var user = new User();
            user.Name = "John Doe";
            user.Email = "example@gmail";
            user.Password = "123456";

            var serviceResult = userFacade.Operation(user);
            
            Assert.Equal("Error!", serviceResult);
        }
    }
}