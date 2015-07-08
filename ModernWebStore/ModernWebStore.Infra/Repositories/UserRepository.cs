using ModernWebStore.Domain.Entities;
using ModernWebStore.Domain.Repositories;
using ModernWebStore.Domain.Specs;
using ModernWebStore.Infra.Persistence.DataContexts;
using System.Linq;

namespace ModernWebStore.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private StoreDataContext _context;

        public UserRepository(StoreDataContext context)
        {
            this._context = context;
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
        }

        public User Authenticate(string email, string password)
        {
            return _context.Users
                .Where(UserSpecs.AuthenticateUser(email, password))
                .FirstOrDefault();
        }

        public User GetByEmail(string email)
        {
            return _context.Users
                .Where(UserSpecs.GetByEmail(email))
                .FirstOrDefault();
        }
    }
}
