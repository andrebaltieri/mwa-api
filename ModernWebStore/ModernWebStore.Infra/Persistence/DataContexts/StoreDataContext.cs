using ModernWebStore.Domain.Entities;
using ModernWebStore.Infra.Persistence.Map;
using System.Data.Entity;

namespace ModernWebStore.Infra.Persistence.DataContexts
{
    public class StoreDataContext : DbContext
    {
        public StoreDataContext() :
            base("StoreConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
