namespace ModernWebStore.Domain.Commands.OrderCommands
{
    public class CreateOrderItemCommand
    {
        public CreateOrderItemCommand(int quantity, decimal price, int product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Product { get; set; }
    }
}
