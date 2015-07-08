using ModernWebStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ModernWebStore.Infra.Persistence.Map
{
    public class OrderItemMap : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMap()
        {
            ToTable("OrderItems");

            HasKey(x => x.Id);

            Property(x => x.Price).IsRequired();
            Property(x => x.Quantity).IsRequired();

            HasRequired(x => x.Order);
            HasRequired(x => x.Product);
        }
    }
}
