using System;

namespace ModernWebStore.Domain.Commands.CategoryCommands
{
    public class DeleteCategoryCommand
    {
        public DeleteCategoryCommand(Guid id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
