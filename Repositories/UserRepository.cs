using System.Collections.Generic;

namespace potato.Repositories
{
    public class UserRepository
    {
        private readonly Dictionary<string, string> _passwordDatabase;

        public UserRepository()
        {
            _passwordDatabase = new Dictionary<string, string>
            {
                {"dmw", "awesome"},
                {"stm", "awesome"},
            };
        }

        public bool ValidateUserPassword(string username, string password)
        {
            string dbPassword;
            return _passwordDatabase.TryGetValue(username, out dbPassword) && dbPassword.Equals(password);
        }
    }
}
