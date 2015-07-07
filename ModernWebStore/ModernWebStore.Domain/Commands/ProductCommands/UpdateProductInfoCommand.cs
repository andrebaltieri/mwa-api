namespace ModernWebStore.Domain.Commands.ProductCommands
{
    public class UpdateProductInfoCommand
    {
        public UpdateProductInfoCommand(int id, string title, string description, int category)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.CategoryId = category;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
