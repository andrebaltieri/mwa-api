using System;

namespace ModernWebStore.Domain.Entities
{
    public class Category
    {
        protected Category() { }

        public Category(string title)
        {
            this.Title = title;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }        
    }
}
