using System;

namespace SingleResponsibility
{
    public class User
    {
        private readonly string _email;
        private readonly string _password;

        public User(string email, string password)
        {
            _email = email;
            _password = password;
        }
    }
}