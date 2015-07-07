using System;

namespace ModernWebStore.Domain.Commands.CategoryCommands
{
    public class EditCategoryCommand
    {
        public EditCategoryCommand(Guid id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
