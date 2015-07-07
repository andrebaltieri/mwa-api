namespace ModernWebStore.Domain.Commands.CategoryCommands
{
    public class EditCategoryCommand
    {
        public EditCategoryCommand(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        public int Id { get; set; }
        public string Title { get; set; }
    }
}
