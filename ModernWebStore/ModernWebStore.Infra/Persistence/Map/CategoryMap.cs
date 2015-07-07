using ModernWebStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ModernWebStore.Infra.Persistence.Map
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");

            HasKey(x => x.Id);

            Property(x => x.Title)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
