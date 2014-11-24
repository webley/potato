using System;
using potato.Repositories;

namespace potato.Processors
{
    public class UserProcessor
    {
        private readonly UserRepository _userRepository;

        public UserProcessor()
        {
            _userRepository = new UserRepository();
        }

        public string Login(string username, string password)
        {
            if (!_userRepository.ValidateUserPassword(username, password))
            {
                throw new ApplicationException("Login failed: incorrect username or password.");
            }

            return Guid.NewGuid().ToString();
        }
    }
}
