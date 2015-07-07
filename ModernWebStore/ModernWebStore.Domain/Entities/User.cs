using ModernWebStore.Domain.Scopes;
using ModernWebStore.SharedKernel.Helpers;
using System;

namespace ModernWebStore.Domain.Entities
{
    public class User
    {
        protected User() { }

        public User(string email, string password, bool isAdmin)
        {
            this.Email = email;
            this.Password = StringHelper.Encrypt(password);
            this.IsAdmin = isAdmin;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; }

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

        public void GrantAdmin()
        {
            this.IsAdmin = true;
        }

        public void RevokeAdmin()
        {
            this.IsAdmin = false;
        }
    }
}
