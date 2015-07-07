namespace ModernWebStore.Domain.Commands.ProductCommands
{
    public class CreateProductCommand
    {
        public CreateProductCommand(string title, string description, decimal price, int quantityOnHand, int category)
        {
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.QuantityOnHand = quantityOnHand;
            this.CategoryId = category;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityOnHand { get; set; }
        public int CategoryId { get; set; }
    }
}
