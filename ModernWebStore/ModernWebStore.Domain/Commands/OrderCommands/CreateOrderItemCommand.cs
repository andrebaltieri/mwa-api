namespace ModernWebStore.Domain.Commands.OrderCommands
{
    public class CreateOrderItemCommand
    {
        public CreateOrderItemCommand(int quantity, decimal price, int product, int order)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.ProductId = product;
            this.OrderId = order;
        }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
