using ModernWebStore.Domain.Scopes;

namespace ModernWebStore.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; private set; }        
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public int OrderId { get; private set; }
        public OrderItem Order { get; private set; }

        public bool Register()
        {
            return this.RegisterOrderItemScopeIsValid();
        }
    }
}
