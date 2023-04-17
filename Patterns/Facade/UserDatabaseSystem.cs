namespace design_patterns.Patterns.Facade
{
    public class UserDatabaseSystem
    {
        public string SaveUser(User user)
        {
            return "User saved to database";
        }
    }
}