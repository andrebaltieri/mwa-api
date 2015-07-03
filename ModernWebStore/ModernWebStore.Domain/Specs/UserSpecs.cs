using ModernWebStore.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace ModernWebStore.Domain.Specs
{
    public static class UserSpecs
    {
        public static Expression<Func<User, bool>> AuthenticateUser(string email, string password)
        {
            return x => x.Email == email && x.Password == password;
        }
    }
}
