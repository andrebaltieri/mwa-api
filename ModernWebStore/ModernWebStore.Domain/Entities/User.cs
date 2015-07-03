using ModernWebStore.Domain.Scopes;
using System;

namespace ModernWebStore.Domain.Entities
{
    public class User
    {
        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public void Authenticate(string email, string password)
        {
            if (!this.AuthenticateUserScopeIsValid(email, password))
                return;
        }

        public void Register()
        {
            if (!this.RegisterUserScopeIsValid())
                return;
        }
    }
}
